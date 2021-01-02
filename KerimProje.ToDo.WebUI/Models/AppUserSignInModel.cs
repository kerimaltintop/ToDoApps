using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KerimProje.ToDo.WebUI.Models
{
    public class AppUserSignInModel
    {
        [Required(ErrorMessage = "Username is required!")]
        [Display(Name = "Username :")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [Display(Name = "Password :")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
