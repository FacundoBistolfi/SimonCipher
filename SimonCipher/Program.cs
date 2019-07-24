using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SimonCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] z = { 0b11111010001001010110000111001101111101000100101011000011100110,
                          0b10001110111110010011000010110101000111011111001001100001011010,
                          0b10101111011100000011010010011000101000010001111110010110110011,
                          0b11011011101011000110010111100000010010001010011100110100001111,
                          0b11010001111001101011011000100000010111000011001010010011101111 };



            Console.WriteLine(0b10001110111110010011000010110101000111011111001001100001011010);
            Console.WriteLine(getNBits(0b10001110111110010011000010110101000111011111001001100001011010,3));

            Console.ReadKey();
        }

        static private ulong rotate(ulong bloque, int cant)
        {
            int n = 5;
            
            return ((bloque << cant) + (bloque >> (n - cant))) % (ulong)Math.Pow(2,n);
        }
        static private ulong getNBits(ulong bloque, int n)
        {
            return bloque >> (62 - n);
        }

    }
}
