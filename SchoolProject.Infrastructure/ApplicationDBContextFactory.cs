using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SchoolProject.Infrastructure.Data
{
    public class ApplicationDBContextFactory : IDesignTimeDbContextFactory<ApplicationDBContext>
    {
        public ApplicationDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDBContext>();
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;Database=SchoolProject;Trusted_Connection=True;Encrypt=False");
            return new ApplicationDBContext(optionsBuilder.Options);
        }
    }
}
