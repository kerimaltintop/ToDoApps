using System.ComponentModel.DataAnnotations;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Models
{
    public class TaskAddViewModel
    {

        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }
        public string Explanation { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Urgency is required!")]
        public int UrgencyId { get; set; }
    }
}
