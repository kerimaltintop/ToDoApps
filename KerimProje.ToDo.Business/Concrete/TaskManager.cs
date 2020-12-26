using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.DataAccess.Interfaces;
using KerimProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace KerimProje.ToDo.Business.Concrete
{
    public class TaskManager : ITaskService
    {
        private readonly ITaskDal _taskDal;
        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }
        public void Delete(Task table)
        {
            _taskDal.Delete(table);
        }
        public List<Task> GetAll()
        {
            return _taskDal.GetAll();
        }
        public Task GetById(int id)
        {
            return _taskDal.GetById(id);
        }
        public void Save(Task table)
        {
            _taskDal.Save(table);
        }
        public void Update(Task table)
        {
            _taskDal.Update(table);
        }
    }
}
