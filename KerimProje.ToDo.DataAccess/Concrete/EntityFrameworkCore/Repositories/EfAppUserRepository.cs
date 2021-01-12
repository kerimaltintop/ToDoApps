using KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Contexts;
using KerimProje.ToDo.DataAccess.Interfaces;
using KerimProje.ToDo.Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace KerimProje.ToDo.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfAppUserRepository : IAppUserDal
    {
        public List<AppUser> GetNotAdmin()
        {
            using var context = new ToDoContext();
            return context.Users.Join(context.UserRoles, user => user.Id, userRole =>
             userRole.UserId, (resultUser, resultUserRole) => new
             {
                 user = resultUser,
                 userRole = resultUserRole
             }).Join(context.Roles, twoTableResult => twoTableResult.userRole.RoleId, role => role.Id,
            (resultTable, resultRole) => new
            {
                user = resultTable.user,
                userRoles = resultTable.userRole,
                roles = resultRole
            }).Where(I => I.roles.Name == "Member").Select(I => new AppUser()
            {
                Id = I.user.Id,
                Name = I.user.Name,
                Surname = I.user.Surname,
                Picture = I.user.Picture,
                Email = I.user.Email,
                UserName = I.user.UserName
            }).ToList();



            //SELECT * FROM AspNetUsers INNER JOIN AspNetUserRoles 
            //ON AspNetUsers.Id = AspNetUserRoles.UserId
            //INNER JOIN AspNetRoles
            //ON AspNetUserRoles.RoleId = AspNetRoles.Id
            //WHERE AspNetRoles.Name = 'Member' 


        }
    }
}
