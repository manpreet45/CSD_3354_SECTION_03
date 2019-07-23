using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _742828
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new InputNames();
            a.Run();
            (new PlayWithStacks()).Run();
        }
    }

    class InputNames
    {
        private static Queue<string> names;
        int counter = 0;

        public static Queue<string> GetQueue()
        {
            return names;
        }

        public void Run()
        {
            names = new Queue<string>();
            // how can I import a text file into a QUEUE data structure?
            // 1. get a HANDLE on the text file.

            // Read file using StreamReader. Reads file line by line  

            // string textFileName = "C:\Users\HP\Dropbox\Academic_Desk\ProgramCode\CSharpDataStructure\ConsoleApp1\ConsoleApp1";
            var fileStream = new FileStream(@"C:\Users\HP\Dropbox\Academic_Desk\ProgramCode\CSharpDataStructure\ConsoleApp1\ConsoleApp1\names.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader file = new StreamReader(fileStream))
            {

                string ln;

                while ((ln = file.ReadLine()) != null)
                {
                    names.Enqueue(ln);
                    counter++;
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
        }
    }


    class PlayWithStacks
    {
        Stack<string> names;
        public void Run()
        {
            //how do i access the in the name Queue?
            //how to GET ACCESS TO THE NAMES QUEUE??

            names = new Stack<string>();
            names.Push((InputNames.GetQueue()).Dequeue());
        }
    }
}
