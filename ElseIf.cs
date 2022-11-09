using System;

namespace elseIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time>=6 && time<11)
            {
                Console.WriteLine("Good Morning");
            }
            else if (time>= 19)
            {
                Console.WriteLine("Have a nice days");
            }
            else if(time>= 24)
            {
                Console.WriteLine("Good nights");
            }
            string sonuc = time<=18 ? "Good Morning!" : "Good Night!";
            sonuc = time>=6 && time<11 ? "Morning!" : time<=18 ? "Good days!" : "Good Night!" ;
            Console.WriteLine(sonuc);
        }
    }
}