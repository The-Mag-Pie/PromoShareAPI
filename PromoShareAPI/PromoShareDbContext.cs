using Microsoft.EntityFrameworkCore;
using PromoShareAPI.Models;

namespace PromoShareAPI
{
    public class PromoShareDbContext : DbContext
    {
        public PromoShareDbContext(DbContextOptions<PromoShareDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<PromotionModel> Promotions { get; set; }
        public DbSet<ImageModel> Images { get; set; }
    }
}
