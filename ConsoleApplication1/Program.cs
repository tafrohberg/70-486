using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string foober = "Hello, World!";
            Console.WriteLine(foober);

            foober = String.Concat(foober, ' ', 'T');
            string[] bax = foober.Split(' ');
            string qux = Array.Find(bax,
                element => element.StartsWith('T'));

            Console.WriteLine(String.Format("{0}revor is cool!", qux));
        }
    }
}
