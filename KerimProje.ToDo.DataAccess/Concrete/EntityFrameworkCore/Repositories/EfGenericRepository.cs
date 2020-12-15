using KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using KerimProje.ToDo.DataAccess.Interfaces;
using KerimProje.ToDo.Entities.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<Table> : IGenericDal<Table> where Table : class, ITable, new()
    {
        public void Delete(Table table)
        {
            using var context = new ToDoContext();
            context.Set<Table>().Remove(table);
            context.SaveChanges();
        }

        public List<Table> GetAll()
        {
            using var context = new ToDoContext();
            return context.Set<Table>().ToList();
        }

        public Table GetById(int id)
        {
            using var context = new ToDoContext();
            return context.Set<Table>().Find(id);
        }

        public void Save(Table table)
        {
            using var context = new ToDoContext();
            context.Set<Table>().Add(table);
            context.SaveChanges();
        }

        public void Update(Table table)
        {
            using var context = new ToDoContext();
            context.Entry(table).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
