using KerimProje.ToDo.Business.Interfaces;
using KerimProje.ToDo.DataAccess.Interfaces;
using KerimProje.ToDo.Entities.Concrete;
using System.Collections.Generic;

namespace KerimProje.ToDo.Business.Concrete
{
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _userDal;
        public AppUserManager(IAppUserDal userDal)
        {
            _userDal = userDal;
        }
        public List<AppUser> GetNotAdmin()
        {
            return _userDal.GetNotAdmin();
        }
    }
}
