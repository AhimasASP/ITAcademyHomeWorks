using System;
using System.IO;
using System.Text.Json;

namespace Airport
{
    public class JsonParser
    {
        private Person[] _person;
        private Flight[] _flights;

        public JsonParser()
        {
            
            this._person = JsonSerializer.Deserialize<Person[]>(File.ReadAllText(Constants.JsonPath + "Persons.json"));
            //this._flights = JsonSerializer.Deserialize<Flight[]>(File.ReadAllText("Flights.json"));
        }

        public Person[] getPersonArray()
        {
            return _person;
        }

    }
}