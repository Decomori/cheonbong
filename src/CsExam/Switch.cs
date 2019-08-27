string commandName = "start";

switch (commandName)
{
    case "start":
        Console.WriteLine("Starting service...");
        StartService();
        break;
    case "stop":
        Console.WriteLine("Stopping service...");
        StopService();
        break;
    default:
        Console.WriteLine(String.Format("Unknown command: {0}", commandName));
        break;
}