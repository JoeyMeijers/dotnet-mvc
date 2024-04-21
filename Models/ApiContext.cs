using Microsoft.EntityFrameworkCore;

namespace api.Models;

public class ApiContext : DbContext
{
    public DbSet<User> Users {set; get;}
    // add other models

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite(@"Data source=./api.db");
}