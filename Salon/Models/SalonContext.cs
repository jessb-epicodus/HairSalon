using Microsoft.EntityFrameworkCore;

namespace Salon.Models {
  public class SalonContext : DbContext {
    public DbSet<ClassName> Stylists { get; set; }
    public DbSet<ClassName> Clients { get; set; }
    public SalonContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}