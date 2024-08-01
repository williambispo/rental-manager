using Microsoft.EntityFrameworkCore;

namespace rental.Persistence.Context;

public class RentalContext : DbContext
{
    public RentalContext(DbContextOptions<RentalContext> options) : base(options)
    {
        
    }
}
