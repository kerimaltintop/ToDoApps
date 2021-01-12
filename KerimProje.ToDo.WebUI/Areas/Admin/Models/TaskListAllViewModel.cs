using KerimProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KerimProje.ToDo.WebUI.Areas.Admin.Models
{
    public class TaskListAllViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public DateTime CreationDate { get; set; }
        public AppUser AppUser { get; set; }
        public Urgency Urgency { get; set; }
        public List<Report> Reports { get; set; }
    }
}
