using Microsoft.EntityFrameworkCore;
using VenueApp.API.Models;

namespace VenueApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        { }

        public DbSet<value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }

}