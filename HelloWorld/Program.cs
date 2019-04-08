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
            int position = 1;
            var lastnote = "";
            for (int i = 0; i < 50; i++)
            {
                position = position + i;
                var currentnote = pickrandomnote(position, lastnote);
                musiclist.Add(currentnote);
                lastnote = currentnote.note;
            }
            
            foreach (var note in musiclist.Where(note => note.enabled).OrderBy(note => note.position))
            {
                Console.Write(note.note);
                Console.Write(",");
            }
        }

        private static Music pickrandomnote(int position, string previousnote)
        {
            string[] possiblenotes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
            if (!string.IsNullOrEmpty(previousnote))
            {
                if (previousnote == "C")
                {
                    possiblenotes = new string[] { "C", "D", "D#"};
                }
                else if (previousnote == "D")
                {
                    possiblenotes = new string[] { "D", "E", "F#"};
                }
            }
            int[] trueorfalse = { 0, 1 };

            Random random = new Random(Guid.NewGuid().GetHashCode());
            Music music = new Music();
            music.note = possiblenotes[random.Next(possiblenotes.Length)];
            music.enabled = Convert.ToBoolean(trueorfalse[random.Next(2)]);
            music.position = position;

            return music;
        }
    }
}
