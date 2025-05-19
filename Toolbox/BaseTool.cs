using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class BaseTool
    {
        string name;
        double weight;

        public BaseTool(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }


        public virtual void Describe()
        {
            Console.WriteLine($"Tool: {name}, Weight: {weight} kg");
        }
        public virtual void Use()
        {
            Console.WriteLine("Tool is being used.");
        }
    }
}
