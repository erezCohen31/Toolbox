using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Screwdriver : BaseTool
    {
        public static int count = 0;

        public Screwdriver(string name, double weight) : base(name, weight) { }
        public override void Describe()
        {
            Console.WriteLine("This is a screwdriver.");
        }
        public override void Use()
        {
            Console.WriteLine("The screwdriver is being used.");
            count++;

        }
    }
}
