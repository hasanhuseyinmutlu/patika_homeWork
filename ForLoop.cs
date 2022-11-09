using System;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //odd numbers printer
           System.Console.WriteLine("Lütfen bir sayı griniz: ");
           int sayac = int.Parse(Console.ReadLine());
           for (int i = 0; i <= sayac; i++)
           {
                if (i%2 == 1)
                    Console.WriteLine(i);
           }

           // The sum of even,odd numbers between 1 to 1000
           int tekToplam = 0;
           int ciftToplam = 0;
           for (int i = 1; i <= 1000; i++)
           {
             if (i%2 == 1)
                tekToplam += i;
             else
                ciftToplam += i;
           }
           System.Console.WriteLine("tek :"+tekToplam);
           System.Console.WriteLine("cift :"+ciftToplam);
           
           for(int i = 1; i < 10; i++){
            if(i==4)
                break;
            System.Console.WriteLine(i);
           }
           for (int i = 1; i <10; i++)
           {
                if(i==4)
                    continue;
                System.Console.WriteLine(i);
           }


        }
    }
}