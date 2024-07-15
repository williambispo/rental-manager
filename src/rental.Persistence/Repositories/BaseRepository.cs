using rental.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace rental.Persistence.Repositories;

public abstract class BaseRepository<T, TContext> : IBaseRepository<T> where T : class where TContext : DbContext
{
    private readonly TContext context;

    public BaseRepository(TContext context)
    {
        this.context = context;
    }

    public async Task<List<T>> ListAsync()
    {
        return await context.Set<T>().AsNoTracking().ToListAsync();
    }

    public async Task<T?> GetById(int id)
    {
        return await context.Set<T>().FindAsync(id);
    }

    public async Task<T> Add(T entity)
    {
        await context.Set<T>().AddAsync(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public Task Update(T entity)
    {
        context.Entry(entity).State = EntityState.Modified;
        return context.SaveChangesAsync();
    }

    public Task Remove(int id)
    {
        var entity = context.Set<T>().Find(id);
        if (entity != null) context.Set<T>().Remove(entity);
        return context.SaveChangesAsync();
    }
}
