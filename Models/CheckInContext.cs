using Microsoft.EntityFrameworkCore;
using ExplosiveAPI.Models;

namespace ExplosiveAPI.Models
{
  public class CheckInContext : DbContext
  {

    public CheckInContext(DbContextOptions<CheckInContext> options)
            : base(options)
    {
    }

    public DbSet<CheckIn> CheckIn { get; set; }
  }
}
