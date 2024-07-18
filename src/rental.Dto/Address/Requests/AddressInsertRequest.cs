using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental.Dto.Address.Requests;

public class AddressInsertRequest
{
    public string State { get; set; }
    public string CityId { get; set; }
    public string Description { get; set; }
    public string Complement { get; set; }
    public int Number { get; set; }
    public string Burgh { get; set; }
    public string Zipcode { get; set; }
}
