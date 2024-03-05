
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Mission6_Kemp.Models
{
    public class MovieListContext : DbContext
    {
        public MovieListContext(DbContextOptions<MovieListContext> options) : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }
        // seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder) //send data
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Horror" },
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Romance" },
                new Category { CategoryId = 4, CategoryName = "Romantic Comedy" },
                new Category { CategoryId = 5, CategoryName = "Action" },
                new Category { CategoryId = 6, CategoryName = "Drama" },
                new Category { CategoryId = 7, CategoryName = "Crime" },
                new Category { CategoryId = 8, CategoryName = "Thriller" },
                new Category { CategoryId = 9, CategoryName = "SciFi" },
                new Category { CategoryId = 10, CategoryName = "Fantasy" },
                new Category { CategoryId = 11, CategoryName = "Musical" },
                new Category { CategoryId = 12, CategoryName = "Historical" },
                new Category { CategoryId = 13, CategoryName = "War" },
                new Category { CategoryId = 14, CategoryName = "Mystery" },
                new Category { CategoryId = 15, CategoryName = "Indie" },
                new Category { CategoryId = 16, CategoryName = "Adventure" },
                new Category { CategoryId = 17, CategoryName = "Animation" },
                new Category { CategoryId = 18, CategoryName = "Fantasy" },
                new Category { CategoryId = 19, CategoryName = "Historical Fiction" }, 
                new Category { CategoryId = 20, CategoryName = "Fiction" },
                new Category { CategoryId = 21, CategoryName = "Children's" },
                new Category { CategoryId = 22, CategoryName = "Sports" },
                new Category { CategoryId = 23, CategoryName = "Satire" }
            );
        }
    }
}
