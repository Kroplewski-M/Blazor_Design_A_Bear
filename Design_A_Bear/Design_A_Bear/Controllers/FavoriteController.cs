using Design_A_Bear.Models;
using Design_A_Bear.Services;
using Microsoft.AspNetCore.Mvc;



namespace Design_A_Bear.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteController(IFavoriteService favoriteService) : ControllerBase
    {
        private readonly IFavoriteService _favoriteService = favoriteService;

        [HttpGet("{UserId}")]
        public async Task<ActionResult> GetAllFavorites(string UserId)
        {
            var allFavorites = await _favoriteService.GetAllFavorites(UserId);
            return Ok(allFavorites);
        }

        [HttpGet("{UserId}/{ItemId}")]
        public async Task<ActionResult> IsInFavorites(string UserId, int ItemId)
        {
            var isFavorite = await _favoriteService.IsInFavorites(UserId, ItemId);
            return Ok(isFavorite);
        }

        [HttpPost]
        public async Task<ActionResult> AddToFavorites(FavoriteItems item)
        {
            var itemToAdd = new FavoriteItems
            {
                UserId = item.UserId,
                ItemId = item.ItemId
            };
            await _favoriteService.AddToFavorites(itemToAdd);
            return Ok(itemToAdd);
        }

        [HttpDelete("{UserId}/{ItemId}")]
        public async Task<ActionResult> RemoveFromFavorites(string UserId,int ItemId)
        {
            await _favoriteService.RemoveFromFavorites(UserId,ItemId);
            return Ok();
        }
    }
}
