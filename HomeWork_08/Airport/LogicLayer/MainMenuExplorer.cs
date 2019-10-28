using System;
using Airport.UI;

namespace Airport.LogicLayer
{
    public class MainMenuExplorer
    {
        private readonly MainMenu _mainMenu = new MainMenu();
        private bool _correctChoice = false;
        private string _errorMessage = "";

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
                    default:
                        _errorMessage = "Failure! Please make the right choice";
                        break;
                }
            }
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
            MenuShift();
            _mainMenu.ShowWaitingProcess();
            _mainMenu.ShowWelcomeMenu();
        }
    }
}