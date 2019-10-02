using System;

namespace ClassWork_ExtraTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Please enter random word");
            string word = Console.ReadLine();
            Console.WriteLine("\n\tThe count of letters 'a' in string " + word + " are: " + (word.Split('a').Length -1));
        }
    }
}
