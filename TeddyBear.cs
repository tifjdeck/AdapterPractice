using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractice
{
    class TeddyBear : IToyBear
    {
        public void hug()
        {
            Console.WriteLine("He hugs you!");
        }
    }
}
