using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.DTO
{
    public class TypeCarDTO
    {
        public TypeCarDTO() { }
        public TypeCarDTO(int Id, string Name, int SeatsNumber, int HourlyPrice, int DailyPrice, int WeeklyPrice, double KilometerPrice, ICollection<Car> Cars)
        {
            this.Id = Id;
            this.Name = Name;
            this.SeatsNumber = SeatsNumber;
            this.HourlyPrice = HourlyPrice;
            this.DailyPrice = DailyPrice;
            this.WeeklyPrice = WeeklyPrice;
            this.KilometerPrice = KilometerPrice;
            this.Cars = Cars;
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int SeatsNumber { get; set; }

        public int HourlyPrice { get; set; }

        public int DailyPrice { get; set; }

        public int WeeklyPrice { get; set; }

        public double KilometerPrice { get; set; }

        public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
    }
}
