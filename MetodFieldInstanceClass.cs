internal partial class Program
{
    private static void Main(string[] args)
    {

        Customer customer = new Customer();
        customer.CustomerName = "Hasan";
        customer.CustomerSurname = "Mutlu";
        customer.CustomerTelNo = "5531887122";
        
        customer.CustomerInfo();
    }
    
       
        
}
class Customer()
        {
             public int CustomerId { get; set; }

             public string CustomerName  { get; set; }

             public string CustomerSurname { get; set; }

             public string CustomerTelNo { get; set; }

            public void  CustomerInfo() {
                System.Console.WriteLine("Ad{0}", CustomerName);
                System.Console.WriteLine("Soyad{0}", CustomerSurname);
                System.Console.WriteLine("Telefon{0}", CustomerTelNo);
            }     
            
        }

