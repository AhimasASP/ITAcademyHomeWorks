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
                              "1. Show clients list;\n2. Show flights list;" +
                              "\n3. Wait for a new client;\n4. Exit.");
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
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("Waiting for a new client" + points);
                Thread.Sleep(600);
                points += '.';
                if (points.Length > 3) points = "";
            }
        }

        public void ShowWelcomeMenu(Person person)
        {
            Console.WriteLine("Hello {0} {1}! Welcome to Airport terminal.\n", person.name, person.surname);
        }

        public void ShowBuyingTicketMenu()
        {
            Console.WriteLine("Welcome to ticket shop\nNow you can buy a new ticket.\nDo you have enough money?" );
        }

        public void ShowPassportControl()
        {
            Console.WriteLine("Welcome to passport control\nPlease present you passport for check.");
        }

        public void ShowEnterEscMenu()
        {
            Console.WriteLine("If positive press \"Enter\", and press \"Esq\" if your answer is negative.");
        }

        public void ShowOverWeightNotification()
        {
            Console.WriteLine("You luggage weight so much! You must pay for overweight!\nDo you want to pay for your luggage?");
            ShowEnterEscMenu();
        }
    }
}