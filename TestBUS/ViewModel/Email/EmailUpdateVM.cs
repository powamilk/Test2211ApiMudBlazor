using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.ViewModel.Email
{
    public class EmailUpdateVM
    {
        public int EmailId { get; set; }
        public int UserId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public int Priority { get; set; }
        public int AttachmentCount { get; set; }
        public string Status { get; set; }
    }
}
