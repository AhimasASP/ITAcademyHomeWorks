using System;

namespace Airport.UI
{
    public class MainMenu
    {
        public MainMenu()
        {
            Console.WriteLine("Hello! Welcome to Airport terminal main menu!");
        }
        public void ShowMainMenu()
        {
            Console.WriteLine("Current time: " + ConstantsValues.CurrentTime() + 
                              "\nPlease choose the action\n" + 
                              "1. Show clients list;\n2. Show flights list;\n3. Wait for a new client.");
        }

        public void ShowClientsLIst()
        {
            ushort counter = 1;
            Console.WriteLine(new string('-', 60) + 
                              "\n| №  |\t\tClient\t\t|\tBirthday\t|\n" + 
                              new string('-', 60));

            foreach (Person person in JsonParser.getPersonsArray())
            {
                Console.WriteLine($"| {counter}\t{person.surname}\t{person.name}\t{person.birthday}");
                counter++;
            }
        }
    }
}