using KerimProje.ToDo.Entities.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace KerimProje.ToDo.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, ITable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Picture { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
