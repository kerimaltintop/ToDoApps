using KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using KerimProje.ToDo.DataAccess.Interfaces;
using KerimProje.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfTaskRepository : EfGenericRepository<Task>, ITaskDal
    {
        public List<Task> GetAllTable()
        {
            using var context = new ToDoContext();
            return context.Tasks.Include(I => I.Urgency).Include
                (I => I.Reports).Include(I => I.AppUser).Where(I => I.Status == false).OrderByDescending(I => I.CreationDate).ToList();
        }

        public List<Task> GetWithUrgencyNotComplete()
        {
            using var context = new ToDoContext();
            return context.Tasks.Include(I => I.Urgency).Where(I => I.Status == false).OrderByDescending(I => I.CreationDate).ToList();
        }
    }
}
