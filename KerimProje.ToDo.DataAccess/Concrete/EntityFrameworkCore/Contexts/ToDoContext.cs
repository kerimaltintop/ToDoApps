using KerimProje.ToDo.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts
{
    public class ToDoContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-I8QOE0S\\SQLEXPRESS;database=ToDo;integrated security=true");
        }

        public DbSet<Work> Works { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
