using System.ComponentModel.DataAnnotations;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Models
{
    public class UrgencyUpdateViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Definition :")]
        [Required(ErrorMessage = "Definition Blank Impenetrable!")]
        public string Definition { get; set; }
    }
}
