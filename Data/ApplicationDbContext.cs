using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VetAB.Models;

namespace VetAB.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
{
  base.OnModelCreating(modelBuilder);
    modelBuilder.Entity<Animal>().Property<DateTime>("CreatedDate");
    modelBuilder.Entity<Customer>().Property<DateTime>("CreatedDate");
    modelBuilder.Entity<Visit>().Property<DateTime>("CreatedDate");
  
     modelBuilder.Entity<Animal>()
        .HasOne(ca => ca.Customer)
        .WithMany(ca => ca.Animals);

    modelBuilder.Entity<Visit>()
        .HasOne(ca => ca.Customer)
        .WithMany(ca => ca.Visits);

}
    public DbSet<Animal>? Animals { get; set; }
    public DbSet<Customer>? Customers { get; set; }
    public DbSet<Visit>? Visits { get; set; }
}
