using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Mapping
{
    public class ViewModelToDomainMappinpProfile : Profile
    {
        public ViewModelToDomainMappinpProfile()
        {
            CreateMap<UserViewModel, User>();   
        }
    }
}
