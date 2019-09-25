using System;

namespace Oops
{
    class Program: Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 cs = new Class1();
            
            
            cs.myfriendage = 25;
            cs.name = "haritha";
            cs.contact = 9440430078;
           
            Console.WriteLine("my friends name {0} ",cs.name);
            Console.WriteLine("my friend age {0}" , cs.myfriendage);
            Console.WriteLine("my friend contact {0}" , cs.contact);


        }
    }
}
