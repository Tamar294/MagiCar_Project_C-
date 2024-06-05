using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class CarsRental
{
    public int Id { get; set; }

    public int CarCode { get; set; }

    public int UserCode { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public bool Returned { get; set; }

    public virtual Car CarCodeNavigation { get; set; }

    public virtual User UserCodeNavigation { get; set; }
}
