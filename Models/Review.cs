namespace MovieReviewApp.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Reviewer { get; set; }
        public string ReviewDate { get; set; }
        public double Rating { get; set; }

        public string MovieReview { get; set; }
        public Review()
        {
            
        }
    }
}
