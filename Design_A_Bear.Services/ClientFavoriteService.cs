

using Design_A_Bear.Models;
using System.Net.Http.Json;

namespace Design_A_Bear.Services
{
    public class ClientFavoriteService(HttpClient httpClient) : IFavoriteService
    {
        private readonly HttpClient _httpClient = httpClient;

        public async Task<bool> IsInFavorites(string UserId, int ItemId)
        {
            var result = await _httpClient.GetFromJsonAsync<bool>($"/api/Favorite/{UserId}/{ItemId}");
            return result;
        }

        public async Task<FavoriteItems> AddToFavorites(FavoriteItems item)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/Favorite", item);
            if (result.IsSuccessStatusCode)
            {
                return await result.Content.ReadFromJsonAsync<FavoriteItems>();
            }
            throw new Exception($"Failed to add item. Status code: {result}");
        }

        public async Task<bool> RemoveFromFavorites(string UserId,int ItemId)
        {
            var result = await _httpClient.DeleteAsync($"/api/Favorite/{UserId}/{ItemId}");
            if (result.IsSuccessStatusCode)
            {
                return true;
            }
            throw new Exception($"Failed to remove item. Status code: {result}");
        }

        public async Task<List<FavoriteItems>> GetAllFavorites(string UserId)
        {
            var result = await _httpClient.GetFromJsonAsync<List<FavoriteItems>>($"/api/Favorite/{UserId}");
            return result;
        }
    }
}
