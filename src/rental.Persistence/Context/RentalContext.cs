using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental.Persistence.Context;

public class RentalContext : DbContext
{
    public RentalContext(DbContextOptions<RentalContext> options) : base(options)
    {
        
    }
}
