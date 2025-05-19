using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Hammer
    {
        public static int count = 0;

        public Hammer() { }
        public void Describe()
        {
            Console.WriteLine("This is a hammer.");
        }
        public void Use()
        {
            Console.WriteLine("The hammer is being used.");
            count++;

        }
    }
}
