using Microsoft.EntityFrameworkCore;
using Promocodes.Models;

namespace Promocodes.Repository
{
   public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> opt) : base(opt)
        {
            
        }

        public DbSet<Service> services { get; set; }
    }
}