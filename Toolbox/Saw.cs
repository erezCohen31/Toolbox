using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Saw : BaseTool
    {
        public static int count = 0;

        public Saw(string name, double weight) : base(name, weight) { }
        public override void Describe()
        {
            Console.WriteLine("This is a saw.");
        }
        public override void Use()
        {
            Console.WriteLine("The saw is being used.");
            count++;

        }
    }
}
