using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Wrench
    {
        public static int count = 0;

        public Wrench() { }
        public void Describe()
        {
            Console.WriteLine("This is a wrench.");
        }
        public void Use()
        {
            Console.WriteLine("The wrench is being used.");
            count++;
        }
    }
}
