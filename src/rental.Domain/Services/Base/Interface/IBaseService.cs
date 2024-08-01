using rental.Domain.Entities;
using rental.Dto.Base;

namespace rental.Domain.Services.Base.Interface;

public interface IBaseService<TEntity, TEntityResponse, TEntityInsertRequest, TEntityUpdateRequest>
 where TEntity : BaseEntity
 where TEntityResponse : BaseResponse
 where TEntityInsertRequest : BaseRequest
 where TEntityUpdateRequest : BaseRequest
{
    Task<List<TEntityResponse>> ListAsync();
    Task<TEntityResponse> GetById(int id);
    Task<TEntity> InsertAsync(TEntityInsertRequest entityInsert);
    Task<bool> Remove(int id);
    Task<bool> UpdateAsync(TEntityUpdateRequest entity);
}
