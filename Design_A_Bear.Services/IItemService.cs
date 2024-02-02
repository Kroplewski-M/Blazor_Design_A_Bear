using Design_A_Bear.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_A_Bear.Services
{
    public interface IItemServices
    {
        Task<List<Item>> GetAllItems();
        Task<Item> GetItemById(int id);
        Task<Item> AddItem(Item item);
        Task<Item> UpdateItem(Item item);
        Task<bool> DeleteItem(int id);
    }
}
