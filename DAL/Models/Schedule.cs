using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Schedule
{
    public int Id { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int CarId { get; set; }
}
