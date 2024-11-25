using BUS.ViewModel.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDAL.Entities;

namespace TestBUS.Service.Interface
{
    public interface IEmailService
    {
        Task<IEnumerable<EmailVM>> GetAllAsync();
        Task<EmailVM> GetByIdAsync(int emailId);
        Task<IEnumerable<EmailVM>> GetByUserIdAsync(int userId);
        Task AddAsync(EmailCreateVM emailCreateVM);
        Task UpdateAsync(EmailUpdateVM emailUpdateVM);
        Task DeleteAsync(int emailId);
    }
}
