using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Wrench : BaseTool
    {
        public static int count = 0;

        public Wrench(string name, double weight) : base(name, weight) { }
        public override void Describe()
        {
            Console.WriteLine("This is a wrench.");
        }
        public override void Use()
        {
            Console.WriteLine("The wrench is being used.");
            count++;
        }
    }
}
