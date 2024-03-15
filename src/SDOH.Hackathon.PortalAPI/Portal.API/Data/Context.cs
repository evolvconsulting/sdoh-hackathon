using Data.SeedScripts;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public partial class Context : DbContext
    {
        protected Context() { }
        public Context(DbContextOptions<Context> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasEmployeeSeedData();
            modelBuilder.HasUserSeedData();
        }
    }
}
