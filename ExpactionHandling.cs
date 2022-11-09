using System;

namespace exceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("bir sayı giriniz:");
            // int sayi = Convert.ToInt32(System.Console.ReadLine());
            // System.Console.WriteLine("girmiş olduğun sayı :" + sayi);
            // }
            // catch (System.Exception ex)
            // {
                
            //     Console.WriteLine("hata:"+ ex.Message.ToString());

            // }
            // finally {
            //     System.Console.WriteLine("işlem tamamlandı.");
            // }
            try
            {
                //int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-2000000000000");
            }
            catch (ArgumentNullException ex)
            {
                System.Console.WriteLine("ilgi alan boş bırakılmamalı !");
                Console.WriteLine(ex);

            }
            catch(FormatException ex){
                System.Console.WriteLine("Hatalı veri tipi !");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex) {
                System.Console.WriteLine("Çok küçük yada çok büyük değer girdiniz!");
                Console.WriteLine(ex);

            }
            finally{
                System.Console.WriteLine("işlem başarıyla tamamlandı.");
            }
        }
    }
}