using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Grizzly.Bear();
            IToyBear.TeddyBear();
            IToyBear BearAdapter(Grizzly);

            Console.WriteLine(Grizzly.maul());
            Console.WriteLine(Grizzly.hibernate());
            Console.WriteLine(TeddyBear.hug());
            Console.ReadKey();
        }
    }
}
