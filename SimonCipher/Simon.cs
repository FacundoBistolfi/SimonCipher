using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonCipher
{
    class Simon

    {

        #region Declaracion de variables y constructor

        //Paper:
        //https://eprint.iacr.org/2013/404.pdf


        private static readonly ulong[] z = { 0b11111010001001010110000111001101111101000100101011000011100110,
                          0b10001110111110010011000010110101000111011111001001100001011010,
                          0b10101111011100000011010010011000101000010001111110010110110011,
                          0b11011011101011000110010111100000010010001010011100110100001111,
                          0b11010001111001101011011000100000010111000011001010010011101111 };


        private int t, j, n, m;
        private ulong[] keysGlobal;

        //Constructor de la clase que toma por parametros el tamaño de bloque o palabra a utilizar y el tamaño de la key,
        //El estado actual del cifrador solo permite cifrar con bloques de 128 bits
        public Simon(int tamBloque, int tamKey)
        {
            //Calculo n y m
            n = tamBloque / 2;
            m = tamKey / n;

            //Calculo T y J 
            //Solamente está implementado el caso en el que n vale 64
            if ((n == 16) && (m == 4)) { j = 0; t = 32; }
            if ((n == 24) && (m == 3)) { j = 0; t = 36; }
            if ((n == 24) && (m == 4)) { j = 1; t = 36; }
            if ((n == 32) && (m == 3)) { j = 2; t = 42; }
            if ((n == 32) && (m == 4)) { j = 3; t = 44; }
            if ((n == 48) && (m == 2)) { j = 2; t = 52; }
            if ((n == 48) && (m == 3)) { j = 3; t = 54; }
            if ((n == 64) && (m == 2)) { j = 2; t = 68; }
            if ((n == 64) && (m == 3)) { j = 3; t = 69; }
            if ((n == 64) && (m == 4)) { j = 4; t = 72; }

            keysGlobal = new ulong[0];
        }

        #endregion

        #region Funciones de cifrado y descifrado

        public byte[] cifrar(byte[] key, byte[] msg)
        {
            ulong[] keyU = byteToUlongs(key, m*(n/8));
            ulong[] msgU = byteToUlongs2(msg);
            ulong[] cifrado = new ulong[msgU.Length];

            for (int i = 0; i < msgU.Length / 2; i++)
            {

                ulong[] cif = cifrarBloque(keyExpansion(keyU), new ulong[] { msgU[i], msgU[i + 1] });
                cifrado[i] = cif[0];
                cifrado[i + 1] = cif[1];
            }


            return ulongToByte(cifrado);

        }

        public byte[] descifrar(byte[] key, byte[] msg)
        {

            ulong[] keyU = byteToUlongs(key, m * (n / 8));
            ulong[] msgU = byteToUlongs2(msg);


            ulong[] descifrado = new ulong[msgU.Length];
            for (int i = 0; i < msgU.Length / 2; i++)
            {
                ulong[] des = descifrarBloque(keyExpansion(keyU), new ulong[] { msgU[i], msgU[i + 1] });
                descifrado[i] = des[0];
                descifrado[i + 1] = des[1];

            }

            return ulongToByte(descifrado);

        }

        private ulong[] cifrar(ulong[] key, ulong[] msg)
        {
            ulong[] cifrado = new ulong[msg.Length];
            for(int i = 0; i< msg.Length/2; i++) { 
                ulong[] cif = cifrarBloque(keyExpansion(key), new ulong[] { msg[i], msg[i + 1] });
                cifrado[i] = cif[0];
                cifrado[i + 1] = cif[1];
            }
            return cifrado;
        }

        private ulong[] descifrar(ulong[] key, ulong[] msg)
        {
            ulong[] cifrado = new ulong[msg.Length];
            for (int i = 0; i < msg.Length / 2; i++)
            {
                ulong[] cif = descifrarBloque(keyExpansion(key), new ulong[] { msg[i], msg[i + 1] });
                cifrado[i] = cif[0];
                cifrado[i + 1] = cif[1];
            }
            return cifrado;
        }

        #endregion

        #region Funciones de cifrado y descifrado de bloque para unico bloque
        //Solo utilizar estas funciones cuando se tenga cargada la variable "keysGlobal"

        public byte[] cifrarBloque(byte[] bloque)
        {
            ulong[] msg = byteToUlongs2(bloque);
            for (int i = 0; i < t; i++)
            {
                ulong tmp = msg[1];
                msg[1] = msg[0] ^ (rotl(msg[1], 1) + rotl(msg[1], 8)) ^ rotl(msg[1], 2) ^ keysGlobal[i];
                msg[0] = tmp;
            }
            return ulongToByte(msg);
        }

        public byte[] descifrarBloque(byte[] bloque)
        {
            ulong[] msg = byteToUlongs2(bloque);
            for (int i = t - 1; i >= 0; i--)
            {
                ulong tmp = msg[0];
                msg[0] = msg[1] ^ keysGlobal[i] ^ rotl(msg[0], 2) ^ (rotl(msg[0], 1) + rotl(msg[0], 8));
                msg[1] = tmp;
            }
            return ulongToByte(msg);
        }

        #endregion

        #region Funciones de cifrado y descifrado de bloque

        // FUNCIONES DE CIFRADO DE BLOQUE

        private ulong[] cifrarBloque(ulong[] keys, ulong[] msg)
        {
            for (int i=0; i<t; i++)
            {
                ulong tmp = msg[1];
                msg[1] = msg[0] ^ (rotl(msg[1], 1) + rotl(msg[1], 8)) ^ rotl(msg[1], 2) ^ keys[i];
                msg[0] = tmp;
            }
            return msg;
        }

        private ulong[] descifrarBloque(ulong[] keys, ulong[] msg)
        {
            for (int i = t-1; i >= 0; i--)
            {
                ulong tmp = msg[0];
                msg[0] = msg[1] ^ keys[i] ^ rotl(msg[0], 2) ^ (rotl(msg[0], 1) + rotl(msg[0], 8));
                msg[1] = tmp;
            }
            return msg;
        }

        #endregion

        #region Funcion de expansion de key

        //  FUNCION DE EXPANSION DE KEY

        private ulong[] keyExpansion(ulong[] key)
        {
            if (key.Length != m)
            {
                ulong[] temp = key;
                key = new ulong[m];
                temp.CopyTo(key, 0);
            }
            ulong[] keys = new ulong[t];
            for (int i = 0; i < m; i++)
            {
                keys[i] = key[i];
            }

            ulong zet = z[j];
            ulong tmp;
            for (int i = m; i < t; i++)
            {
                tmp = rotl(keys[i - 1], 3);
                if (m == 4) tmp = tmp ^ keys[i - 3];
                tmp = tmp ^ rotl(tmp, 1);
                keys[i] = keys[i - m] ^ tmp ^ getNBits(rotl(zet, i - m)) ^ (ulong.MaxValue - 3);
                //keys[i] = key[i];
            }
            return keys;
        }
        public void calcularKeys(byte[] key)
        {
            ulong[] keyU = byteToUlongs(key, m * (n / 8));
            keysGlobal = keyExpansion(keyU);
        }

        #endregion

        #region Operaciones aritmeticas
        //OPERACIONES ARITMETICAS

        //Bitshitf rotate
        private ulong rotl(ulong bloque, int cant)
        {
            //return ((bloque << cant) + (bloque >> (n - cant))) % mod;
            return ((bloque << cant) + (bloque >> (64 - cant)));
        }

        //Get n keys
        private ulong getNBits(ulong bloque)
        {
            return bloque >> (62 - n);
        }
        #endregion

        #region Funciones de conversion
        // FUNCIONES DE CONVERSION

        //Conversiones entre arrays de words de 64 bytes (ulongs), Strings y arrays de bytes

        //Funcion que convierte un string a un array de ulongs , se puede seleccionar tambien una cantidad minima de bytes
        //(si sobran se rellenan con ceros)
        public ulong[] stringToUlongs(String s)
        {
            return stringToUlongs(s, 0);
        }
        public ulong[] stringToUlongs(String s, int minBytes)
        {
            //Paso la cadena a un array de bytes
            return byteToUlongs(Encoding.ASCII.GetBytes(s), minBytes);
        }


        //Funcion que convierte un array de bytes en un array de ulong
        public ulong[] byteToUlongs2(byte[] bytes, int minBytes)
        {

            //Paso el array a otro que tenga grupos de 16 bytes (128 bytes de palabra) formados   
            int cant = (bytes.Length % 16 == 0) ? bytes.Length : bytes.Length + (16 - bytes.Length % 16);
            if (cant < minBytes) cant = minBytes;
            byte[] b = new byte[cant];
            bytes.CopyTo(b, 0);

            Console.WriteLine();

            //Creo el array de words (8 bytes)
            ulong[] c = new ulong[b.Length / 8];

            //Hago el pasaje de bytes a words
            for (int i = 0; i < c.Length; i++)
                c[i] = BitConverter.ToUInt64(b, i * 8);

            return c;
        }

        //Sobrecarga de la funcion
        public ulong[] byteToUlongs2(byte[] bytes)
        {
            return byteToUlongs2(bytes, 0);
        }

        //Funcion que convierte un array de bytes en un array de ulong
        public ulong[] byteToUlongs(byte[] bytes, int minBytes)
        {

            //Paso el array a otro que tenga grupos de 8 bytes (64 bytes de ulong) formados   
            int cant = (bytes.Length % 8 == 0) ? bytes.Length : bytes.Length + (8 - bytes.Length % 8);
            if (cant < minBytes) cant = minBytes;
            byte[] b = new byte[cant];
            bytes.CopyTo(b, 0);

            Console.WriteLine();

            //Creo el array de words (8 bytes)
            ulong[] c = new ulong[b.Length / 8];

            //Hago el pasaje de bytes a words
            for (int i = 0; i < c.Length; i++)
                c[i] = BitConverter.ToUInt64(b, i * 8);

            return c;
        }

        //Sobrecarga de la funcion
        public ulong[] byteToUlongs(byte[] bytes)
        {
            return byteToUlongs(bytes, 0);
        }


        //Funcion que convierte un array de ulong a un string (En ASCII)
        public String ulongToString(ulong[] array)
        {
            String decoded = "";
            for (int i = 0; i < array.Length; i++)
            {
                decoded += Encoding.ASCII.GetString(BitConverter.GetBytes(array[i]));
            }
            return decoded;
        }

        public byte[] ulongToByte(ulong[] array)
        {
            byte[] bytes = new byte[array.Length * 8];

            for(int i=0; i<array.Length; i++)
            {
                byte[] bytesUlong = BitConverter.GetBytes(array[i]);
                for(int j = 0; j<bytesUlong.Length; j++)
                {
                    bytes[i * 8 + j] = bytesUlong[j];
                }
            }

            return bytes;
        }


        #endregion


    }
}
