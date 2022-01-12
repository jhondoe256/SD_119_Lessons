using _11_IntroToAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _11_IntroToAPI
{
    public class SWAPIService
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<Person> GetPersonAsync(string url)
        {
            HttpResponseMessage response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                Person person = await response.Content.ReadAsAsync<Person>();
                return person;
            }

            return null;
        }

        public async Task<Vehicle> GetVehicleAsync(string url)
        {
            return await GetAsync<Vehicle>(url);
        }

        public async Task<T> GetAsync<T>(string url)
        {
            HttpResponseMessage response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<T>();
            }

            return default;
        }

        public async Task<SearchResult<Person>> GetPersonSearchAsync(string query)
        {
            HttpResponseMessage response = await _client.GetAsync("http://swapi.dev/api/people?search=" + query);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<Person>>();
            }
            return null;
        }

        // Challenge: Write a generic search method
        public async Task<SearchResult<T>> GetSearchAsync<T>(string query)
        {
            string category;
            if (typeof(T) == typeof(Vehicle))
            {
                category = "vehicles";
            } else if (typeof(T) == typeof(Planet))
            {
                category = "planets";
            } else
            {
                category = "people";
            }

            HttpResponseMessage response = await _client.GetAsync("http://swapi.dev/api/" + category + "?search=" + query);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<SearchResult<T>>();
            }
            return default;
        }

    }
}
