using Microsoft.EntityFrameworkCore;
using Promocodes.Models;

namespace Promocodes.Repository
{
    //Database context class: Defines how EF Core interacts with the Db
   public class PromotionCodeDbContext : DbContext
    {
        public PromotionCodeDbContext(DbContextOptions<PromotionCodeDbContext> options) : base(options) {}
        public DbSet<PromotionCode> PromotionCodes { get; set; }
    }
}