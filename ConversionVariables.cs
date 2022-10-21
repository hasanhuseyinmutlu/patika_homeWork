namespace ConvversionVariables
{
    class program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion

            byte a = 5;
            sbyte b =30;
            short c =10;

            int d = a+b+c;
            System.Console.WriteLine("d="+d);

            long h = d;
            System.Console.WriteLine("h:"+h);

            float i = h;
            System.Console.WriteLine("i:"+h);

            string e = "hasan";
            char f = 'k';
            object g = e+f+d;
            System.Console.WriteLine("g="+g);

            //Explicit Conversion

            int x = 4;
            byte t = (byte)x;
            System.Console.WriteLine("y:"+t);

            int z = 111;
            byte y =(byte)z;
            System.Console.WriteLine("y:"+y);

            float o = 5.5f;
            byte q = (byte)o;
            System.Console.WriteLine("q"+q);

            // ToString

            int gg = 10;
            string ad = gg.ToString();
            System.Console.WriteLine("ad:"+ad);

            string zz = 3.14f.ToString();
            System.Console.WriteLine("zz:"+zz);

            // System.Convert
            string s1 = "10", s2 = "20";
            int num1, num2;
            int sum;

            num1 = Convert.ToInt32(s1);
            num2 = Convert.ToInt32(s2);

            sum = num1 + num2;
            System.Console.WriteLine("sum ="+ sum);

            // Parse
            ParseMethod();

        }
        public static void ParseMethod()
        {
            string str1 = "10";
            string str2 = "10.25";
            int numb1;
            double double1;

            numb1= Int32.Parse(str1);
            double1= Double.Parse(str2);
            System.Console.WriteLine("number1 : "+numb1);
            System.Console.WriteLine("double1 : "+ double1);
        }
    }
}