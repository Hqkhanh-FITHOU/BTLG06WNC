using System;
using System.Collections.Generic;

namespace BTLG06WNC;

public partial class Account
{
    public int IAccountId { get; set; }

    public string? SName { get; set; }

    public string? SEmail { get; set; }

    public string? SPassword { get; set; }

    public string? SPhone { get; set; }

    public string? SAvatar { get; set; }

    public DateTime? DBirthofdate { get; set; }

    public int? IRoleId { get; set; }

    public virtual ICollection<Feedback> Feedbacks { get; set; } = new List<Feedback>();

    public virtual Role? IRole { get; set; }
}
