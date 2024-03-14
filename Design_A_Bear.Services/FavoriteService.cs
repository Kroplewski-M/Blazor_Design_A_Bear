using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_A_Bear.DataAccess;
using Design_A_Bear.Models;


namespace Design_A_Bear.Services
{
    public class FavoriteService(ApplicationDbContext db) : IFavoriteService
    {
        private readonly ApplicationDbContext _db = db;
        public async Task<bool> IsInFavorites(string UserId, int ItemId)
        {
            FavoriteItems favorite = await _db.FavoriteItems.FindAsync(UserId, ItemId);
            if (favorite == null)
            {
                return false;
            }
            return true;
        }

        public async Task<FavoriteItems> AddToFavorites(FavoriteItems item)
        {
            if (item == null)
            {
                throw new Exception("Item not added to favorites");
            }
            await _db.FavoriteItems.AddAsync(item);
            await _db.SaveChangesAsync();
            return item;
        }

        public async Task<FavoriteItems> RemoveFromFavorites(int id)
        {
            var item = await _db.FavoriteItems.FindAsync(id);
            if (item == null)
            {
                throw new Exception("Item not found in favorites");
            }
            _db.FavoriteItems.Remove(item);
            await _db.SaveChangesAsync();
            return item;
        }
    }
}
