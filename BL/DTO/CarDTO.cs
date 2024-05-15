using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.DTO
{
    public class CarDTO
    {
        public CarDTO(int CarId, string Company, int AddressId, int TypeCode, int LockCode, string Image, Address Address, TypeCar TypeCodeNavigation)
        {
            this.CarId = CarId;
            this.Company = Company;
            this.AddressId = AddressId;
            this.TypeCode = TypeCode;
            this.LockCode = LockCode;
            this.Image = Image;
            this.Address = Address;
            this.TypeCodeNavigation = TypeCodeNavigation;
        }
        public int CarId { get; set; }

        public string Company { get; set; }

        public int AddressId { get; set; }

        public int TypeCode { get; set; }

        public int LockCode { get; set; }

        public string Image { get; set; }

        public virtual Address Address { get; set; }

        public virtual TypeCar TypeCodeNavigation { get; set; }
    }
}
