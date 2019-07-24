using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonCipher
{
    class Simon

    {

        //https://eprint.iacr.org/2013/404.pdf

        private static readonly ulong[] z = 
            { 0b11111010001001010110000111001101111101000100101011000011100110,
              0b10001110111110010011000010110101000111011111001001100001011010,
              0b10101111011100000011010010011000101000010001111110010110110011,
              0b11011011101011000110010111100000010010001010011100110100001111,
              0b11010001111001101011011000100000010111000011001010010011101111
            };

        private int t, j, n, m;
        private ulong mod;
        //private ulong[] keys;

        public Simon(int tamBloque, int tamKey)
        {
            //Calculo n y m
            n = tamBloque / 2;
            m = tamKey / n;

            //Calculo T y J
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

            mod = (ulong)Math.Pow(2, n);
            //keys = keyExpansion();
        }

        //Funcion de expansion de key
        private ulong[] keyExpansion(ulong[] key)
        {
            ulong[] keys = new ulong[t];
            for(int i = 0; i<m; i++)
            {
                keys[i] = key[i];
            }

            ulong zet = z[j];
            ulong tmp;
            for(int i = m; i<t; i++)
            {
                tmp = rotl(key[i - 1], 3);
                if (m == 4) tmp = tmp ^ key[i-3];
                tmp = tmp ^ rotl(tmp, 1);
                key[i] = key[i - m] ^ tmp ^ getNBits(rotl(zet,i-m)) ^ (ulong.MaxValue -3);
                keys[i] = key[i];
            }
            return keys;
        }

        //Bitshitf rotate
        private ulong rotl(ulong bloque, int cant)
        {
            return ((bloque << cant) + (bloque >> (n - cant))) % mod;
        }

        //Get n keys
        private ulong getNBits(ulong bloque)
        {
            return bloque >> (62 - n);
        }

        public ulong[] cifrarMensaje(ulong[] key, ulong[] msg)
        {
            ulong[] cifrado = new ulong[msg.Length];
            for(int i = 0; i< msg.Length/2; i++) { 
                ulong[] cif = cifrar(new ulong[]{ msg[i], msg[i + 1] }, keyExpansion(key));
                cifrado[i] = cif[0];
                cifrado[i + 1] = cif[1];
            }
            return cifrado;
        }

        private ulong[] cifrar(ulong[] keys, ulong[] msg)
        {
            for(int i=0; i<t; i++)
            {
                ulong tmp = msg[0];
                msg[0] = msg[1] ^ (rotl(msg[1], 1) + rotl(msg[1], 8)) ^ rotl(msg[1], 2) ^ keys[i];                msg[1] = tmp;
            }
            return msg;
        }

        private ulong[] descifrar(ulong[] keys, ulong[] msg)
        {
            for (int i = t; i >= 0; i--)
            {
                ulong tmp = msg[1];
                msg[1] = msg[0] ^ (rotl(msg[0], 1) + rotl(msg[0], 8)) ^ rotl(msg[0], 2) ^ keys[i];
                msg[0] = tmp;
            }
            return msg;
        }
    }
}
