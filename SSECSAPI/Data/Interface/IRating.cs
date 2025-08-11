using SSECSAPI.Models;

namespace SSECSAPI.Data.Interface
{
    public interface IRating
    {
        public List<Rating> GetAllRating();
        public Rating GetRatingById(int id);
        public string AddRating(Rating rating);
        public string UpdateRating(Rating rating);
        public string DeleteRating(int id);
    }
}
