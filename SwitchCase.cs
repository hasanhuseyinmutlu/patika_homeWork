using System;

namespace SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            // Expression
            switch (month)
            {
                case 1:
                    System.Console.WriteLine("Ocak ayındasınız!");
                    break;
                case 2:
                    System.Console.WriteLine("Şubat ayındasınız!");
                    break;
                case 3:
                    System.Console.WriteLine("Mart ayındasınız!");
                    break;
                case 4:
                    System.Console.WriteLine("Nisan ayındasınız!");
                    break;
                case 5:
                    System.Console.WriteLine("Mayıs ayındasınız!");
                    break;
                case 6:
                    System.Console.WriteLine("Haziran ayındasınız!");
                    break;
                case 7:
                    System.Console.WriteLine("Temmuz ayındasınız!");
                    break;
                case 8:
                    System.Console.WriteLine("Ağustos ayındasınız!");
                    break;
                
                default:
                break;   
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("Kış ayındasınız!");
                    break;
                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("İlkbahar ayındasınız!");
                    break;
                default:
                break;
            }
        }
    }
}