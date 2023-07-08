using C_Interface_Motor;
namespace B_Interface_Motor;

public class AlumuniumSuspensi : ISuspensi
{
	public string suspensiLinkage;
	public AlumuniumSuspensi(string suspensiLinkage)
	{
		this.suspensiLinkage = suspensiLinkage;
	}
	public void suspensiOn()
	{
		Console.WriteLine("SuspensiOn AlumuniumSuspensi");
	}
}