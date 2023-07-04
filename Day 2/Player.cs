namespace FootballPlayer

{
public class Player

{
	public string _name;
	public int _age;
	public string _position;
	public string _club;
	public int _score;
	
	public Player (string name, int age, string position, string club)
	{
		_name = name;
		_age = age;
		_position = position;
		_club = club;
		_score = 0;
	}
	
	public void info()
	{
		Console.WriteLine("Player name: " +_name+ ", age: "+_age+", Club: "+ _club + " As a "+_position);
	}
	public void SetAge(int age)
	{
		_age = age;
	}
	public int GetAge()
	{
		return _age;
	}
	
	public void SetPosition(string position)
	{
		_position = position;
	}
	
	public string GetPosition()
	{
		return _position;
	}
	
	public void SetClub(string club)
	{
		_club = club;
	}
	public string GetClub()
	{
		return _club;
	}
	
	public void AddScore(int score)
	{
		_score = _score + score;
		Console.WriteLine(_name+" get Additional Score : "+score);
	}

}
}