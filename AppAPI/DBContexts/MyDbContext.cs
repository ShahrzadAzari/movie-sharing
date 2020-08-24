using Microsoft.EntityFrameworkCore;
using SharedData;

namespace AppAPI
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            :base(options)
        {}
        public DbSet<MovieDataModel> Movies {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieDataModel>().ToTable("Movies");
        }
    }
}