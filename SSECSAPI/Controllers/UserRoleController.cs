using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSECSAPI.Data.Interface;
using SSECSAPI.Models;

namespace SSECSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        public IUserRole _userRole;
        public UserRoleController(IUserRole userRole) 
        {
            _userRole = userRole;
        }
        [HttpGet]
        public IActionResult GetAllUserRole()
        {
            var roles = _userRole.GetAllUserRoles();
            return Ok(new
            {
                data = roles,
                status = 200
            });
        }
        [HttpGet("{id}")]
        public IActionResult GetUserRoleById(int id)
        {
            var role = _userRole.GetUserRoleById(id);
            return Ok(new
            {
                data = role,
                status = 200
            });
        }
        [HttpPost]
        public IActionResult AddUserRole(UserRole userRole)
        {
            var role = _userRole.AddUserRole(userRole);
            return Ok(new
            {
                data = role,
                status = 201
            });
        }
        [HttpPut]
        public IActionResult UpdateUserRole(UserRole userRole)
        {
            var role = _userRole.UpdateUserRole(userRole);
            return Ok(new
            {
                data = role,
                status = 200
            });
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUserRole(int id)
        {
            var role = _userRole.DeleteUserRole(id);
            return Ok(new
            {
                data = role,
                status = 204
            });
        }
    }
}
