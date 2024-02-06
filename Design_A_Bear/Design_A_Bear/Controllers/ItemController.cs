using Design_A_Bear.Models;
using Design_A_Bear.Services;
using Microsoft.AspNetCore.Mvc;

namespace Design_A_Bear.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemServices;

        public ItemController(IItemService itemServices)
        {
            _itemServices = itemServices;
        }
        [HttpGet]
        public async Task<ActionResult> GetAllItems()
        {
            var allItems = await _itemServices.GetAllItems();
            return Ok(allItems);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetItemById(int id)
        {
            var item = await _itemServices.GetItemById(id);
            return Ok(item);
        }
        [HttpPost]
        public async Task<ActionResult> AddItem(Item item)
        {
            await _itemServices.AddItem(item);
            return Ok(item);
        }
        [HttpPut]
        public async Task<ActionResult>UpdateItem(Item item)
        {
            await _itemServices.UpdateItem(item);
            return Ok(item);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteItem(int id)
        {
            var success = await _itemServices.DeleteItem(id);
            if (!success)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
