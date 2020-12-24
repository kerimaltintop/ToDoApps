using KerimProje.ToDo.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace KerimProje.ToDo.Entities.Concrete
{
    public class Report : ITable
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public string Detail { get; set; }
        public int TaskId { get; set; }
        public Task Task { get; set; }
    }
}
