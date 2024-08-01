using Microsoft.EntityFrameworkCore;
using rental.Domain.Entities;
using rental.Domain.Interfaces.Repositories;

namespace rental.Persistence.Repositories;

public class RealtyRepository : BaseRepository<Realty, DbContext>, IRealtyRepository
{
    public RealtyRepository(DbContext context) : base(context) { }
}
