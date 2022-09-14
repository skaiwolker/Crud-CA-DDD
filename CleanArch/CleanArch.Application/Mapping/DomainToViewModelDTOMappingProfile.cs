using AutoMapper;
using CleanArch.Application.ViewModels_DTO;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Mapping
{
    public class DomainToViewModelDTOMappingProfile: Profile
    {
        public DomainToViewModelDTOMappingProfile()
        {
            CreateMap<User, UserViewModelDTO>().ReverseMap();
        }
    }
}
