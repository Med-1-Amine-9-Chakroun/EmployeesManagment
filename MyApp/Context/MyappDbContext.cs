using Microsoft.EntityFrameworkCore;
using Myapp.Models;

namespace Myapp.Data
{
    public class MyappDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
     public MyappDbContext(DbContextOptions<MyappDbContext> options) : base(options)
     {        
     }

        public DbSet<employee> Employees { get; set; }
    }
}