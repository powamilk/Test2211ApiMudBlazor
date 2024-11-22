using System;
using System.Collections.Generic;

namespace TestDAL.Entities;

public partial class EmailHistory
{
    public int HistoryId { get; set; }

    public int? EmailId { get; set; }

    public string Recipient { get; set; } = null!;

    public DateTime? SentAt { get; set; }

    public string? Status { get; set; }

    public string? ErrorMessage { get; set; }

    public int? RetryCount { get; set; }

    public virtual Email? Email { get; set; }
}
