using System;
using System.Collections.Generic;

namespace TestDAL.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string Email { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public bool? IsVerified { get; set; }

    public DateTime? LastLogin { get; set; }

    public string? Status { get; set; }

    public string? PhoneNumber { get; set; }

    public DateTime? EmailVerifiedAt { get; set; }

    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();
}
