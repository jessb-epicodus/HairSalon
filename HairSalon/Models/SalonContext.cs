using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models {
  public class HairSalonContext : DbContext {
    public DbSet<ClassName> Stylists { get; set; }
    public DbSet<ClassName> Clients { get; set; }
    public HairSalonContext(DbContextOptions options) : base(options) { }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}