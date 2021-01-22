using TheWhyAndHowOfCSharp90;
using Microsoft.EntityFrameworkCore;

namespace InitOnlySetters.EntityFrameworkCore31
{
    public class DemoContext : BaseDemoDbContext
    {
        public DbSet<Author> Authors { get; set; }
    }
}
