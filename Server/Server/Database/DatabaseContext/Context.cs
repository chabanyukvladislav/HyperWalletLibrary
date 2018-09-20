using Microsoft.EntityFrameworkCore;
using Server.Database.Model;

namespace Server.Database.DatabaseContext
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}