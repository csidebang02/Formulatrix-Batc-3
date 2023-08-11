using System;
class program
{
	static void Main()
	{
		Console.WriteLine("Ini adalah Pesan Info");
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Ini adalah pesan error");
		Console.ResetColor();
		
		#if DEBUG
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("Ini adalah pesan debug");
		Console.ResetColor();
		#endif
		
		Console.ReadLine();
	}
}