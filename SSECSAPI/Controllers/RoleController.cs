using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSECSAPI.Data;
using SSECSAPI.Data.Interface;
using SSECSAPI.Models;
using System.Diagnostics.Metrics;

namespace SSECSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        public IRole _role;
        public RoleController(IRole role) 
        { 
            _role = role;
        }

        [HttpGet]
        public IActionResult GetAllRole()
        {
            var datas = _role.GetAllRoles();
            return Ok(new
            {
                data= datas,
                status = 200
            });
        }
        [HttpGet("{id}")]
        public IActionResult GetRole(int id)
        {
            var datas = _role.GetRoleById(id);
            return Ok(new
            {
                data= datas,
                status = 200
            });
        }
        [HttpPost]
        public IActionResult AddRole(Role role)
        {
            var datas = _role.AddRole(role);
            return Ok(new
            {
                data= datas,
                status = 201
            });
        }
        [HttpPut]
        public IActionResult UpdateRole(Role role)
        {
            var datas = _role.UpdateRole(role);
            return Ok(new
            {
                data= datas,
                status = 200
            });
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRole(int id)
        {
            var datas = _role.DeleteRole(id);
            return Ok(new
            {
                data= datas,
                status = 204
            });
        }
    }
}
