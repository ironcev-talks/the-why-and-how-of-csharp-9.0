using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;

namespace TheWhyAndHowOfCSharp90
{
    public partial class Program
    {
        private static void CreateDatabase<TDbContext>(TDbContext context)
            where TDbContext : DbContext
        {
            CreateModifyAndSeedDatabase(context, null, null);
        }

        private static void CreateAndSeedDatabase<TDbContext>(TDbContext context, Action<TDbContext> seedDatabase)
            where TDbContext : DbContext
        {
            CreateModifyAndSeedDatabase(context, seedDatabase, null);
        }

        private static void CreateModifyAndSeedDatabase<TDbContext>(TDbContext context, Action<TDbContext> modifyDatabase, Action<TDbContext> seedDatabase)
            where TDbContext : DbContext
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            modifyDatabase?.Invoke(context);
            seedDatabase?.Invoke(context);
        }
    }
}
