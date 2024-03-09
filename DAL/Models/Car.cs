using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Car
{
    public int CarId { get; set; }

    public string BrandAndModel { get; set; }

    public int YearOfManufacture { get; set; }

    public string LicensePlateNumber { get; set; }

    public string CarStatus { get; set; }

    public virtual ICollection<Maintenance> Maintenances { get; set; } = new List<Maintenance>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
