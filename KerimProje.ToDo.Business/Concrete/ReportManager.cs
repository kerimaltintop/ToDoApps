using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.DataAccess.Interfaces;
using KerimProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace KerimProje.ToDo.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly IReportDal _reportDal;
        public ReportManager(IReportDal reportDal)
        {
            _reportDal = reportDal;
        }
        public void Delete(Report table)
        {
            _reportDal.Delete(table);
        }
        public List<Report> GetAll()
        {
            return _reportDal.GetAll();
        }
        public Report GetById(int id)
        {
            return _reportDal.GetById(id);
        }
        public void Save(Report table)
        {
            _reportDal.Save(table);
        }
        public void Update(Report table)
        {
            _reportDal.Update(table);
        }
    }
}
