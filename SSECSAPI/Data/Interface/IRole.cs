using SSECSAPI.Models;

namespace SSECSAPI.Data.Interface
{
    public interface IRole
    {
        public List<Role> GetAllRoles();
        public Role GetRoleById(int id);
        public String AddRole(Role role);
        public String UpdateRole(Role role);
        public String DeleteRole(int id);
    }
}
