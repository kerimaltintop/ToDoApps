using KerimProje.ToDo.Entities.Interfaces;
using System;

namespace KerimProje.ToDo.Entities.Concrete
{
    public class Work :ITable
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Explanation { get; set; }
        public DateTime CreationDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
