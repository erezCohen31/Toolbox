using Toolbox;

public class program
{
    public static void Main(string[] args)
    {
        // Create a toolbox
        ToolBox myToolBox = new ToolBox();
        // Create some tools
        BaseTool hammer = new Hammer("Hammer", 1.5);
        BaseTool screwdriver = new Screwdriver("Screwdriver", 0.5);
        BaseTool wrench = new Wrench("Wrench", 2.0);
        BaseTool wirestrip = new WireStripper("WireStripper", 0.5);
        // Add tools to the toolbox
        myToolBox.AddTool(hammer);
        myToolBox.AddTool(screwdriver);
        myToolBox.AddTool(wrench);
        myToolBox.AddTool(wirestrip);
        // List tools in the toolbox
        myToolBox.ListTools();
        // Use a tool
        myToolBox.UseTool(hammer);
        myToolBox.UseTool(screwdriver);
        // Remove a tool from the toolbox
        myToolBox.RemoveTool(screwdriver);
        // List tools again
        myToolBox.ListTools();
    }
}