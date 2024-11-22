using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBUS.ViewModel;

namespace TestBUS.Service.Interface
{
    public interface IUserService
    {
        Task<IEnumerable<UserVM>> GetAllAsync();
        Task<UserVM> GetByIdAsync(int id);  
        Task AddAsync(UserCreateVM vm);
        Task UpdateAsync(UserUpdateVM vm);
        Task DeleteAsync(int id);   
    }
}
