using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;

namespace Airport
{
    public class JsonParser
    {
     

        public static Person[] getPersonsArray()
        {
            return JsonSerializer.Deserialize<Person[]>(File.ReadAllText(ConstantsValues.JsonPath + "Persons.json"));
        }

        public static Flight[] getFlightsArray()
        {
            return JsonSerializer.Deserialize<Flight[]>(File.ReadAllText(ConstantsValues.JsonPath + "Flights.json"));
        }

        public static Person GetRandomPerson()
        {
            int randomCount = new Random().Next(0, getPersonsArray().Length);
            return getPersonsArray()[randomCount];
        }
    }
}