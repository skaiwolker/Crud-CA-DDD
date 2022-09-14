using CleanArch.Application.ViewModels_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserViewModelDTO>> GetUsers();

        Task<UserViewModelDTO> GetUserById(int? id);

        void AddUser(UserViewModelDTO user);

        void UpdateUser(UserViewModelDTO user);

        void RemoveUser(int? id);
    }
}
