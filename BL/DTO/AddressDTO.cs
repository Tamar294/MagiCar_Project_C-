using Dal.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bl.DTO
{
    public class AddressDTO
    {
        public AddressDTO(Address address)
        {
        }

        public AddressDTO(int Id, string City, string Neighborhood, string Street, int BuildingNumber , ICollection<Car> Cars, ICollection<User> Users)
        {
            this.Id = Id;   
            this.City = City;
            this.Neighborhood = Neighborhood;
            this.Street = Street;
            this.BuildingNumber = BuildingNumber;
            this.Cars = Cars;
            this.Users = Users;
        }
        public int Id { get; set; }

        public string City { get; set; }

        public string Neighborhood { get; set; }

        public string Street { get; set; }

        public int BuildingNumber { get; set; }

        //public virtual ICollection<Car> Cars { get; set; } = new List<Car>();

        //public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
