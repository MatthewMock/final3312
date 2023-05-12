using Microsoft.EntityFrameworkCore;

namespace final.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<BookDbContext>>()))
                {
                    if (context.Books.Any())
                    {
                        return;
                    }

                    context.Books.AddRange(
                        new Book
                        {
                            Title="The Name of the Wind",
                            Author="Patrick Rothfuss",
                            Genre="Fantasy",
                            Year=2007
                        },
                        new Book
                        {
                            Title="The Wise Man's Fear",
                            Author="Patrick Rothfuss",
                            Genre="Fantasy",
                            Year=2011
                        },
                        new Book
                        {
                            Title="The Slow Regard of Silent Things",
                            Author="Patrick Rothfuss",
                            Genre="Fantasy",
                            Year=2014
                        },
                        new Book
                        {
                            Title="The Way of Kings",
                            Author="Brandon Sanderson",
                            Genre="Fantasy",
                            Year=2010
                        },
                        new Book
                        {
                            Title="Words of Radiance",
                            Author="Brandon Sanderson",
                            Genre="Fantasy",
                            Year=2014
                        },
                        new Book
                        {
                            Title="Oathbringer",
                            Author="Brandon Sanderson",
                            Genre="Fantasy",
                            Year=2017
                        },
                        new Book
                        {
                            Title="Rhythm of war",
                            Author="Brandon Sanderson",
                            Genre="Fantasy",
                            Year=2020
                        },
                        new Book
                        {
                            Title="Mistborn: The Final Empire",
                            Author="Brandon Sanderson",
                            Genre="Fantasy",
                            Year=2006
                        },
                        new Book
                        {
                            Title="The Well of Ascension",
                            Author="Brandon Sanderson",
                            Genre="Fantasy",
                            Year=2007
                        },
                        new Book
                        {
                            Title="The Hero of Ages",
                            Author="Brandon Sanderson",
                            Genre="Fantasy",
                            Year=2008
                        },
                        new Book
                        {
                            Title="Secret History",
                            Author="Brandon Sanderson",
                            Genre="Fantasy",
                            Year=2016
                        },
                        new Book
                        {
                            Title="The Alloy of Law",
                            Author="Brandon Sanderson",
                            Genre="Fantasy",
                            Year=2011
                        },
                        new Book
                        {
                            Title="Shadows of Self",
                            Author="Brandon Sanderson",
                            Genre="Fantasy",
                            Year=2015
                        },
                        new Book
                        {
                            Title="The Bands of Mourning",
                            Author="Brandon Sanderson",
                            Genre="Fantasy",
                            Year=2016
                        },
                        new Book
                        {
                            Title="The Lost Metal",
                            Author="Brandon Sanderson",
                            Genre="Fantasy",
                            Year=2022
                        },
                        new Book
                        {
                            Title="Dune",
                            Author="Frank Herbert",
                            Genre="Sci-Fi",
                            Year=1965
                        },
                        new Book
                        {
                            Title="Dune Messiah",
                            Author="Frank Herbert",
                            Genre="Sci-Fi",
                            Year=1969
                        },
                        new Book
                        {
                            Title="Children of Dune",
                            Author="Frank Herbert",
                            Genre="Sci-Fi",
                            Year=1976
                        },
                        new Book
                        {
                            Title="God Emperor of Dune",
                            Author="Frank Herbert",
                            Genre="Sci-Fi",
                            Year=1981
                        },
                        new Book
                        {
                            Title="Heretics of Dune",
                            Author="Frank Herbert",
                            Genre="Sci-Fi",
                            Year=1984
                        },
                        new Book
                        {
                            Title="Chapterhouse: Dune",
                            Author="Frank Herbert",
                            Genre="Sci-Fi",
                            Year=1985
                        },
                        new Book
                        {
                            Title="House Atreides",
                            Author="Brian Herbert",
                            Genre="Sci-Fi",
                            Year=1999
                        },
                        new Book
                        {
                            Title="House Harkonnen",
                            Author="Brian Herbert",
                            Genre="Sci-Fi",
                            Year=2000
                        },
                        new Book
                        {
                            Title="House Corrino",
                            Author="Brian Herbert",
                            Genre="Sci-Fi",
                            Year=2001
                        },
                        new Book
                        {
                            Title="The Butlerian Jihad",
                            Author="Brian Herbert",
                            Genre="Sci-Fi",
                            Year=2002
                        },
                        new Book
                        {
                            Title="The Machine Crusade",
                            Author="Brian Herbert",
                            Genre="Sci-Fi",
                            Year=2003
                        },
                        new Book
                        {
                            Title="The Battle of Corrin",
                            Author="Brian Herbert",
                            Genre="Sci-Fi",
                            Year=2004
                        }
                    );

                    context.SaveChanges();
                }
        }
    }
}