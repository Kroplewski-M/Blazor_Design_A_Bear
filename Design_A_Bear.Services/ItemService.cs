﻿using Design_A_Bear.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Design_A_Bear.DataAccess;

namespace Design_A_Bear.Services
{
    public class ItemService(ApplicationDbContext db) : IItemServices
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

        public async Task DeleteItem(int id)
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
            _db.Items.Remove(item);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Item>> GetAllItems()
        {
            List<Item> items = await _db.Items.ToListAsync();
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
    }
}
