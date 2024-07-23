using Microsoft.EntityFrameworkCore;
using rental.Domain.Entities;
using rental.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental.Persistence.Repositories;

public class RealtyRepository : BaseRepository<Realty, DbContext>, IRealtyRepository
{
    public RealtyRepository(DbContext context) : base(context) { }
}
