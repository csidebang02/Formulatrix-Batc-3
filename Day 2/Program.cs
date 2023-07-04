namespace FootballPlayer;
class Program

{
	static void Main()

	{
		Player ronaldo = new Player("Ronaldo", 50, "Stricker", "RM");
		ronaldo.info();
		Player messi = new Player("Messi",49,"Wing","Barca");
		messi.info();
	
		ronaldo.AddScore(10);
		ronaldo.AddScore(5);
		messi.AddScore(15);
		// messi.AddScore(1);
		
		Football laLiga = new Football(messi, ronaldo);
		laLiga.CountScore();	
	}
}