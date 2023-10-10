using MedicineProject.PlaceService.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MedicineProject.PlaceService.Domain.Context
{
    public sealed class WebMobileContext : DbContext
    {
        public DbSet<City> City { get; set; }

        public DbSet<Region> Region { get; set; }

        public DbSet<County> County { get; set; }

        public WebMobileContext(DbContextOptions<WebMobileContext> options) 
            : base(options) 
        {
        }
    }
}
