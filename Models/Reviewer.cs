namespace final.Models
{
    public class Reviewer
    {
        public int ReviewerID {get; set;}
        public string Name {get; set;} = string.Empty;
        public string Password {get; set;} = string.Empty;
        public List<BookReview> BookReviews {get; set;} = null!;
    }
}