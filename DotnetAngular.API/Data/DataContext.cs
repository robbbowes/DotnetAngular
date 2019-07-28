using DotnetAngular.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetAngular.API.Data
{
    public class DataContext : DbContext {

        public DataContext(DbContextOptions<DataContext> options) : base (options) { }

        public DbSet<Value> Values { get; set; }

     }
}