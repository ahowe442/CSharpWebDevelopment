using System;

namespace Technology
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var iPhone = new Smartphone("Apple", "iPhone", 1234567890, true);
            Console.WriteLine(iPhone.call(9137779292)); 
        }
    }
}
