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

           
            bool hasitworked = false;
            while (!hasitworked)
            {
                Console.WriteLine("How Old Are You?");
                if (int.TryParse(Console.ReadLine(), out int age))
                {
                    if (age >= 18)
                    {
                        Console.WriteLine("Access Granted");
                        mynewfunction();
                    }
                    else
                    {
                        Console.WriteLine("Access Denied");
                        my2ndfunction();
                    }
                    hasitworked = true;
                }
                else
                {
                    Console.WriteLine("I do not understand characters");
                }
            }
            Console.WriteLine();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        private static void mynewfunction()
        {
            Console.WriteLine("This is inside my new function");
            my2ndfunction();
        }

        private static void my2ndfunction()
        {
            Console.WriteLine("This is inside my 2nd function");
            List<Music> musiclist = new List<Music>();
            Music firstnote = new Music();
            firstnote.note = "C";
            firstnote.enabled = true;
            firstnote.position = 1;

            Music secondnote = new Music();
            secondnote.note = "C#";
            secondnote.enabled = false;
            secondnote.position = 2;

            Music thirdnote = new Music();
            thirdnote.note = "D";
            thirdnote.enabled = true;
            thirdnote.position = 3;

            musiclist.Add(firstnote);
            musiclist.Add(secondnote);
            musiclist.Add(thirdnote);

            foreach (var note in musiclist.Where(note => note.enabled))
            {
                Console.Write(note.note);
                Console.Write(",");
            }
        }
    }
}
