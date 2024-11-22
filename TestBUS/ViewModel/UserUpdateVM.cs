using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBUS.ViewModel
{
    public class UserUpdateVM
    {
        public int UserId { get; set; }

        public string Email { get; set; } = null!;

        public string Name { get; set; } = null!;

        public DateTime? CreatedAt { get; set; } = DateTime.Now;

        public string? Status { get; set; }

        public string? PhoneNumber { get; set; }
    }
}
