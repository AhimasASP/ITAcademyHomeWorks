using System.IO;
using System.Text.Json;

namespace Airport
{
    public class JsonParser
    {
        private Person[] person = JsonSerializer.Deserialize<Person[]>(File.ReadAllText("Persons.json"));
        private Flight[] flights = JsonSerializer.Deserialize<Flight[]>(File.ReadAllText("Flights.json"));
    }
}