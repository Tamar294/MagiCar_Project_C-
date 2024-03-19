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

    public int AddressId { get; set; }

    public int CreditCardId { get; set; }

    public virtual Address Address { get; set; }

    public virtual ICollection<CarsToUser> CarsToUsers { get; set; } = new List<CarsToUser>();

    public virtual CreditDetail CreditCard { get; set; }
}
