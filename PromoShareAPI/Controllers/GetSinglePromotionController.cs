using Microsoft.AspNetCore.Mvc;
using PromoShareAPI.Models;

namespace PromoShareAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GetSinglePromotionController : ControllerBase
    {
        private readonly PromoShareDbContext _context;

        public GetSinglePromotionController(PromoShareDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PromotionModel>> GetSinglePromotion(int id)
        {
            var promotion = await _context.Promotions.FindAsync(id);

            if (promotion == null)
            {
                return NotFound();
            }

            return promotion;
        }
    }
}
