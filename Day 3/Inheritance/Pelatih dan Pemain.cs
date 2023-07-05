namespace InheritanceFootball;
class Pelatih
{
	public string? myString;
	public Pelatih(string myString)
	{
		myString = "Pelatih";
	}
		public Pelatih()
	{
		myString = "Pelatih";
	}
	public void MyMethodPelatih()
	{
		Console.WriteLine("Pelatih.MyMethodPelatih");
	}
}

class Pemain : Pelatih
{
	public string? myStringx;
	public Pemain(string y) : base(y)
	{
		myString = y;
	}
	public void MyMethodPemain()
	{
		Console.WriteLine("Pemain.MyMethodPemain");
	}
}

