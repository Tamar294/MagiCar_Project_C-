using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Address
{
    public int Id { get; set; }

    public string City { get; set; }

    public string Neighborhood { get; set; }

    public string Street { get; set; }

    public int BuildingNumber { get; set; }

    //    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

    //    public virtual ICollection<User> Users { get; set; } = new List<User>();
}