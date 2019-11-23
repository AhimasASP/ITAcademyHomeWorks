using System;
using System.IO;

namespace HW_06_Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string unformattedPoem;
            byte counter = 0;
            Console.WriteLine("Hello! Welcome to HW_06_Task_01 main menu\nNow, the poem will be read from file\n\tUnformatted poem is:\n\t" + (unformattedPoem = File.ReadAllText(Environment.CurrentDirectory.Replace(@"HW_06_Task_01\bin\Debug\netcoreapp3.0", "") + @"\poem.txt")));
            string[] unformattedPoemArray = unformattedPoem.Replace('o', 'a').Split(';');
            Console.WriteLine("\nThere is the formatted poem:\n\t");
            foreach (string formattedPoemString in unformattedPoemArray)
            {
                if (counter == 4)
                {
                    Console.WriteLine();
                    counter = 0;
                }
                Console.WriteLine("\t" + formattedPoemString);
                counter++;
            }
        }
    }
}
