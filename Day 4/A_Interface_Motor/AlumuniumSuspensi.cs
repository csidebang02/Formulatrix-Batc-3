using C_Interface_Motor;
namespace B_Interface_Motor;

public class AlumuniumSuspensi : ISuspensi
{
	public string suspensiLinkage;
	public AlumuniumSuspensi(string suspensiLinkageInput)
	{
		this.suspensiLinkage = suspensiLinkageInput;
		//SuspensiLinkage dari objek
	}
	public void suspensiOn()
	{
		Console.WriteLine("SuspensiOn AlumuniumSuspensi:"+this.suspensiLinkage);
	}
}