﻿// See https://aka.ms/new-console-template for more information
class Program

{
	static int myInt = 2;
	static string myString = "Hallo";
	
	static void Main()
	{
		Console.WriteLine(myInt);
		Message();
	}
	static void Message()
	{
		Console.WriteLine(myString);
	}
}