
// The main program that uses the ToyBear and Bear interfaces and prints details for a Grizzly, a TeddyBear, and a BearAdapter.

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
            IBear bear = new Grizzly();
            IToyBear toyBear = new TeddyBear();
            IToyBear realToyBear = new BearAdapter(bear);

            bear.hibernate();
            bear.maul();

            toyBear.hug();

            realToyBear.hug();

            Console.ReadKey();
        }
    }
}
