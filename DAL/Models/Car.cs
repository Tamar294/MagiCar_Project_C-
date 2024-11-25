﻿using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string Company { get; set; }

    public int AddressCode { get; set; }

    public int TypeCode { get; set; }

    public int LockCode { get; set; }

    public string ImageAvailable { get; set; }

    public string ImagePartiallyAvailable { get; set; }

    public string ImageNotAvailable { get; set; }

    //public virtual Address AddressCodeNavigation { get; set; }


    public virtual ICollection<CarsRental> CarsRentals { get; set; } = new List<CarsRental>();

    public virtual ICollection<RentalHistory> RentalHistories { get; set; } = new List<RentalHistory>();

    public virtual TypeCar TypeCodeNavigation { get; set; }
}
