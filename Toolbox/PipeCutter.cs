using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class PipeCutter
    {
        public static int count = 0;

        public PipeCutter() { }
        public void Describe()
        {
            Console.WriteLine("This is a pipe cutter.");
        }
        public void Use()
        {
            Console.WriteLine("The pipe cutter is being used.");
            count++;

        }
    }
}
