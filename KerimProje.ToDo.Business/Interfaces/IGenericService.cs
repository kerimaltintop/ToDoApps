using KerimProje.ToDo.Entities.Interfaces;
using System.Collections.Generic;

namespace KerimProje.ToDo.Business.Interfaces
{
    public interface IGenericService<Table> where Table : class, ITable, new()
    {
        void Save(Table table);
        void Delete(Table table);
        void Update(Table table);
        Table GetById(int id);
        List<Table> GetAll();
    }
}
