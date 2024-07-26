// See https://aka.ms/new-console-template for more information
using HeavenlyScents.InventoryManagement;

PrintWelcome();

Utilities.InitializeStock();

Utilities.ShowMainMenu();

Console.WriteLine("Application shutting down...");

Console.ReadLine();

#region Layout

static void PrintWelcome()
{

    Console.ForegroundColor = ConsoleColor.Yellow;

    Console.ResetColor();

    Console.WriteLine("Press enter key to start logging in!");

    //accepting enter here
    Console.ReadLine();

    Console.Clear();
}
#endregion
