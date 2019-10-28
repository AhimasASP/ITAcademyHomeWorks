using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;

namespace Airport
{
    public class JsonParser
    {
        //private readonly Person[] _persons;
        //private readonly Flight[] _flights;


        //public JsonParser()
        //{
        //    this._persons = JsonSerializer.Deserialize<Person[]>(File.ReadAllText(ConstantsValues.JsonPath + "Persons.json"));
        //    this._flights = JsonSerializer.Deserialize<Flight[]>(File.ReadAllText(ConstantsValues.JsonPath + "Flights.json"));
        //}

        public static Person[] getPersonsArray()
        {
            return JsonSerializer.Deserialize<Person[]>(File.ReadAllText(ConstantsValues.JsonPath + "Persons.json")); ;
        }

        public static Flight[] getFlightsArray()
        {
            return JsonSerializer.Deserialize<Flight[]>(File.ReadAllText(ConstantsValues.JsonPath + "Flights.json")); ;
        }

        public Person GetRandomPerson()
        {
            int randomCount = Random.Next();
        }
    }
}