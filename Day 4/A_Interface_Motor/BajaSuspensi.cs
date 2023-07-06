using C_Interface_Motor;
namespace B_Interface_Motor;

public class BajaSuspensi : ISuspensi
{
	public string suspensiLinkage;
	public BajaSuspensi(string suspensiLinkage)
	{
		this.suspensiLinkage = suspensiLinkage;
	}
	public void suspensiOn()
	{
		Console.WriteLine("Suspensi On");
	}
}