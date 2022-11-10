namespace WhileForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while
            Console.WriteLine("sayı gir : ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<= sayi)
            {
                toplam += sayac;
                sayac ++;
            }
            Console.WriteLine(toplam/sayi);

            // 'a' to 'z'
            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character ++;
            }
            Console.WriteLine("***** Foreach ******");
            string[] arabalar = {"BMW","Ford","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}