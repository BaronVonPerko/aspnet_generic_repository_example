using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CoreTestContext : DbContext
    {
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Person> People { get; set; }
        
        public CoreTestContext(DbContextOptions options) : base(options) { }
    }
}