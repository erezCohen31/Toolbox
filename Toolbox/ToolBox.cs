using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox
{
    public class ToolBox
    {
        List<BaseTool> tools;
        public ToolBox()
        {
            tools = new List<BaseTool>();
        }
        public void AddTool(BaseTool tool)
        {
            tools.Add(tool);
        }
        public void RemoveTool(BaseTool tool)
        {
            tools.Remove(tool);
        }
        public void ListTools()
        {
            Console.WriteLine("Tools in the toolbox:");
            foreach (var tool in tools)
            {
                tool.Describe();
            }
        }
        public void UseTool(BaseTool tool)
        {
            if (tools.Contains(tool))
            {
                tool.Use();
            }
            else
            {
                Console.WriteLine("Tool not found in the toolbox.");
            }
        }

    }

}
