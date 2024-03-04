using Microsoft.AspNetCore.Mvc;
using PromoShareAPI.Models;

namespace PromoShareAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AddImageController : ControllerBase
    {
        private readonly PromoShareDbContext _context;

        public AddImageController(PromoShareDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> AddImage(ImageModel image)
        {
            _context.Images.Add(image);
            await _context.SaveChangesAsync();

            return Created();
        }
    }
}
