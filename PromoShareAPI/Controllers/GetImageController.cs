using Microsoft.AspNetCore.Mvc;

namespace PromoShareAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Produces("image/png")]
    public class GetImageController : ControllerBase
    {
        private readonly PromoShareDbContext _context;

        public GetImageController(PromoShareDbContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetImage(int id)
        {
            var image = await _context.Images.FindAsync(id);

            if (image == null)
            {
                return NotFound();
            }

            return File(Convert.FromBase64String(image.Image_B64), "image/png");
        }
    }
}
