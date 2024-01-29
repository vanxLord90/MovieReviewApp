namespace MovieReviewApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public string Star { get; set; }

        public int Runtime { get; set; }

        public int BoxOffice { get; set; }
        public int votes { get; set; }
        public List<Review> Reviews { get; set; }

        public Movie()
        {
            Reviews = new List<Review>();
        }


    }
}
