using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.DTO
{
    public class CreditDetailDTO
    {
        public CreditDetailDTO(int Id, string Number, string Validity, string Cvv, ICollection<User> Users) 
        {
            this.Id = Id;
            this.Number = Number;
            this.Validity = Validity;
            this.Cvv = Cvv;
            this.Users = Users;
        }
        public int Id { get; set; }

        public string Number { get; set; }

        public string Validity { get; set; }

        public string Cvv { get; set; }

        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
