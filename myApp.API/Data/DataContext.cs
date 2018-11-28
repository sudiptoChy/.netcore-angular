using Microsoft.EntityFrameworkCore;
using myApp.API.Models;

namespace myApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet <Value> MyProperty { get; set; }
        public DbSet <User> Users { get; set; }
        public DbSet <Photo> Photos { get; set; }
    }
}
