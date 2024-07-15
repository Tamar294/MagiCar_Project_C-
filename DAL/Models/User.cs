using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class User
{
    public int UserId { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public int PhoneNumber { get; set; }

    public int AddressCode { get; set; }

    public int PaymentCode { get; set; }

<<<<<<< HEAD
    //public virtual Address AddressCodeNavigation { get; set; }
=======
    public virtual Address AddressCodeNavigation { get; set; }
>>>>>>> 1d980016969b156c50831662286ea78b5eabb394

    public virtual ICollection<CarsRental> CarsRentals { get; set; } = new List<CarsRental>();

    public virtual PayDetail PaymentCodeNavigation { get; set; }

    public virtual ICollection<RentalHistory> RentalHistories { get; set; } = new List<RentalHistory>();
}
