using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using KerimProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace KerimProje.ToDo.Business.Concrete
{
    public class TaskManager : ITaskService
    {
        private readonly EfTaskRepository efWorkRepository;
        public TaskManager()
        {
            efWorkRepository = new EfTaskRepository();
        }
        public void Delete(Task table)
        {
            efWorkRepository.Delete(table);
        }
        public List<Task> GetAll()
        {
            return efWorkRepository.GetAll();
        }
        public Task GetById(int id)
        {
            return efWorkRepository.GetById(id);
        }
        public void Save(Task table)
        {
            efWorkRepository.Save(table);
        }
        public void Update(Task table)
        {
            efWorkRepository.Update(table);
        }
    }
}
