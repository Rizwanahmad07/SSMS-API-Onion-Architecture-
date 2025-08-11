using SSECSAPI.Models;

namespace SSECSAPI.Data.Interface
{
    public interface IUserRole
    {
        public List<UserRole> GetAllUserRoles();
        public UserRole GetUserRoleById(int id);
        public String AddUserRole(UserRole urole);
        public String UpdateUserRole(UserRole urole);
        public String DeleteUserRole(int id);
    }
}
