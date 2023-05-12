using Microsoft.EntityFrameworkCore;

namespace final.Models
{
    public class BookDbContext : DbContext
    {
        public BookDbContext (DbContextOptions<BookDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookReview>().HasKey(s => new {s.BookID, s.ReviewerID});
        }
        public DbSet<Book> Books {get; set;} = default!;
        public DbSet<Reviewer> Reviewer {get; set;} = default!;
    }
}