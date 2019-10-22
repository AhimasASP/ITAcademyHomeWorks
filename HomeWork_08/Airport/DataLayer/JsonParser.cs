using System.IO;
using System.Text.Json;

namespace Airport
{
    public class JsonParser
    {
        private readonly Person[] _persons;
        private readonly Flight[] _flights;


        public JsonParser()
        {
            this._persons = JsonSerializer.Deserialize<Person[]>(File.ReadAllText(Constants.JsonPath + "Persons.json"));
            this._flights = JsonSerializer.Deserialize<Flight[]>(File.ReadAllText(Constants.JsonPath + "Flights.json"));
        }

        public Person[] getPersonArray()
        {
            return _persons;
        }

        public Flight[] getFlights()
        {
            return _flights;
        }
    }
}