using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class RentalHistory
{
    public int Id { get; set; }

    public int CarCode { get; set; }

    public int UserCode { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public virtual Car CarCodeNavigation { get; set; }

    public virtual User UserCodeNavigation { get; set; }
}
