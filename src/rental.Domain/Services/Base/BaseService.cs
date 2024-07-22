using AutoMapper;
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
    private readonly IMapper _mapper;

    public BaseService(IBaseRepository<TEntity> rep, IMapper mapper)
    {
        _rep = rep;
        _mapper = mapper;
    }

    public async Task<List<TEntityResponse>> ListAsync()
    {
        var entity = await _rep.ListAsync();

        var response = _mapper.Map<List<TEntityResponse>>(entity);

        return response;
    }

    public async Task<TEntityResponse> GetById(int id)
    {
        var response = await _rep.GetById(id);

        var responseReturn = _mapper.Map<TEntityResponse>(response);

        return responseReturn;
    }

    public async Task<TEntity> InsertAsync(TEntityInsertRequest request)
    {
        var entityInsert = _mapper.Map<TEntity>(request);

        await _rep.Add(entityInsert);

        return entityInsert;
    }

    public async Task<bool> UpdateAsync(TEntityUpdateRequest entity)
    {
        var entityUpdate = _mapper.Map<TEntity>(entity);

        await _rep.Update(entityUpdate);

        return true;
    }

    public async Task<bool> Remove(int id)
    {
        await _rep.Remove(id);

        return true;
    }
}