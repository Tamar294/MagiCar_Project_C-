using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string Company { get; set; }

    public int AddressId { get; set; }

    public int TypeCode { get; set; }

    public int LockCode { get; set; }

    public string Image { get; set; }

    public virtual Address Address { get; set; }

    public virtual TypeCar TypeCodeNavigation { get; set; }
}
