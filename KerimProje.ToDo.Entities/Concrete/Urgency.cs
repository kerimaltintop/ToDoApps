using System;
using System.Collections.Generic;
using System.Text;

namespace KerimProje.ToDo.Entities.Concrete
{
    public class Urgency
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
