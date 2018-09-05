using System;
using System.Linq;

namespace EfCore02.Con
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Models.pubsContext())
            {
                db.Authors
                    .OrderBy(a=>a.AuLname)
                    .ThenBy(a=>a.AuFname)
                    .ToList()
                    .ForEach(a=>Console.WriteLine($"{a.AuLname}, {a.AuLname};"));
            }

            Console.ReadLine();
        }
    }
}
