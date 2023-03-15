using Microsoft.EntityFrameworkCore;
using MovieReview.Models;

namespace MovieReview.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Review> Review { get; set; }
    }
}