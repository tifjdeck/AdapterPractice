
// The BearAdapter class using the IToyBear interface. It overrides the hug function to use the maul function from the IBear interface.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractice
{
    public class BearAdapter : IToyBear
    {
        IBear realBear;
        
        public BearAdapter(IBear bear) {
            realBear = bear;
        }

         public void hug()
        {
            realBear.maul();
        }
    }
}
