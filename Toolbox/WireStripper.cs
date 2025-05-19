using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Toolbox
{
    public class WireStripper : BaseTool
    {
        public static int count = 0;
        public WireStripper(string name, double weight) : base(name, weight)
        {
        }
        public override void Describe()
        {
            Console.WriteLine("This is a wire stripper.");
        }
        public override void Use()
        {
            Console.WriteLine("The wire stripper is being used.");
            count++;
        }
    }
    
    
}
