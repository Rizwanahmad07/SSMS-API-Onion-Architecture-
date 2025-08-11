using SSECSAPI.Models;

namespace SSECSAPI.Data.Interface
{
    public interface IUser
    {
        public List<User> GetAllUsers();
        public User GetById(int id);
        public String AddUser(User user);
        public String UpdateUser(User user);
        public String DeleteUser(int id);
    }
}
