using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Design_A_Bear.Models;

namespace Design_A_Bear.Services
{
    public class ClientBasketService(HttpClient httpClient) : IBasketService
    {
        private readonly HttpClient _httpClient = httpClient;
        public async Task<BasketItem> AddToBasket(BasketItem item)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/Basket", item);
            if (result.IsSuccessStatusCode)
            {
                return await result.Content.ReadFromJsonAsync<BasketItem>();
            }
            else
            {
                throw new Exception($"Failed to add item. Status code: {result}");
            }
        }

        public async Task<bool> RemoveFromBasket(int itemId, string userId)
        {
            var result = await _httpClient.DeleteAsync($"/api/Basket/{itemId}/{userId}");
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            throw new Exception($"Failed to remove item. Status code: {result}");
        }

        public async Task<List<BasketItem>> GetAllBasketItems(string userId)
        {
            var result = await _httpClient.GetFromJsonAsync<List<BasketItem>>($"/api/Basket/{userId}");
            return result;
        }

        public async Task<BasketItem> UpdateBasketItem(BasketItem item)
        {
            var result = await _httpClient.PutAsJsonAsync("/api/Basket", item);
            return await result.Content.ReadFromJsonAsync<BasketItem>();
        }

        public async Task<BasketItem> IsInBasket(int itemId, string userId)
        {
            var result = await _httpClient.GetFromJsonAsync<BasketItem>($"/api/Basket/{itemId}/{userId}");
            return result;
        }
    }
}
