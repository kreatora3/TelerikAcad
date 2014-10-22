using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSystem;
using System.Diagnostics;

namespace ToListQuery
{
    class Program
    {
        static void Main()
        {
            var db = new TelerikAcademyEntities();
            var watch = Stopwatch.StartNew();

            var query = db.Employees.ToList()
                .Select(e => e).ToList()
                .Select(e => e.Address).ToList()
                .Select(a => a.Town).ToList()
                .Where(t => t.Name.ToLower() == "sofia");
            var count = query.Count();
            watch.Stop();
            Console.WriteLine("ToList() took {0} miliseconds", watch.Elapsed.Milliseconds);

            var clock = Stopwatch.StartNew();
            var fastQuery = db.Employees.Select(e => e).Select(e => e.Address).Select(a => a.Town).Where(t => t.Name.ToLower() == "sofia");
            var counter = fastQuery.Count();
            clock.Stop();
            Console.WriteLine("Fast way  took {0} miliseconds", clock.Elapsed.Milliseconds);

        }
    }
}
