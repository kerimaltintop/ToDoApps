using System.ComponentModel.DataAnnotations;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Models
{
    public class UrgencyAddViewModel
    {
        [Display(Name = "Definition")]
        [Required(ErrorMessage = "Definition Blank Impenetrable!")]
        public string Definition { get; set; }
    }
}
