using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ConsoleApp4
{
    public class Language
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    class TestContext : DbContext
    {
        public TestContext() : base(new DbContextOptionsBuilder<TestContext>()
            .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TestContext").Options)
        {
        }

        public DbSet<Language> Languages { get; set; }
    }
}
