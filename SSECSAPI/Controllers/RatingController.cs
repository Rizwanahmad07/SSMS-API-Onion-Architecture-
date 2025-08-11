using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSECSAPI.Data;
using SSECSAPI.Data.Interface;
using SSECSAPI.Models;

namespace SSECSAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        public IRating _rating;
        public RatingController(IRating rating)
        {
            _rating = rating;
        }
        [HttpGet]
        public IActionResult GetAllRating()
        {
            return Ok(_rating.GetAllRating());
        }
        [HttpGet("{id}")]
        public IActionResult GetRating(int id)
        {
            return Ok(_rating.GetRatingById(id));
        }
        [HttpPost]
        public IActionResult AddRating(Rating rating)
        {
            return Ok(_rating.AddRating(rating));
        }
        [HttpPut]
        public IActionResult UpdateRating(Rating rating)
        {
            return Ok(_rating.UpdateRating(rating));
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteRating(int id)
        {
            return Ok(_rating.DeleteRating(id));
        }
    }
}
