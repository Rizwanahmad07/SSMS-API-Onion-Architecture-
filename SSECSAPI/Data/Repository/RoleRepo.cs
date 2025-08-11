using SSECSAPI.Data.Interface;
using SSECSAPI.Models;

namespace SSECSAPI.Data.Repository
{
    public class RoleRepo : IRole
    {
        public AppDbContext _contect;
        public RoleRepo(AppDbContext contect)
        {
            _contect = contect;
        }
        public string AddRole(Role role)
        {
            _contect.Roles.Add(role);
            _contect.SaveChanges();
            return ("Role Added successfully!");
        }

        public string DeleteRole(int id)
        {
            Role role = _contect.Roles.Find(id);
            if (role != null)
            {
                _contect.Remove(role);
                _contect.SaveChanges();
                return ("Role Deleted Successfully!");
            }
            return ("Role not found!");
        }

        public List<Role> GetAllRoles()
        {
            return _contect.Roles.ToList();
        }

        public Role GetRoleById(int id)
        {
            return _contect.Roles.Find(id);
        }

        public string UpdateRole(Role role)
        {
            _contect.Roles.Update(role);
            _contect.SaveChanges();
            return ("Role Updated Successfully!");
        }
    }
}
