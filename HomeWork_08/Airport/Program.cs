using System;
using System.IO;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine();
            JsonParser parser = new JsonParser();
            Person[] persons = parser.getPersonArray();

            foreach (var person in persons)
            {
                Console.WriteLine(person.name);
            }
        }
    }
}
