using Microsoft.EntityFrameworkCore;
using ProniaFrontToBack.Models;

namespace ProniaFrontToBack.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> products { get; internal set; }
    }
   
 }
