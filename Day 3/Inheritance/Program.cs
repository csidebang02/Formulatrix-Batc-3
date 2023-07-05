using InheritanceFootball;

static class Program 
{
	static void Main() 
	{
		Pelatih pelatih = new Pelatih("k");
		Pemain pemain = new Pemain("n");

		Console.WriteLine(pelatih.myString);
		Console.WriteLine(pemain.myString);
		pelatih.MyMethodPelatih();

		pemain.MyMethodPelatih();
		pemain.MyMethodPemain();
	}
}