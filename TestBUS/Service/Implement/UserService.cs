using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBUS.Service.Interface;
using TestBUS.ViewModel;
using TestDAL.Entities;
using TestDAL.Repositories.Interface;

namespace TestBUS.Service.Implement
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;

        public UserService(IUserRepo userRepo, IMapper mapper)
        {
            _userRepo = userRepo;
            _mapper = mapper;
        }
        public async Task AddAsync(UserCreateVM vm)
        {
            var user = _mapper.Map<User>(vm);
            await _userRepo.AddAsync(user);
        }

        public async Task DeleteAsync(int id)
        {
            var user = await _userRepo.GetByIdAsync(id);
            if (user == null) throw new KeyNotFoundException("Khong co user ton tai");

            await _userRepo.DeleteAsync(id);
        }

        public async Task<IEnumerable<UserVM>> GetAllAsync()
        {
            var user = await _userRepo.GetAllAsync();   
            return _mapper.Map<IEnumerable<UserVM>>(user);  
        }

        public async Task<UserVM> GetByIdAsync(int id)
        {
            var user = await _userRepo.GetByIdAsync(id);
            if(user == null) throw new KeyNotFoundException("Khong co user ton tai");
            return _mapper.Map<UserVM>(user);   
        }

        public async Task UpdateAsync(UserUpdateVM vm)
        {
            var user = await _userRepo.GetByIdAsync(vm.UserId);
            if (user == null) throw new KeyNotFoundException("Khong co user ton tai");
            _mapper.Map(vm, user);
            await _userRepo.UpdateAsync(user);
        }
    }
}
