using rental.Domain.Services.Base.Interface;
using rental.Dto.Realty.Requests;
using rental.Dto.Realty.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental.Domain.Services.Realty.Interface;

public interface IRealtyService : IBaseService<Entities.Realty, RealtyResponse, RealtyInsertRequest, RealtyUpdateRequest>
{
}
