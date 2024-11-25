using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDAL.Entities;

namespace TestDAL.Repositories.Interface
{
    public interface IEmailHistoryRepo
    {
        Task AddAsync(EmailHistory emailHistory);
        Task UpdateAsync(EmailHistory emailHistory);
        Task DeleteAsync(int historyId);
        Task<EmailHistory> GetByIdAsync(int historyId);
        Task<IEnumerable<EmailHistory>> GetAllAsync();
        Task<IEnumerable<EmailHistory>> GetByEmailIdAsync(int emailId);
    }
}
