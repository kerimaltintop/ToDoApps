using KerimProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace KerimProje.ToDo.DataAccess.Interfaces
{
    public interface IUserDal
    {
        void Save(User table);
        void Delete(User table);
        void Update(User table);
        User GetById(int id);
        List<User> GetAll();
    }
}
