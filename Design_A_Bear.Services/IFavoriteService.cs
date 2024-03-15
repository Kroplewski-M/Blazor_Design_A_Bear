

using Design_A_Bear.Models;

namespace Design_A_Bear.Services
{
    public interface IFavoriteService
    {
        public Task<bool> IsInFavorites(string UserId, int ItemId);
        public Task<FavoriteItems> AddToFavorites(FavoriteItems item);
        public Task<bool> RemoveFromFavorites(string UserId, int ItemId);
        public Task<List<FavoriteItems>> GetAllFavorites(string UserId);
    }
}
