using Design_A_Bear.Models;
using Design_A_Bear.Services;
using Microsoft.AspNetCore.Mvc;

namespace Design_A_Bear.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController(IItemService itemServices) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetAllItems()
        {
            var allItems = await itemServices.GetAllItems();
            return Ok(allItems);
        }

        [HttpGet("Category/{category}")]
        public async Task<ActionResult> GetItemsByCategory([AsParameters]string category)
        {
            var items = await itemServices.GetItemsByCategory(category);
            return Ok(items);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetItemById(int id)
        {
            var item = await itemServices.GetItemById(id);
            return Ok(item);
        }
        [HttpPost]
        public async Task<ActionResult> AddItem(Item item)
        {
            await itemServices.AddItem(item);
            return Ok(item);
        }
        [HttpPut]
        public async Task<ActionResult>UpdateItem(Item item)
        {
            await itemServices.UpdateItem(item);
            return Ok(item);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteItem(int id)
        {
            var success = await itemServices.DeleteItem(id);
            if (!success)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
