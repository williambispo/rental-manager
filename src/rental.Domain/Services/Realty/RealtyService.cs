using AutoMapper;
using rental.Domain.Interfaces.Repositories;
using rental.Domain.Services.Base;
using rental.Domain.Services.Realty.Interface;
using rental.Dto.Realty.Requests;
using rental.Dto.Realty.Responses;

namespace rental.Domain.Services.Realty;

public class RealtyService : BaseService<Entities.Realty, RealtyResponse, RealtyInsertRequest, RealtyUpdateRequest>, IRealtyService
{
    private readonly IRealtyRepository _realtyRepository;
    private readonly IMapper _mapper;

    public RealtyService(IRealtyRepository realtyRepository, IMapper mapper) : base(realtyRepository, mapper)
    {
        _realtyRepository = realtyRepository;
        _mapper = mapper;
    }
}