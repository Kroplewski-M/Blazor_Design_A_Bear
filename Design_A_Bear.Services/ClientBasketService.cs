using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_A_Bear.Models;

namespace Design_A_Bear.Services
{
    public class ClientBasketService : IBasketService
    {
        public Task<BasketItem> AddToBasket(int itemId, string userId, int quantity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveFromBasket(int itemId, string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<BasketItem>> GetAllBasketItems(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateQuantity(int itemId, string userId, int quantity)
        {
            throw new NotImplementedException();
        }
    }
}
