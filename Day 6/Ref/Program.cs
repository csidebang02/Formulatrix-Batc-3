public class Program
{
    public class FootballPlayer
    {
        public string Name { get; set; }
        public int GoalsScored { get; set; }

        public FootballPlayer(string name, int goalsScored)
        {
            Name = name;
            GoalsScored = goalsScored;
        }
    }

    public static void Main()
    {
        FootballPlayer player1 = new FootballPlayer("Cristiano Ronaldo", 0);
        Console.WriteLine("Initial goals scored by " + player1.Name + ": " + player1.GoalsScored);

        IncreaseGoals(ref player1, 3);
        Console.WriteLine("Goals scored by " + player1.Name + " after increasing: " + player1.GoalsScored);
    }

    public static void IncreaseGoals(ref FootballPlayer player, int goals)
    {
        player.GoalsScored += goals;
    }
}
