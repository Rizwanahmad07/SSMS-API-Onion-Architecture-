using SSECSAPI.Data.Interface;
using SSECSAPI.Models;

namespace SSECSAPI.Data.Repository
{
    public class UserRepo : IUser
    {
        public AppDbContext _context;
        public UserRepo(AppDbContext context) 
        { 
            _context = context;
        }
        public string AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return "User Added Successfully!";
        }

        public String DeleteUser(int id)
        {
            User _user = _context.Users.Find(id);
            if (_user != null)
            {
                _context.Users.Remove(_user);
                _context.SaveChanges();
                return "User Deleted successfully!";
            }
            return "User not found!";
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.Find(id);
        }

        public String UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return "User Updated Successfully!";
        }
    }
}
