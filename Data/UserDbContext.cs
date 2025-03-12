using Microsoft.EntityFrameworkCore;
using UsersAPI.Models;

namespace UsersAPI.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}

