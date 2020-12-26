using KerimProje.ToDo.Entities.Concrete;
using System;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Models
{
    public class TaskListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public bool Status { get; set; }
        public DateTime CreationDate { get; set; }

        public int UrgencyId { get; set; }
        public Urgency Urgency { get; set; }
    }
}
