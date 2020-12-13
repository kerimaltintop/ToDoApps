using KerimProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace KerimProje.ToDo.DataAccess.Interfaces
{
    public interface IWorkDal
    {
        void Save(Work table);
        void Delete(Work table);
        void Update(Work table);
        Work GetById(int id);
        List<Work> GetAll();
    }
}
