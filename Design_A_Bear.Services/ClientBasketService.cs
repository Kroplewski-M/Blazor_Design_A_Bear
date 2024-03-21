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

        public Task<bool> RemoveFromBasket(int itemId, string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BasketItem>> GetAllBasketItems(string userId)
        {
            var result = await _httpClient.GetFromJsonAsync<List<BasketItem>>($"/api/Basket/{userId}");
            return result;
        }

        public Task<bool> UpdateQuantity(int itemId, string userId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
