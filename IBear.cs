
// The interface for the Bear classes. Allows Bears to call the maul and hibernate.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractice
{
    public interface IBear
    {
        void maul();
        void hibernate();
    }
}
