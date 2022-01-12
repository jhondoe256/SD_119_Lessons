using _11_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_IntroToAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            SWAPIService swapiService = new SWAPIService();

            Console.WriteLine("Who would you like to look up?");
            string id = Console.ReadLine();
            string url = "http://swapi.dev/api/people/" + id;

            Person person = swapiService.GetAsync<Person>(url).Result;
            Planet homeworld = swapiService.GetAsync<Planet>(person.Homeworld).Result;

            Console.WriteLine($"{person.Name} is a {person.Height} cm tall {person.Gender} from {homeworld.Name}");

            foreach (string vehicleUrl in person.Vehicles)
            {
                Console.WriteLine(swapiService.GetAsync<Vehicle>(vehicleUrl).Result.Name);
            }

            Console.ReadKey();


            Console.Write("Search for a vehicle: ");
            string query = Console.ReadLine();
            SearchResult<Vehicle> vehicleSearchResult = swapiService.GetSearchAsync<Vehicle>(query).Result;

            Console.WriteLine("Number of results: " + vehicleSearchResult.Count);
            foreach(Vehicle vehicle in vehicleSearchResult.Results)
            {
                Console.WriteLine(vehicle.Name);
            }

            Console.ReadKey();



            // Add GetVehicleAsync() and GetPlanetAsync() methods to SWAPIService


            /*
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.GetAsync("http://swapi.dev/api/people/1").Result;

            if (response.IsSuccessStatusCode)
            {
                HttpContent content = response.Content;
                string contentString = content.ReadAsStringAsync().Result;
                Console.WriteLine(contentString);
                Console.ReadKey();


                Person person = response.Content.ReadAsAsync<Person>().Result;

                HttpResponseMessage planetResponse = httpClient.GetAsync(person.Homeworld).Result;
                Planet homeworld = planetResponse.Content.ReadAsAsync<Planet>().Result;

                Console.WriteLine($"{person.Name} is a {person.Height} cm tall {person.Gender} from {homeworld.Name}");

                Console.WriteLine($"{person.Name} has used the following vehicles:");
                foreach (string vehicleUrl in person.Vehicles)
                {
                    HttpResponseMessage vehicleResponse = httpClient.GetAsync(vehicleUrl).Result;

                    // Console.WriteLine(vehicleResponse.Content.ReadAsStringAsync().Result);

                    // Read the vehicle response JSON objects as Vehicles in C#
                    Vehicle vehicle = vehicleResponse.Content.ReadAsAsync<Vehicle>().Result;
                    Console.WriteLine(vehicle.Name);

                }

                Console.ReadKey();
            }
            */
        }
    }
}
