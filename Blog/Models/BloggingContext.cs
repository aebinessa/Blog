namespace Blog.Models
{
    using Microsoft.EntityFrameworkCore;

    public class BloggingContext : DbContext
    {
        public DbSet<BlogDB> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed sample blog data:::::::::::::::::::::::::::
            modelBuilder.Entity<BlogDB>().HasData(
                new BlogDB { Id = 1, Url = "Blog 1", Name = "Diaries of a wimpy kid" },
                new BlogDB { Id = 2, Url = "Blog 2", Name= "Daily lives of high school boys" }
            );
        }

    }
}


