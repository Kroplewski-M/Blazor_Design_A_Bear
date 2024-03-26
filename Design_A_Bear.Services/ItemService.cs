using Design_A_Bear.Models;
using Microsoft.EntityFrameworkCore;
using Design_A_Bear.DataAccess;

namespace Design_A_Bear.Services
{
    public class ItemService(ApplicationDbContext db) : IItemService
    {
        private readonly ApplicationDbContext _db = db;

        public async Task<Item> AddItem(Item item)
        {
            if (item == null)
            {
                throw new Exception("Item not added");
            }
            await _db.Items.AddAsync(item);
            await _db.SaveChangesAsync();
            return item;
        }

        public async Task<bool> DeleteItem(int id)
        {
            var item = await _db.Items.FirstOrDefaultAsync(x => x.Id == id);
            if (item == null)
            {
                return false;
            }
            _db.Items.Remove(item);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<List<Item>> GetAllItems()
        {
            List<Item> items = await _db.Items.ToListAsync();
            return items;
        }

        public async Task<List<Item>> GetItemsByCategory(string category)
        {
            List<Item>items = await _db.Items.Where(item => item.Category == category).ToListAsync();
            return items;
        }

        public async Task<Item> GetItemById(int id)
        {
            if(id == 0)
            {
                throw new Exception("Item not found");
            }
            var item = await _db.Items.FirstOrDefaultAsync(x => x.Id == id);
            if (item == null)
            {
                throw new Exception("Item not found");
            }
            return item;
        }

        public Task<Item> UpdateItem(Item item)
        {
            if(item == null)
            {
                throw new Exception("Item not found");
            }
            _db.Items.Update(item);
            _db.SaveChanges();
            return Task.FromResult(item);
        }

        public async Task<List<Item>> FetchSpecificAmount(int amount, string Category)
        {
            var items = await _db.Items.Where(x => x.Category == Category).Take(amount).ToListAsync();
            return items;
        }
    }
}
