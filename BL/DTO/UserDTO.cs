using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.DTO
{
    public class UserDTO
    {
        public UserDTO(int UserId, string Name, string Email, string Password, int PhoneNumber, int AddressId, int CreditCardId, Address Address)
        {
            this.UserId = UserId;
            this.Name = Name;
            this.Email = Email;
            this.Password = Password;
            this.PhoneNumber = PhoneNumber;
            this.AddressId = AddressId;
            this.CreditCardId = CreditCardId;
            //this.CarsToUsers = CarsToUsers;
            //this.CreditCard = CreditCard;
        }
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int PhoneNumber { get; set; }

        public int AddressId { get; set; }

        public int CreditCardId { get; set; }

        public virtual Address Address { get; set; }

        //public virtual ICollection<CarsToUser> CarsToUsers { get; set; } = new List<CarsToUser>();

        //public virtual CreditDetail CreditCard { get; set; }
    }
}
