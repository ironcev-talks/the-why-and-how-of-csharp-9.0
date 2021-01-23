using TheWhyAndHowOfCSharp90;
using Microsoft.EntityFrameworkCore;

namespace Records.EntityFrameworkCore31
{
    public class DemoContext : BaseDemoDbContext
    {
        public DbSet<Author> Authors { get; set; }
    }
}
