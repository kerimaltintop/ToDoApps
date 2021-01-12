using KerimProje.ToDo.Entities.Concrete;
using KerimProje.ToDo.Entities.Interfaces;
using System.Collections.Generic;

namespace KerimProje.ToDo.DataAccess.Interfaces
{
    public interface IGenericDal<Table> 
    {
        void Save(Table table);
        void Delete(Table table);
        void Update(Table table);
        Table GetById(int id);
        List<Table> GetAll();
    }
}
