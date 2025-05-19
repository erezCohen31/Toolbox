using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Drill : BaseTool
    {
        public static int count = 0;
        public Drill(string name, double weight) : base(name, weight)
        {
        }

        public override void Describe()
        {
            Console.WriteLine("This is a drill.");
        }
        public override void Use()
        {
            Console.WriteLine("The drill is being used.");
            count++;

        }
    }
}
