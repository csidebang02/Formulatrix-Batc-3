namespace GetSetKawasaki
{
	public class Motorcycle
	{
		public string Brand;
		public string Tipe { get; set; }
		public int Year { get; set; }
		public int Pric { get; set; }

		public Motorcycle(string brand, string tipe, int year, int pric)
		{
			Brand = brand;
			Tipe = tipe;
			Year = year;
			Pric = pric;
		}

		public void Start()
		{
			Console.WriteLine($"Starting the {Brand} {Tipe}...");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Motorcycle myMotorcycle = new Motorcycle("Kawasaki", "Ninja", 2014, 79000000);

			Console.WriteLine($"My motorcycle is a {myMotorcycle.Year} {myMotorcycle.Brand} {myMotorcycle.Tipe} in {myMotorcycle.Pric} pric.");
			myMotorcycle.Start();
		}
	}
}