using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Drill
    {
        public static int count = 0;
        public Drill() { }
        public void Describe()
        {
            Console.WriteLine("This is a drill.");
        }
        public void Use()
        {
            Console.WriteLine("The drill is being used.");
            count++;

        }
    }
}
