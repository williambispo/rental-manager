﻿using rental.Dto.Address.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental.Dto.Realty.Requests;

public class RealtyUpdateRequest
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