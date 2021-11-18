using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new TestContext();

            var test = context.Languages.Where(x => x.Name.StartsWith("t", StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
