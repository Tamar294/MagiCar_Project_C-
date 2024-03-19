using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class CarsToUser
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int CarId { get; set; }

    public virtual User User { get; set; }
}
