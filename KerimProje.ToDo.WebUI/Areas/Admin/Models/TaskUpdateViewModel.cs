using System.ComponentModel.DataAnnotations;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Models
{
    public class TaskUpdateViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required!")]
        public string Name { get; set; }
        public string Explanation { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Urgency is required!")]
        public int UrgencyId { get; set; }
    }
}
