namespace rental.Domain.Entities;

public class Realty : BaseEntity
{
    public decimal Price { get; set; }
    public short NumberRooms { get; set; }
    public short NumberSuites { get; set; }
    public bool Condominium { get; set; }
    public bool GarageSpace { get; set; }
    public bool Status { get; set; }

    public Address Address { get; set; } = new Address();
}
