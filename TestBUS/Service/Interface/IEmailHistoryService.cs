using BUS.ViewModel.EmailHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBUS.Service.Interface
{
    public interface IEmailHistoryService
    {
        Task<IEnumerable<EmailHistoryVM>> GetAllAsync();
        Task<EmailHistoryVM> GetByIdAsync(int historyId);
        Task<IEnumerable<EmailHistoryVM>> GetByEmailIdAsync(int emailId);
        Task AddAsync(EmailHistoryCreateVM emailHistoryCreateVM);
        Task UpdateAsync(EmailHistoryUpdateVM emailHistoryUpdateVM);
        Task DeleteAsync(int historyId);
    }
}
