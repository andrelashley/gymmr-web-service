using Gymmr.Models;
using Microsoft.EntityFrameworkCore;

namespace Gymmr.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Photo> Photos { get; set; }
    }
}
