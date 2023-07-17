public enum Club
{
	Persija,
	PSIS,
	Arema,
	BayangkaraFC,
	Persebaya,
	Persib,
	PSMS
}

public class ClubManager
{
	private List<Club> clubs;

	public ClubManager()
	{
		clubs = new List<Club>
		{
			Club.Persija,
			Club.PSIS,
			Club.Arema,
			Club.BayangkaraFC,
			Club.Persebaya,
			Club.Persib
		};
	}

	public void PrintClubs()
	{
		Console.WriteLine("Daftar klub sepak bola Liga 1 Indonesia:");
		foreach (Club club in clubs)
		{
			Console.WriteLine(club);
		}
	}

	public static ClubManager operator +(ClubManager clubManager, Club newClub)
	{
		clubManager.clubs.Add(newClub);
		return clubManager;
	}
}
