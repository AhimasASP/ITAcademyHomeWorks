using System;
using System.Collections.Generic;
using System.IO;
using Airport.UI;

namespace Airport
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonParser parser = new JsonParser();
            //Person[] persons = parser.getPersonArray();

            MainMenu menu = new MainMenu();
            menu.ShowMainMenu();
            menu.ShowClientsLIst();

            

        }
    }
}
