using AutoMapper;
using BUS.ViewModel.Email;
using BUS.ViewModel.EmailHistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBUS.ViewModel;
using TestDAL.Entities;

namespace TestBUS.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserVM>().ReverseMap();
            CreateMap<User, UserCreateVM>().ReverseMap();
            CreateMap<User, UserUpdateVM>().ReverseMap();

            CreateMap<Email, EmailVM>().ReverseMap();
            CreateMap<Email, EmailCreateVM>().ReverseMap();
            CreateMap<Email, EmailUpdateVM>().ReverseMap();

            CreateMap<EmailHistory, EmailHistoryVM>().ReverseMap();
            CreateMap<EmailHistory, EmailHistoryCreateVM>().ReverseMap();
            CreateMap<EmailHistory, EmailHistoryUpdateVM>().ReverseMap();
        }
    }
}
