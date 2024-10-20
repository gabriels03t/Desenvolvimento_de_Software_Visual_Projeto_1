using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Agendify.Data
{
    public class AgendifyDbContextFactory : IDesignTimeDbContextFactory<AgendifyDbContext>
    {
        public AgendifyDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AgendifyDbContext>();
            optionsBuilder.UseSqlite("Data Source=Agendify.db");

            return new AgendifyDbContext(optionsBuilder.Options);
        }
    }
}
    