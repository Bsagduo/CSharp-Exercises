using System;

namespace BasicMathOperations
{
    class Program
    {
        static double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }

        static double Cikar(double sayi1, double sayi2)
        {
            return sayi1 - sayi2;
        }

        static double Carp(double sayi1, double sayi2)
        {
            return sayi1 * sayi2;
        }

        static double Bol(double sayi1, double sayi2)
        {
            if (sayi2 == 0)
            {
                Console.WriteLine("Sıfıra bölme hatası!");
                return 0;
            }

            return sayi1 / sayi2;
        }

        static void Main(string[] args)
        {
            double sayi1 = 20;
            double sayi2 = 5;

            Console.WriteLine($"Toplam: {Topla(sayi1, sayi2)}");
            Console.WriteLine($"Fark: {Cikar(sayi1, sayi2)}");
            Console.WriteLine($"Çarpım: {Carp(sayi1, sayi2)}");
            Console.WriteLine($"Bölüm: {Bol(sayi1, sayi2)}");
        }
    }
}