using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("What's Your Name?");

            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.ReadKey();
            
            Console.WriteLine("How Old Are You?");
            if (int.TryParse(Console.ReadLine(), out age)){
                if (age >= 18)
                {
                    Console.WriteLine("Access Granted");
                }
                else
                {
                    Console.WriteLine("Access Denied");
                }
            }
            Console.WriteLine();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
