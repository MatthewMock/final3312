
namespace final.Models
{
    public class Book
    {
        public int BookID {get; set;}
        public string Title {get; set;} = string.Empty;
        public string Author {get; set;} = string.Empty;
        public string Genre {get; set;} = string.Empty;
        public int Year {get; set;}
        public List<BookReview> BookReviews {get; set;} = null!;
    }
    public class BookReview
    {
        public int BookID {get; set;}
        public int ReviewerID {get; set;}
        public int Score {get; set;}
        public string Review {get; set;} = string.Empty;
        public Book Book {get; set;} = default!;
        public Reviewer Reviewer {get; set;} = default!;
    }
}

