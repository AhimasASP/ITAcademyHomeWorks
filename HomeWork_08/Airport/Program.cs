using System;
using System.Collections.Generic;
using System.IO;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonParser parser = new JsonParser();
            Person[] persons = parser.getPersonArray();

            foreach (var person in persons)
            {
                Console.WriteLine(person.name);
            }

        }
    }
}
