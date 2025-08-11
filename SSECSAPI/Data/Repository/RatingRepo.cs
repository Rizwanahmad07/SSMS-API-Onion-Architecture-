using SSECSAPI.Data.Interface;
using SSECSAPI.Models;

namespace SSECSAPI.Data.Repository
{
    public class RatingRepo : IRating
    {
        public AppDbContext _context;
        public RatingRepo(AppDbContext context)
        {
            _context = context;
        }
        public string AddRating(Rating rating)
        {
            _context.Ratings.Add(rating);
            _context.SaveChanges();
            return "Rating added Successfully!";
        }

        public string DeleteRating(int id)
        {
            Rating rating = _context.Ratings.Find(id);
            _context.Ratings.Remove(rating);
            _context.SaveChanges();
            return "Rating deleted Successfully!";
        }

        public List<Rating> GetAllRating()
        {
            return _context.Ratings.ToList();
        }

        public Rating GetRatingById(int id)
        {
            return _context.Ratings.Find(id);
        }

        public string UpdateRating(Rating rating)
        {
            _context.Ratings.Update(rating);
            _context.SaveChanges();
            return "Rating Updated Successfully!";
        }
    }
}
