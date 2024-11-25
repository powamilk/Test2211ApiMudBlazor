using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModel.EmailHistory
{
    public class EmailHistoryCreateVM
    {
        public int EmailId { get; set; }
        public string Recipient { get; set; }
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public int RetryCount { get; set; } = 0;
    }
}
