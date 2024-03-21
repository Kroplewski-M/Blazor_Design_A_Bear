﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_A_Bear.DataAccess;
using Design_A_Bear.Models;
using Microsoft.EntityFrameworkCore;

namespace Design_A_Bear.Services
{
    public class BasketService(ApplicationDbContext db) : IBasketService
    {
        private readonly ApplicationDbContext _db = db;
        public async Task<BasketItem> AddToBasket(BasketItem item)
        {

            await _db.BasketItems.AddAsync(item);
            await _db.SaveChangesAsync();
            return item;
        }

        public async Task<bool> RemoveFromBasket(int itemId, string userId)
        {
            BasketItem item = await _db.BasketItems.FirstOrDefaultAsync(b => b.ItemId == itemId && b.UserId == userId);
            if (item == null)
            {
                return false;
            }
            _db.BasketItems.Remove(item);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<List<BasketItem>> GetAllBasketItems(string userId)
        {
            var items = await _db.BasketItems.Where(b => b.UserId == userId)
                .Include(b => b.Item).ToListAsync();
            return items;
        }

        public async Task<bool> UpdateQuantity(int itemId, string userId, int quantity)
        {
            BasketItem item = await _db.BasketItems.FirstOrDefaultAsync(b => b.ItemId == itemId && b.UserId == userId);
            if (item == null)
            {
                return false;
            }
            item.Quantity = quantity;
            await _db.SaveChangesAsync();
            return true;
        }
    }
}
