using Design_A_Bear.Models;
using Design_A_Bear.Services;
using Microsoft.AspNetCore.Mvc;

namespace Design_A_Bear.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController(IBasketService basketService) : ControllerBase
    {
        private readonly IBasketService _basketService = basketService;

        [HttpPost]
        public async Task<ActionResult> AddToBasket(BasketItem item)
        {
            BasketItem newItem = new BasketItem
            {
                UserId = item.UserId,
                ItemId = item.ItemId,
                Quantity = item.Quantity
            };
            await _basketService.AddToBasket(newItem);
            return Ok(newItem);
        }

        [HttpDelete("{UserId}/{ItemId}")]
        public async Task<ActionResult> RemoveFromBasket(string UserId, int ItemId)
        {
            await _basketService.RemoveFromBasket(ItemId, UserId);
            return Ok();
        }

        [HttpGet("{UserId}")]
        public async Task<ActionResult> GetAllBasketItems(string UserId)
        {
            List<BasketItem>items =  await _basketService.GetAllBasketItems(UserId);
            return Ok(items);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateQuantity(BasketItem item)
        {
            await _basketService.UpdateQuantity(item.ItemId, item.UserId, item.Quantity);
            return Ok();
        }

    }
}
