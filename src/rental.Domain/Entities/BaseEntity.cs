using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rental.Domain.Entities;

public class BaseEntity
{
    public Guid Id { get; set; }
    public DateTime UpdateDate { get; set; }

    public BaseEntity()
    {
        Id = Guid.NewGuid();
        UpdateDate = DateTime.UtcNow;
    }
}
