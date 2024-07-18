using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental.Domain.Entities;

public class Address : BaseEntity
{
    public string StateId { get; set; }
    public string CityId { get; set; }
    public string Description { get; set; }
    public string Complement { get; set; }
    public int Number { get; set; }
    public string Burgh { get; set; }
    public string Zipcode { get; set; }
}
