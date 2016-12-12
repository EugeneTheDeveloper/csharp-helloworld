using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer { ID = 1, Name = "Name 1" };
            Console.WriteLine($"{{ID = {c.ID}, Name = '{c.Name}'}}");
            Console.WriteLine("rep0-1");
            Console.WriteLine("rep0-2");
            Console.WriteLine("rep1-1");
            Console.WriteLine("rep1-2");
            Console.WriteLine("rep0-3");
            Console.WriteLine("rep1-3");
            Console.WriteLine("rep0-4");
            Console.ReadKey();
        }
    }
}
