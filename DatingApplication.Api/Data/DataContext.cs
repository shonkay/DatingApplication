using DatingApplication.Api.Model;
using Microsoft.EntityFrameworkCore;

namespace DatingApplication.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Value> Values { get; set; }
    }
}