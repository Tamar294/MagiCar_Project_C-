using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class CreditDetail
{
    public int Id { get; set; }

    public string Number { get; set; }

    public string Validity { get; set; }

    public string Cvv { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
