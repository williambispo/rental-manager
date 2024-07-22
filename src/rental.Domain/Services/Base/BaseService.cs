using rental.Domain.Entities;
using rental.Domain.Interfaces.Repositories;
using rental.Domain.Services.Base.Interface;
using rental.Dto.Base;

namespace rental.Domain.Services.Base;

public class BaseService<TEntity, TEntityResponse, TEntityInsertRequest, TEntityUpdateRequest> : IBaseService<TEntity, TEntityResponse, TEntityInsertRequest, TEntityUpdateRequest>
where TEntity : BaseEntity
where TEntityResponse : BaseResponse
where TEntityInsertRequest : BaseRequest
where TEntityUpdateRequest : BaseRequest
{
    private readonly IBaseRepository<TEntity> _rep;

    public BaseService(IBaseRepository<TEntity> rep)
    {
        _rep = rep;
    }

    public async Task<List<TEntityResponse>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<TEntityResponse> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<TEntity> InsertAsync(TEntityInsertRequest request)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> UpdateAsync(TEntityUpdateRequest entity)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Remove(int id)
    {
        throw new NotImplementedException();
    }
}