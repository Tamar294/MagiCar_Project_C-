using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class Reservation
{
    public int ReservationId { get; set; }

    public int UserId { get; set; }

    public int CarId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string ReservationStatus { get; set; }

    public virtual Car Car { get; set; }

    public virtual User User { get; set; }
}
