using AutoMapper;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public void AddUser(UserViewModel user)
        {
            var mapUser = _mapper.Map<User>(user);
            _userRepository.AddUser(mapUser);
        }

        public async Task<IEnumerable<UserViewModel>> GetUsers()
        {
            var result = await _userRepository.GetUsers();
            return _mapper.Map<IEnumerable<UserViewModel>>(result);
        }

        public async Task<UserViewModel> GetUserById(int? id)
        {
            var result = await _userRepository.GetUserById(id);
            return _mapper.Map<UserViewModel>(result);
        }

        public void RemoveUser(int? id)
        {
            var user = _userRepository.GetUserById(id).Result;
            _userRepository.RemoveUser(user);
        }

        public void UpdateUser(UserViewModel user)
        {
            var mapUser = _mapper.Map<User>(user);
            _userRepository.UpdateUser(mapUser);
        }
    }
}
