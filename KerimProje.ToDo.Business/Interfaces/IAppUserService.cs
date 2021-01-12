using KerimProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace KerimProje.ToDo.Business.Interfaces
{
    public interface IAppUserService
    {
        List<AppUser> GetNotAdmin();
    }
}
