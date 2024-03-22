using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_A_Bear.Models;

namespace Design_A_Bear.Services
{
    public interface IBasketService
    {
        public Task<BasketItem> AddToBasket(BasketItem item);
        public Task<bool> RemoveFromBasket(int itemId, string userId);
        public Task<List<BasketItem>> GetAllBasketItems(string userId);
        public Task<bool> UpdateQuantity(int itemId, string userId, int quantity);

        public Task<BasketItem>IsInBasket(int itemId, string userId);
    }
}
