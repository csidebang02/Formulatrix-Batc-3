class Program
{
	static void Main(string[] args)
	{
		Console.Write("Masukkan angka: ");
		int n = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine ("n =" + n);

		for (int i = 0; i <= n; i++)
		{
			if (i == 0)
				Console.WriteLine(i);
			else if(i % 3 == 0 && i % 5 == 0)
				Console.WriteLine("foobar ");
			else if (i % 3 == 0)
				Console.WriteLine("foo ");
			else if (i % 5 == 0)
				Console.WriteLine("bar ");
			else
				Console.WriteLine(i);
		}
		Console.ReadLine();
	}
}
