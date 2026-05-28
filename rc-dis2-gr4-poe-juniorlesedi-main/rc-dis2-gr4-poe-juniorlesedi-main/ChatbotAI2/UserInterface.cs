using System;

public class UserInterface
{
    public static void ShowHeader()
    {
        Console.Clear();

        // Top Title
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=======================================");
        Console.WriteLine("   CYBERSECURITY AWARENESS CHATBOT");
        Console.WriteLine("=======================================");
        Console.ResetColor();

        // ASCII Logo
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(@"
  ╔══════════════════════════════════════════════════════════════════════╗
  ║                                                                      ║
  ║   ██████╗██╗   ██╗██████╗ ███████╗██████╗      ██████╗ ██╗   ██╗      ║
  ║  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗    ██╔════╝ ██║   ██║      ║
  ║  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝    ██║  ███╗██║   ██║      ║
  ║  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗    ██║   ██║██║   ██║      ║
  ║  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║    ╚██████╔╝╚██████╔╝      ║
  ║   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝     ╚═════╝  ╚═════╝       ║
  ║                                                                      ║
  ║        🔐 CYBERGUARD – Cybersecurity Awareness Assistant             ║
  ║                                                                      ║
  ╚══════════════════════════════════════════════════════════════════════╝
");

        Console.ResetColor();

        // Footer line
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("---------------------------------------");
        Console.ResetColor();
        Console.WriteLine();
    }
}