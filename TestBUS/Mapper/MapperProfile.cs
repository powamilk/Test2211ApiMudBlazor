using AutoMapper;
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
        }
    }
}
