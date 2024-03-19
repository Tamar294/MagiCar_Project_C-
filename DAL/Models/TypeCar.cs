using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class TypeCar
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int SeatsNumber { get; set; }

    public int HourlyPrice { get; set; }

    public int DailyPrice { get; set; }

    public int WeeklyPrice { get; set; }

    public double KilometerPrice { get; set; }

    public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
}
