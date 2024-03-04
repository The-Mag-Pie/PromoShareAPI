using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PromoShareAPI.Models;

namespace PromoShareAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GetAllPromotionsController : ControllerBase
    {
        private readonly PromoShareDbContext _context;

        public GetAllPromotionsController(PromoShareDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PromotionModel>>> GetAllPromotions()
        {
            return await _context.Promotions.ToListAsync();
        }
    }
}
