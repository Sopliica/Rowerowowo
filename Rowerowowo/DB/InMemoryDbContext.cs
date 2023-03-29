using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Rowerowowo.Models;
using System.Net;

namespace Rowerowowo.InMemoryDbContext;

public class InMemoryDBContext : DbContext
{
    public DbSet<VehicleType> VehicleType{ get; set; }
    public DbSet<HireingPoint> Vehicle { get; set; }
    public DbSet<HireingPoint> HireingPoint{ get; set; }
    public DbSet<Reservation> Reservation { get; set; }
    public InMemoryDBContext(DbContextOptions<InMemoryDBContext> options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VehicleType>().HasKey(x => x.Id);
        modelBuilder.Entity<HireingPoint>().HasKey(x => x.Id);
        modelBuilder.Entity<HireingPoint>().HasKey(x => x.Id);
        modelBuilder.Entity<Reservation>().HasKey(x => x.Id);
    }
}