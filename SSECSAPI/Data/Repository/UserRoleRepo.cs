using SSECSAPI.Data.Interface;
using SSECSAPI.Models;

namespace SSECSAPI.Data.Repository
{
    public class UserRoleRepo : IUserRole
    {
        public AppDbContext _context;
        public UserRoleRepo(AppDbContext context) 
        {
            _context = context;
        }
        public string AddUserRole(UserRole urole)
        {
            _context.UserRoles.Add(urole);
            _context.SaveChanges();
            return "UserRole added successfully!";
        }

        public string DeleteUserRole(int id)
        {
            UserRole urole = _context.UserRoles.Find(id);
            _context.UserRoles.Remove(urole);
            _context.SaveChanges();
            return "UserRole Deleted successfully!";
        }

        public List<UserRole> GetAllUserRoles()
        {
            return _context.UserRoles.ToList();
        }

        public UserRole GetUserRoleById(int id)
        {
            return _context.UserRoles.Find(id);
        }

        public string UpdateUserRole(UserRole urole)
        {
            _context.UserRoles.Update(urole);
            _context.SaveChanges();
            return "UserRole Update successfully!";
        }
    }
}
