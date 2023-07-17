class Program
{
	static void Main()
	{
		ClubManager clubManager = new ClubManager();
		clubManager.PrintClubs();

		Console.WriteLine("\nMenambahkan klub baru...");
		clubManager += Club.PSMS;
		clubManager.PrintClubs();
		int a = 10;
		int b = 20;
		a = a + b;
		Console.WriteLine ("nilai a sum manual"+a);
		a += b;
		Console.WriteLine("nilai a sum Auto"+a);
		
	}
}
