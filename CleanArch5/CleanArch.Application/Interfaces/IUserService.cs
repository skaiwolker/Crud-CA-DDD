using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserViewModel>> GetUsers();

        Task<UserViewModel> GetUserById(int? id);

        void AddUser(UserViewModel user);

        void UpdateUser(UserViewModel user);

        void RemoveUser(int? id);
    }
}
