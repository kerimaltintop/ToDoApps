using KerimProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace KerimProje.ToDo.DataAccess.Interfaces
{
    public interface IAppUserDal 
    {
        List<AppUser> GetNotAdmin();
    }
}
