internal class Program
{
    private static void Main(string[] args)
    {
        int a = 2 ;

        int b = 2 ; 

        int toplam;

        toplam = Topla(a,b);
        
        System.Console.WriteLine(toplam);

        static int Topla(T t){

            return t + t;
        }
    }
}