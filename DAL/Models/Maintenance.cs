using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Maintenance
{
    public int MaintenanceId { get; set; }

    public int CarId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string MaintenanceType { get; set; }

    public virtual Car Car { get; set; }
}
