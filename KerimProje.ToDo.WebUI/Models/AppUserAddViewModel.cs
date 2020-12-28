using System.ComponentModel.DataAnnotations;

namespace KerimProje.ToDo.WebUI.Models
{
    public class AppUserAddViewModel
    {
        [Required(ErrorMessage = "Username is required!")]
        [Display(Name = "Username :")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [Display(Name = "Password :")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match!")]
        [Display(Name = "Confirm Password :")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Passwords do not match!")]
        [Display(Name = "Confirm Password :")]
        [EmailAddress(ErrorMessage = "Invalid Mail!")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Email is required!")]
        [Display(Name = "Name :")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Surname is required!")]
        [Display(Name = "Surname :")]
        public string Surname { get; set; }
    }
}
