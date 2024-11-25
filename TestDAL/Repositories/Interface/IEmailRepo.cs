using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDAL.Entities;

namespace TestDAL.Repositories.Interface
{
    public interface IEmailRepo
    {
        Task AddAsync(Email email);
        Task UpdateAsync(Email email);
        Task DeleteAsync(int emailId);
        Task<Email> GetByIdAsync(int emailId);
        Task<IEnumerable<Email>> GetAllAsync();
        Task<IEnumerable<Email>> GetByUserIdAsync(int userId);
    }
}
