using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Saw
    {
        public static int count = 0;

        public Saw() { }
        public void Describe()
        {
            Console.WriteLine("This is a saw.");
        }
        public void Use()
        {
            Console.WriteLine("The saw is being used.");
            count++;

        }
    }
}
