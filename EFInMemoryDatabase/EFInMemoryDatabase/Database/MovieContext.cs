using EFInMemoryDatabase.Database.Tables;
using Microsoft.EntityFrameworkCore;

namespace EFInMemoryDatabase.Database
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public MovieContext(DbContextOptions options) : base(options)  
        {
            LoadMovies();
            LoadGenres();

            SaveChanges();
        }

        public void LoadMovies()
        {
            Movies.Add(new Movie()
            {
                Description = "An organized crime dynasty's aging patriarch transfers control of his clandestine empire to his reluctant son.",
                GenreId = 1,
                MovieId = 1,
                Title = "The Godfather"
            });

            Movies.Add(new Movie()
            {
                Description = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                GenreId = 2,
                MovieId = 2,
                Title = "The Shawshank Redemption"
            });

            Movies.Add(new Movie()
            {
                Description = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                GenreId = 2,
                MovieId = 3,
                Title = "Schindler's List "
            });
        }

        public void LoadGenres()
        {
            Genres.Add(new Genre()
            {
                GenreId = 1,
                Label = "Crime"
            });

            Genres.Add(new Genre()
            {
                GenreId = 2,
                Label = "Drama"
            });
        }
    }
}
