namespace rental.Dto.Address.Requests;

public class AddressUpdateRequest
{
    public Guid Id { get; set; }
    public string State { get; set; }
    public string CityId { get; set; }
    public string Description { get; set; }
    public string Complement { get; set; }
    public int Number { get; set; }
    public string Burgh { get; set; }
    public string Zipcode { get; set; }
}
