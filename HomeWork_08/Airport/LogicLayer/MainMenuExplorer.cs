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
                YesAction yesAction = delegate { Console.WriteLine("\nOK! Now you have a ticket! Please go to passport control."); };
                NoAction noAction = delegate { Console.WriteLine("\nSorry you can't uses our services without any ticket. Please come back latter.\nGood Luck to you!"); };
                
                if (EnterEscapeMenu(tool, yesAction, noAction, ConstantsValues.ErrorMessage))
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
                _mainMenu.ShowEnterEscMenu();
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
                    Thread.Sleep(3000);
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
                Console.WriteLine("All is right! Now you should go to luggage control.");
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
            YesNoTool tool = delegate
            {
                Console.WriteLine($"Dear {person.name} {person.surname} please, let us check your luggage.");
            };

            YesAction yseAction = delegate
            {
                Console.WriteLine("Ok! wait for a few minutes, we start to check your luggage.");
            };

            NoAction noAction = delegate
            {
                Console.WriteLine(
                    $"Sorry dear {person.name} {person.surname} you can't use our services without this stage of luggage control." +
                    $"\nPlease come back later");
            };

            if (!EnterEscapeMenu(tool, yseAction, noAction, ConstantsValues.ErrorMessage))
            {
                GoBack();
            }

            tool = _mainMenu.ShowOverWeightNotification;
            yseAction = delegate
            {
                Console.WriteLine("Ok, all right. Now we check your luggage for a prohibited items");
            };

            if (!EnterEscapeMenu(tool, yseAction, noAction, ConstantsValues.ErrorMessage))
            {
                GoBack();
                return;
            }
            if (person.baggageWeight > ConstantsValues.AcceptedWeight)
            {
                    _mainMenu.ShowSuccessLuggageControlResult();
            }
            if (person.prohibitedItems)
            {
                _mainMenu.ShowProhibitedItemsEnables(person);
                GoBack();
                return;
            }

        }


    }
}