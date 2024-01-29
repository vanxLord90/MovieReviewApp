using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieReviewApp.Models;

namespace MovieReviewApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MovieReviewApp.Models.Movie> Movie { get; set; } = default!;
        public DbSet<MovieReviewApp.Models.Review> Review { get; set; } = default!;

       
    }
}
