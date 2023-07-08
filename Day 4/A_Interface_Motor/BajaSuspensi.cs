using C_Interface_Motor;
namespace B_Interface_Motor;

public class BajaSuspensi : ISuspensi
{
	public string suspensiLinkage;
	public BajaSuspensi(string suspensiLinkageInput)
	{
		this.suspensiLinkage = suspensiLinkageInput;
	}
	public void suspensiOn()
	{
		Console.WriteLine("Baja Suspensi On ");
	}
}