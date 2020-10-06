using Microsoft.EntityFrameworkCore;

namespace GameInventory.Models
{
  public class GameInventoryContext : DbContext
  {
    public DbSet<Game> Games { get; set; }

    public GameInventoryContext(DbContextOptions options) : base(options) { }
  }
}