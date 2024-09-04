using Microsoft.EntityFrameworkCore;
using rental.Domain.Entities;

namespace rental.Persistence.Context;

public class RentalDbContext : DbContext
{
    public RentalDbContext(DbContextOptions<RentalDbContext> options) : base(options)
    {
        
    }

    public virtual DbSet<Realty> Realties { get; set; }
    public virtual DbSet<Address> Addresses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
          => optionsBuilder.UseNpgsql("Server=localhost;Database=rentalDB;User Id=postgres;Password=8687131821;");
}
