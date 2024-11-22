using System;
using System.Collections.Generic;

namespace TestDAL.Entities;

public partial class Email
{
    public int EmailId { get; set; }

    public int? UserId { get; set; }

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public string? Status { get; set; }

    public int? Priority { get; set; }

    public int? AttachmentCount { get; set; }

    public virtual ICollection<EmailHistory> EmailHistories { get; set; } = new List<EmailHistory>();

    public virtual User? User { get; set; }
}
