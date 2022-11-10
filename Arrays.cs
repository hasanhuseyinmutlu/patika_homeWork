using System;

namespace Arrays

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];

            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

            int[] dizi ;
            dizi = new int[5];

            renkler[0] = "mavi";
            dizi[3] = 10;

            System.Console.WriteLine(hayvanlar[1]);
            System.Console.WriteLine(dizi[3]);
            System.Console.WriteLine(renkler[0]);
            
            // Array with loops
            System.Console.Write("Lütfen dizinin eleman sayısını gir:");
            int diziUzunluğu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunluğu];

            for (int i = 0; i < diziUzunluğu; i++){
                Console.Write("Lütfen {0}.sayısıı giriniz:", i+1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayı in sayıDizisi)
                toplam += sayı;
            System.Console.WriteLine("ortalama : "+ toplam/diziUzunluğu);

        }
    }
}