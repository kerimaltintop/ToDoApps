﻿using KerimProje.ToDo.Entities.Interfaces;
using System.Collections.Generic;

namespace KerimProje.ToDo.Entities.Concrete
{
    public class Urgency : ITable
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
