using System;
using System.Collections.Generic;

namespace Dal.Models;

public partial class FeedBack
{
    public int FeedBackId { get; set; }

    public int UserId { get; set; }

    public string FeedBackContent { get; set; }

    public int? Rating { get; set; }

    public virtual User User { get; set; }
}
