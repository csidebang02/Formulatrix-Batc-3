namespace FootballPlayer;
public class Football
{
	string _win;
	Player _player1;
	Player _player2;
	public Football(Player player1, Player player2)
	{
		_player1 = player1;
		_player2 = player2;
	}
	
	public void CountScore()
	{
		if (_player1._score.Equals(_player2._score))
		{
			_win = "Imbang";
		} else if (_player1._score>_player2._score)
		{
			_win = _player1._name;
		} else
		{
			_win = _player2._name;
		}
		Console.WriteLine("winner = "+_win);
	}
}