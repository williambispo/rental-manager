using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental.Domain.Entities;

public class Realty : BaseEntity
{
    public decimal Price { get; set; }
    public short NumberRooms { get; set; }
    public short NumberSuites { get; set; }
    public bool Condominium { get; set; }
    public bool GarageSpace { get; set; }
    public bool Status { get; set; }

    public Adress Adress { get; set; } = new Adress();
}
