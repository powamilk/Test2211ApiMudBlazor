using AutoMapper;
using BUS.ViewModel.EmailHistory;
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
    public class EmailHistoryService : IEmailHistoryService
    {
        private readonly IEmailHistoryRepo _emailHistoryRepo;
        private readonly IMapper _mapper;

        public EmailHistoryService(IEmailHistoryRepo emailHistoryRepo, IMapper mapper)
        {
            _emailHistoryRepo = emailHistoryRepo;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EmailHistoryVM>> GetAllAsync()
        {
            var emailHistories = await _emailHistoryRepo.GetAllAsync();
            return _mapper.Map<IEnumerable<EmailHistoryVM>>(emailHistories);
        }

        public async Task<EmailHistoryVM> GetByIdAsync(int historyId)
        {
            var emailHistory = await _emailHistoryRepo.GetByIdAsync(historyId);
            if (emailHistory == null) throw new KeyNotFoundException("Email history not found.");
            return _mapper.Map<EmailHistoryVM>(emailHistory);
        }

        public async Task<IEnumerable<EmailHistoryVM>> GetByEmailIdAsync(int emailId)
        {
            var emailHistories = await _emailHistoryRepo.GetByEmailIdAsync(emailId);
            return _mapper.Map<IEnumerable<EmailHistoryVM>>(emailHistories);
        }

        public async Task AddAsync(EmailHistoryCreateVM emailHistoryCreateVM)
        {
            var emailHistory = _mapper.Map<EmailHistory>(emailHistoryCreateVM);
            await _emailHistoryRepo.AddAsync(emailHistory);
        }

        public async Task UpdateAsync(EmailHistoryUpdateVM emailHistoryUpdateVM)
        {
            var emailHistory = await _emailHistoryRepo.GetByIdAsync(emailHistoryUpdateVM.HistoryId);
            if (emailHistory == null) throw new KeyNotFoundException("Email history not found.");
            _mapper.Map(emailHistoryUpdateVM, emailHistory);
            await _emailHistoryRepo.UpdateAsync(emailHistory);
        }

        public async Task DeleteAsync(int historyId)
        {
            var emailHistory = await _emailHistoryRepo.GetByIdAsync(historyId);
            if (emailHistory == null) throw new KeyNotFoundException("Email history not found.");
            await _emailHistoryRepo.DeleteAsync(historyId);
        }
    }
}
