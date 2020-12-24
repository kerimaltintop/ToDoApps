using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using KerimProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace KerimProje.ToDo.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly EfReportRepository efReportRepository;
        public ReportManager()
        {
            efReportRepository = new EfReportRepository();
        }
        public void Delete(Report table)
        {
            efReportRepository.Delete(table);
        }
        public List<Report> GetAll()
        {
            return efReportRepository.GetAll();
        }
        public Report GetById(int id)
        {
            return efReportRepository.GetById(id);
        }
        public void Save(Report table)
        {
            efReportRepository.Save(table);
        }
        public void Update(Report table)
        {
            efReportRepository.Update(table);
        }
    }
}
