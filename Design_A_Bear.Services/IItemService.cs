using Design_A_Bear.Models;


namespace Design_A_Bear.Services
{
    public interface IItemService
    {
        Task<List<Item>> GetAllItems();
        Task<List<Item>> GetItemsByCategory(string category);
        Task<Item> GetItemById(int id);
        Task<Item> AddItem(Item item);
        Task<Item> UpdateItem(Item item);
        Task<bool> DeleteItem(int id);
        Task<List<Item>> FetchSpecificAmount(int amount,string Category);
    }
}
