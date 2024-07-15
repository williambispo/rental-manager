namespace rental.Domain.Interfaces.Repositories;

public interface IBaseRepository<Entity>
{
    Task<List<Entity>> ListAsync();
    Task<Entity?> GetById(int id);
    Task<Entity> Add(Entity entity);
    Task Remove(int entity);
    Task Update(Entity entity);
}