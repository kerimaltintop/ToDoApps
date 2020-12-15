using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using KerimProje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;

namespace KerimProje.ToDo.Business.Concrete
{
    public class WorkManager : IWorkService
    {
        private readonly EfWorkRepository efWorkRepository;

        public WorkManager()
        {
            efWorkRepository = new EfWorkRepository();
        }
        public void Delete(Work table)
        {
            efWorkRepository.Delete(table);
        }

        public List<Work> GetAll()
        {
            return efWorkRepository.GetAll();
        }

        public Work GetById(int id)
        {
            return efWorkRepository.GetById(id);
        }

        public void Save(Work table)
        {
            efWorkRepository.Save(table);
        }

        public void Update(Work table)
        {
            efWorkRepository.Update(table);
        }
    }
}
