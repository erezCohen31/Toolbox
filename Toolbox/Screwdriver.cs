using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class Screwdriver
    {
        public static int count = 0;

        public Screwdriver() { }
        public void Describe()
        {
            Console.WriteLine("This is a screwdriver.");
        }
        public void Use()
        {
            Console.WriteLine("The screwdriver is being used.");
            count++;

        }
    }
}
