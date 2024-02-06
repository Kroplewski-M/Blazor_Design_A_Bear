using Design_A_Bear.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Design_A_Bear.Services
{
    public class ClientItemService : IItemService
    {
        private readonly HttpClient _httpClient;
        public ClientItemService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Item> AddItem(Item item)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/Item",item);
            //return await result.Content.ReadFromJsonAsync<Item>();
            if (result.IsSuccessStatusCode)
            {
                return await result.Content.ReadFromJsonAsync<Item>();
            }
            else
            {
                // Handle non-success status code, e.g., log the error or throw an exception
                // You may want to customize this based on your error-handling strategy
                throw new Exception($"Failed to add item. Status code: {result}");
            }
        }

        public async Task<bool> DeleteItem(int id)
        {
            var result = await _httpClient.DeleteAsync($"/api/Item/{id}");
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                throw new Exception($"Failed to add item. Status code: {result}");
            }
            
        }

        public async Task<List<Item>> GetAllItems()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Item>>($"/api/Item");
            return result;
        }

        public async Task<Item> GetItemById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Item>($"/api/Item/{id}");
            return result;
        }

        public async Task<Item> UpdateItem(Item item)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/Item",item);
            return await result.Content.ReadFromJsonAsync<Item>();
        }
    }
}
