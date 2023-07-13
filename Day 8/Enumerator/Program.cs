public enum Club
{
    Persija,
    PSIS,
    Arema,
    BayangkaraFC,
    PSMS,
    Persib
}

class Program
{
    static void Main()
    {
        List<Club> clubs = new List<Club>
        {
            Club.Persija,
            Club.PSIS,
            Club.Arema,
            Club.BayangkaraFC,
            Club.PSMS,
            Club.Persib
        };

        Console.WriteLine("Daftar klub sepak bola Indonesia:");
        foreach (Club club in clubs)
        {
            Console.WriteLine(club);
        }
    }
}
// class Program
// {
//     static void Main()
//     {
//         ClubManager clubManager = new ClubManager();
//         clubManager.PrintClubs();
//     }
// }