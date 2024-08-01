using rental.Dto.Address.Requests;
using rental.Dto.Base;

namespace rental.Dto.Realty.Requests;

public class RealtyUpdateRequest : BaseRequest
{
    public Guid Id { get; set; }
    public decimal Price { get; set; }
    public short NumberRooms { get; set; }
    public short NumberSuites { get; set; }
    public bool Condominium { get; set; }
    public bool GarageSpace { get; set; }
    public bool Status { get; set; }

    public AddressUpdateRequest AddressUpdateRequest { get; set; } = new AddressUpdateRequest();
}
