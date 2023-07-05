namespace FootballPlayer;
class Program

{
	static void Main()

	{
		Player ronaldo = new Player("Ronaldo", 38, "Centre Forward", "Portugal");
		ronaldo.info();
		Player messi = new Player("Messi",36,"Right Winger","Argentina");
		messi.info();
	
		ronaldo.AddScore(10);
		ronaldo.AddScore(5);
		messi.AddScore(15);
		// messi.AddScore(1);
		
		Football laLiga = new Football(messi, ronaldo);
		laLiga.CountScore();	
	}
}