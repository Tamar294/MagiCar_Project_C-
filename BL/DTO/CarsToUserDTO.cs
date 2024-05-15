using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.DTO
{
    public class CarsToUserDTO
    {
        public CarsToUserDTO(int Id, int UserId, int CarId, User User)
        {
            this.Id = Id;
            this.UserId = UserId;
            this.CarId = CarId;
            this.User = User;
        }
        public int Id { get; set; }

        public int UserId { get; set; }

        public int CarId { get; set; }

        public virtual User User { get; set; }
    }
}
