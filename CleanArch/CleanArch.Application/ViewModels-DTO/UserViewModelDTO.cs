using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.ViewModels_DTO
{
    public class UserViewModelDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First is Required")]
        [MinLength(3)]
        [MaxLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last is Required")]
        [MinLength(3)]
        [MaxLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [MinLength(10)]
        [MaxLength(100)]
        [DisplayName("Email")]
        public string Email { get; set; }
        
        public int AccountType { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [MinLength(8)]
        [MaxLength(30)]
        [DisplayName("Password")]
        public string Password { get; set; }
        
    }
}
