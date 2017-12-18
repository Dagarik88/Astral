using AstralNew.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace AstralNew.DAL
{
    public class AstralNewContext : DbContext
    {
        public DbSet<Vacancy> Vacancy { get; set; }
        public AstralNewContext(DbContextOptions<AstralNewContext> options)
            : base(options)
        {
        }
    }
}
