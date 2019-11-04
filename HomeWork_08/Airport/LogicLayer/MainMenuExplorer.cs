using System;
using System.Threading;
using Airport.UI;

namespace Airport.LogicLayer
{
    public class MainMenuExplorer
    {
        private readonly MainMenu _mainMenu = new MainMenu();
        private bool _correctChoice = false;
        private string _errorMessage = "";

        public delegate void YesNoTool();
        public delegate void YesAction();
        public delegate void NoAction();


        private void MenuShift()
        {
            Console.Clear();
            Console.WriteLine(new string('\n', 40));
        }

        private void GoBack()
        {
            Console.WriteLine("Please press any key to main menu");
            Console.ReadKey();
            GoToMainMenu();
        }

        public void GoToMainMenu()
        {
            while (!_correctChoice)
            {
                MenuShift();
                _mainMenu.ShowMainMenu();
                Console.WriteLine("\n" + _errorMessage);
                Int16.TryParse(Console.ReadLine(), out var choice);

                switch (choice)
                {
                    case 1:
                        GoToClientList();
                        _correctChoice = true;
                        break;
                    case 2:
                        GoToFlightList();
                        _correctChoice = true;
                        break;
                    case 3:
                        GoToWaitingForNewClient();
                        _correctChoice = true;
                        break;
                    case 4:
                        Console.WriteLine("Good bye!");
                        Thread.Sleep(1000);
                        _correctChoice = true;
                        break;
                    default:
                        _errorMessage = "Failure! Please make the right choice";
                        break;
                }
            }
            _correctChoice = false;
            _errorMessage = "";
        }

        public void GoToClientList()
        {
            MenuShift();
            _mainMenu.ShowClientsLIst();
            GoBack();
        }

        public void GoToFlightList()
        {
            MenuShift();
            _mainMenu.ShowFlightList();
            GoBack();
        }

        public void GoToWaitingForNewClient()
        {
            Person person = new Person();
            MenuShift();
            _mainMenu.ShowWaitingProcess();
            person = JsonParser.GetRandomPerson();

            if (person.haveTicket)
            {
                MenuShift();
                _mainMenu.ShowWelcomeMenu(person);
                Console.WriteLine("Ok! You have a ticket!\nPlease go to passport control.");
                Thread.Sleep(3000);
                GoToPassportControl(person);
            }
            else
            {
                MenuShift();
                _mainMenu.ShowWelcomeMenu(person);
                YesNoTool tool = _mainMenu.ShowBuyingTicketMenu;
                tool += _mainMenu.ShowEnterEscMenu;
                YesAction yesAction = delegate { Console.WriteLine("OK! Now you have a ticket! Please go to passport control."); };
                NoAction noAction = delegate { Console.WriteLine("! Sorry you can't uses our services without any ticket. Please come back latter.\nGood Luck to you!"); };
                
                if (EnterEscapeMenu(tool, yesAction, noAction, "Please, enter the right choice!"))
                {
                    GoToPassportControl(person);
                }
            }
        }

        public bool EnterEscapeMenu(YesNoTool tool, YesAction yes, NoAction no, string error)
        {
            ConsoleKey key = ConsoleKey.F19;
            while (key != ConsoleKey.Enter && key != ConsoleKey.Escape)
            {
                tool.Invoke();
                Console.WriteLine(_errorMessage);
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.Enter)
                {
                    yes.Invoke();
                    Thread.Sleep(3000);
                    return true;
                }

                if (key == ConsoleKey.Escape)
                {
                    no.Invoke();
                    GoBack();
                }
                _errorMessage = error;
                MenuShift();
            }
            _errorMessage = "";
            return false;
        }

        public void GoToPassportControl(Person person)
        {
            MenuShift();
            _mainMenu.ShowPassportControl();
            if (PassportControl.CheckForValidPassport(person))
            {
                Console.WriteLine("All is right! Please present your luggage for control.");
                Thread.Sleep(3000);
                GoToLuggageControl(person);
            }
            else
            {
                Console.WriteLine("Sorry, your passport invalid, you can't uses our services.\nGood bye");
                GoBack();
            }
        }

        public void GoToLuggageControl(Person person)
        {

        }
    }
}