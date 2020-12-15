using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using KerimProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace KerimProje.ToDo.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly EfUserRepository efUserRepository;
        public UserManager()
        {
            efUserRepository = new EfUserRepository();
        }
        public void Delete(User table)
        {
            efUserRepository.Delete(table);
        }

        public List<User> GetAll()
        {
            return efUserRepository.GetAll();
        }

        public User GetById(int id)
        {
            return efUserRepository.GetById(id);
        }

        public void Save(User table)
        {
            efUserRepository.Save(table);
        }

        public void Update(User table)
        {
            efUserRepository.Update(table);
        }
    }
}
