using System;

namespace TerstenSayiYazma.Recursive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isaret = -1, okunanSayi = 0;
            Console.Write("Sayı: ");
            okunanSayi = int.Parse(Console.ReadLine());
            if (okunanSayi < 0)
                okunanSayi *= -1;
            else
                isaret = 1;

            Console.WriteLine("Sayının Tersi: " + int.Parse(bol(okunanSayi)) * isaret);
            Console.ReadLine();
        }
        public static string bol(int sayi)
        {
            if (sayi / 10 <= 0.9)
            {
                return sayi + "";
            }
            return sayi % 10 + "" + bol(sayi / 10);
        }
    }
}
