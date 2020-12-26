using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.DataAccess.Interfaces;
using KerimProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace KerimProje.ToDo.Business.Concrete
{
    public class UrgencyManager : IUrgencyService
    {
        private readonly IUrgencyDal _urgencyDal;
        public UrgencyManager(IUrgencyDal urgencyDal)
        {
            _urgencyDal = urgencyDal;
        }
        public void Delete(Urgency table)
        {
            _urgencyDal.Delete(table);
        }
        public List<Urgency> GetAll()
        {
            return _urgencyDal.GetAll();
        }
        public Urgency GetById(int id)
        {
            return _urgencyDal.GetById(id);
        }
        public void Save(Urgency table)
        {
            _urgencyDal.Save(table);
        }
        public void Update(Urgency table)
        {
            _urgencyDal.Update(table);
        }
    }
}
