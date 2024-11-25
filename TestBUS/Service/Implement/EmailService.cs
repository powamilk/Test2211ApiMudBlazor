using AutoMapper;
using BUS.ViewModel.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBUS.Service.Interface;
using TestDAL.Entities;
using TestDAL.Repositories.Interface;

namespace TestBUS.Service.Implement
{
    public class EmailService : IEmailService
    {
        private readonly IEmailRepo _emailRepo;
        private readonly IMapper _mapper;

        public EmailService(IEmailRepo emailRepo, IMapper mapper)
        {
            _emailRepo = emailRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EmailVM>> GetAllAsync()
        {
            var emails = await _emailRepo.GetAllAsync();
            return _mapper.Map<IEnumerable<EmailVM>>(emails);
        }

        public async Task<EmailVM> GetByIdAsync(int emailId)
        {
            var email = await _emailRepo.GetByIdAsync(emailId);
            if (email == null) throw new KeyNotFoundException("Email not found.");
            return _mapper.Map<EmailVM>(email);
        }

        public async Task<IEnumerable<EmailVM>> GetByUserIdAsync(int userId)
        {
            var emails = await _emailRepo.GetByUserIdAsync(userId);
            return _mapper.Map<IEnumerable<EmailVM>>(emails);
        }

        public async Task AddAsync(EmailCreateVM emailCreateVM)
        {
            var email = _mapper.Map<Email>(emailCreateVM);
            await _emailRepo.AddAsync(email);
        }

        public async Task UpdateAsync(EmailUpdateVM emailUpdateVM)
        {
            var email = await _emailRepo.GetByIdAsync(emailUpdateVM.EmailId);
            if (email == null) throw new KeyNotFoundException("Email not found.");
            _mapper.Map(emailUpdateVM, email);
            await _emailRepo.UpdateAsync(email);
        }

        public async Task DeleteAsync(int emailId)
        {
            var email = await _emailRepo.GetByIdAsync(emailId);
            if (email == null) throw new KeyNotFoundException("Email not found.");
            await _emailRepo.DeleteAsync(emailId);
        }
    }
}
