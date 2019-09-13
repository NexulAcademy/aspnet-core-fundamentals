using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Reflection;

namespace SimpleCrm.SqlDbServices
{
    public class SimpleCrmDbContextFactory : IDesignTimeDbContextFactory<SimpleCrmDbContext>
    {
        public SimpleCrmDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SimpleCrmDbContext>();
            builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SimpleCrm;Trusted_Connection=True;MultipleActiveResultSets=true",
                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(SimpleCrmDbContext).GetTypeInfo().Assembly.GetName().Name));
            return new SimpleCrmDbContext(builder.Options);
        }
    }
}