using Microsoft.EntityFrameworkCore;

namespace RestaurantTown.Models
{
  public class RestaurantTownContext : DbContext
  {
    public virtual DbSet<Restaurant> Restaurants { get; set; }
    public DbSet<Cuisine> Cuisines { get; set; }
    
    public RestaurantTownContext(DbContextOptions options) : base(options) { }
  }
}