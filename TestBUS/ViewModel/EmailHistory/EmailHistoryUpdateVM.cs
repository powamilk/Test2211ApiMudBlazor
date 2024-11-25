using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModel.EmailHistory
{
    public class EmailHistoryUpdateVM
    {
        public int HistoryId { get; set; }
        public int EmailId { get; set; }
        public string Recipient { get; set; }
        public DateTime SentAt { get; set; }
        public string Status { get; set; }
        public string ErrorMessage { get; set; }
        public int RetryCount { get; set; }
    }
}
