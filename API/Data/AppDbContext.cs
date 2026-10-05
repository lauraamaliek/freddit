namespace freddit.Data;

using Microsoft.EntityFrameworkCore;
using freddit.Models;

public class AppDbContext : DbContext
{
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<Comment> Comments => Set<Comment>();

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

}