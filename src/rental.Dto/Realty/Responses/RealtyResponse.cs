﻿using rental.Dto.Address.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental.Dto.Realty.Responses;

public class RealtyResponse
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