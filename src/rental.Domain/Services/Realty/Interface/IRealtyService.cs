using rental.Domain.Services.Base.Interface;
using rental.Dto.Realty.Requests;
using rental.Dto.Realty.Responses;

namespace rental.Domain.Services.Realty.Interface;

public interface IRealtyService : IBaseService<Entities.Realty, RealtyResponse, RealtyInsertRequest, RealtyUpdateRequest>
{
}
