using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSECSAPI.Data.Interface;
using SSECSAPI.Models;

namespace SSECSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IUser _user;
        public UserController(IUser user)
        {
            _user = user;
        }

        [HttpGet]
        public ActionResult GetAllUser()
        {
            var datas = _user.GetAllUsers();
            return Ok(new
            {
                data = datas,
                status = 200
            });
        }

        [HttpGet("{id}")]
        public ActionResult GetUser(int id)
        {
            var datas = _user.GetById(id);
            return Ok(new
            {
                data = datas,
                status = 200
            });
        }

        [HttpPost]
        public ActionResult AddUser(User user)
        {
            var datas = _user.AddUser(user);
            return Ok(new
            {
                data = datas,
                status = 201
            });
        }

        [HttpPut("{id}")]
        public ActionResult UpdateUser(User user)
        {
            var datas = _user.UpdateUser(user);
            return Ok(new
            {
                data = datas,
                status = 200
            });
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteUser(int id)
        {
            var datas = _user.DeleteUser(id);
            return Ok(new
            {
                data = datas,
                status = 204
            });
        }
    }
}
