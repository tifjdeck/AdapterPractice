
// The Grizzly class using the IBear interface. It can maul and hibernate.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractice
{
    public class Grizzly : IBear
    {
        public void maul()
        {
            Console.WriteLine("You've been mauled.");
        }

        public void hibernate()
        {
            Console.WriteLine("He sleeps.");
        }
    }
}
