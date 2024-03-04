using Microsoft.AspNetCore.Mvc;
using PromoShareAPI.Models;

namespace PromoShareAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddPromotionController : ControllerBase
    {
        private readonly PromoShareDbContext _context;

        public AddPromotionController(PromoShareDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> AddPromotion(PromotionModel promotion)
        {
            _context.Promotions.Add(promotion);
            await _context.SaveChangesAsync();

            return Created();
        }
    }
}
