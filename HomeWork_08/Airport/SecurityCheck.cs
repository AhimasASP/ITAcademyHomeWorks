using System;
using System.Threading;
using Airport.UI;

namespace Airport
{
    public class SecurityCheck
    {
        private MainMenu mainMenu;
        private readonly int _weight;
        private readonly bool _prohibitedItems = false;
        private readonly string _client;
        public SecurityCheck(int weight, string name, string surname)
        {
            _weight = weight;
            _client = name + "'s " + surname;
            CheckForOverWeight();
        }

        public SecurityCheck(int weight, string name, string surname, bool prohibitedItems) : this(weight, name, surname)
        {
            _prohibitedItems = prohibitedItems;
            if (_prohibitedItems)
            {
                Console.WriteLine("Alarm! There is prohibited items in " + _client + " luggage!\nDear " +
                                  _client.Replace("'s", "" ) + 
                                  " please follow to deep security check in police!");
            }
            Thread.Sleep(2000);
        }

        public void CheckForOverWeight()
        {
            if (_weight > ConstantsValues.AcceptedWeight)
            {
               
            }
        }
    }
}