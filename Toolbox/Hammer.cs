using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Hammer : BaseTool
    {
        public static int count = 0;

        public Hammer(string name, double weight) : base(name, weight)
        {
        }
        public override void Describe()
        {
            Console.WriteLine("This is a hammer.");
        }
        public override void Use()
        {
            Console.WriteLine("The hammer is being used.");
            count++;

        }
    }
}
