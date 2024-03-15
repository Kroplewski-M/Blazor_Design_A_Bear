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
            await _favoriteService.AddToFavorites(item);
            return Ok(item);
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult> RemoveFromFavorites(int Id)
        {
            await _favoriteService.RemoveFromFavorites(Id);
            return Ok();
        }
    }
}
