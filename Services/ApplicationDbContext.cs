using dotnetMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetMvc.Services
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<Product> Products { get; set; }


    }
   
}
