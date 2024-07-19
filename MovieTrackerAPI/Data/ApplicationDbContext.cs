using Microsoft.EntityFrameworkCore;
using MovieTrackerAPI.Models.Movies;
using MovieTrackerAPI.Models.Rewatched;
using MovieTrackerAPI.Models.User;

namespace MovieTrackerAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        #region DbSets
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Rewatched> Rewatched { get; set; }
        #endregion

        #region Database Initializers
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>().HasData(
                new Movies
                {
                    movieId = 1,
                    movieName = "Bambi",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 2,
                    movieName = "Aristogatos",
                    movieStatus = 0,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 3,
                    movieName = "A Dama e o Vagabundo",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 4,
                    movieName = "101 Dalmatas",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 5,
                    movieName = "Mogli",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 6,
                    movieName = "Papuça e Dentuça",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 7,
                    movieName = "Alladin",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 8,
                    movieName = "Mulan",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 9,
                    movieName = "Ratatoille",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 10,
                    movieName = "Tarzan",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 11,
                    movieName = "Pinochio",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 12,
                    movieName = "Hercules",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 13,
                    movieName = "Paraiso da Barafunda",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 14,
                    movieName = "O Corcunda de Nostredame",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 15,
                    movieName = "GodZilla 2014",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 16,
                    movieName = "King Of Monsters",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                }, 
                new Movies
                {
                    movieId = 17,
                    movieName = "Kong Vs Godzilla",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                },
                new Movies
                {
                    movieId = 18,
                    movieName = "Moana",
                    movieStatus = 0,
                    genre = null,
                    timesRewatched = null,
                    imageUrl = "",
                    creationDate = DateTime.Now,
                });

            modelBuilder.Entity<Users>().HasData(
                new Users
                {
                   userId = 1,
                   username = "Ricardo",
                   creationDate = DateTime.Now,
                },
                new Users
                {
                    userId = 2,
                    username =  "Rafa",
                    creationDate = DateTime.Now,
                },
                new Users
                {
                    userId = 3,
                    username = "Alex",
                    creationDate = DateTime.Now,
                });
        }
        #endregion

    }
}
