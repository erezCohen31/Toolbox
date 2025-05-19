using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class PipeCutter : BaseTool
    {
        public static int count = 0;

        public PipeCutter(string name, double weight) : base(name, weight) { }
        public override void Describe()
        {
            Console.WriteLine("This is a pipe cutter.");
        }
        public override void Use()
        {
            Console.WriteLine("The pipe cutter is being used.");
            count++;

        }
    }
}
