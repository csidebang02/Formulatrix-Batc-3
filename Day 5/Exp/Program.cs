using System;

public class Exp1
{
	public int Value { get; set; }

	public void DisplayValue()
	{
		Console.WriteLine("Nilai Exp1: " + Value);
	}
}

public class Exp2
{
	public string Value { get; set; }

	public void DisplayValue()
	{
		Console.WriteLine("Nilai Exp2: " + Value);
	}
}

class Program
{
	static void Main()
	{
		Exp1 obj1 = new Exp1();
		obj1.Value = 10;
		obj1.DisplayValue();

		Exp2 obj2 = new Exp2();
		obj2.Value = "Hello";
		obj2.DisplayValue();

		Console.ReadLine();
	}
}
