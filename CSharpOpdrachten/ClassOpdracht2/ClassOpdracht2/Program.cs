using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //maak hier een variable aan met type ShopGreeter 

            //roep de function greetcustomer aan
            ShopGreeter ShopGreeter = new ShopGreeter();
            ShopGreeter.GreetCustomer();
            
            

        }
    }
}