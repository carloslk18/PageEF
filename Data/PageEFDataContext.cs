using Microsoft.EntityFrameworkCore;
using PageEF.Models;

namespace PageEF.Data{

public class PageEFDataContext : DbContext{

    public DbSet<User> Users{get; set;}
    public DbSet<Role> Roles{get; set;}
    public DbSet<Category> Categories{get; set;}
    public DbSet<Post> Posts{get; set;}
    public DbSet<Tag> Tags{get; set;}
    //public DbSet<UserRole> UserRoles{get; set;}
    //public DbSet<PostTag> PostTags{get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=localhost,1433;Database=SlkDB;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");
        }
    }
}