using System;
using System.Threading;

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
            Console.WriteLine(new string('-', 57) + 
                              "\n| №  |\t\tClient\t\t|\tBirthday\t|\n" + 
                              new string('-', 57));

            foreach (Person person in JsonParser.getPersonsArray())
            {
                Console.WriteLine("| " + counter + "  |\t{0, -10} {1,-15} {2, -20} " + "|", person.name, person.surname,person.birthday);
                counter++;
            }
            Console.WriteLine(new string('-', 57));
        }

        public void ShowFlightList()
        {
            ushort counter = 1;
            Console.WriteLine(new string('-', 51) +
                              "\n| {0, -1} | {1, -20} | {2, -20} |\n{3} ",new string("№"), new string("Destination"), new string("Departure time"), new string('-', 51));
            foreach (var flight in JsonParser.getFlightsArray())
            {
                Console.WriteLine("| " + counter + " | {0, -20} | {1, -20} |",flight.destTown, flight.departTime);
                counter++;
            }
            Console.WriteLine(new string('-', 51));
        }

        public void ShowWaitingProcess()
        {
            string points = "";
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine("Waiting for a new client");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Waiting for a new client..");
            }
         
        }
    }
}