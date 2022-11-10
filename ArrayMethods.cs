using System;


namespace ArrayMethods
{
    internal class Program
    
    {
        static void Main(string[] args)
        {
            //Sort
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 27 };
            System.Console.WriteLine("*** Sıralı Dizi ***");
            foreach (var sayi in sayiDizisi)
                System.Console.WriteLine(sayi);
            //clear
            System.Console.WriteLine("*** Array Clear ***");

            Array.Clear(sayiDizisi, 2, 2);

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }
            //Reverse
            System.Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }
            //IndexOf
            System.Console.WriteLine("*** Array IndexOf ***");
            System.Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resize
            System.Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }



        }
    }

    
}