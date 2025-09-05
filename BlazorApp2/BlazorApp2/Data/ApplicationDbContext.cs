using Microsoft.EntityFrameworkCore;

namespace BlazorApp2.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<House> Houses { get; set; }
}