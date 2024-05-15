using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.DTO
{
    public class ScheduleDTO
    {
        public ScheduleDTO(int Id, DateTime StartDate, DateTime EndDate, int CarId)
        {
            this.Id = Id;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.CarId = CarId;
        }
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int CarId { get; set; }
    }
}
