using System;

class Program
{
    static bool CiftMi(int sayi)
    {
        return sayi % 2 == 0;
    }

    static void Main()
    {
        Console.Write("Bir sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (CiftMi(sayi))
        {
            Console.WriteLine($"{sayi} çift sayıdır.");
        }
        else
        {
            Console.WriteLine($"{sayi} tek sayıdır.");
        }
    }
}