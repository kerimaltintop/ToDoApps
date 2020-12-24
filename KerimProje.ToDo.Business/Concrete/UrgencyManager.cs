using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using KerimProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace KerimProje.ToDo.Business.Concrete
{
    public class UrgencyManager : IUrgencyService
    {
        private readonly EfUrgencyRepository efUrgencyRepository;
        public UrgencyManager()
        {
            efUrgencyRepository = new EfUrgencyRepository();
        }
        public void Delete(Urgency table)
        {
            efUrgencyRepository.Delete(table);
        }
        public List<Urgency> GetAll()
        {
            return efUrgencyRepository.GetAll();
        }
        public Urgency GetById(int id)
        {
            return efUrgencyRepository.GetById(id);
        }
        public void Save(Urgency table)
        {
            efUrgencyRepository.Save(table);
        }
        public void Update(Urgency table)
        {
            efUrgencyRepository.Update(table);
        }
    }
}
