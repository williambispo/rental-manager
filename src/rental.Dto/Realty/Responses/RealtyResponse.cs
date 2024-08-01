using rental.Dto.Address.Responses;
using rental.Dto.Base;

namespace rental.Dto.Realty.Responses;

public class RealtyResponse : BaseResponse
{
    public Guid Id { get; set; }
    public decimal Price { get; set; }
    public short NumberRooms { get; set; }
    public short NumberSuites { get; set; }
    public bool Condominium { get; set; }
    public bool GarageSpace { get; set; }
    public bool Status { get; set; }
    public DateTime UpdateDate { get; set; }

    public AddressResponse AddressResponse { get; set; } = new AddressResponse();
}
