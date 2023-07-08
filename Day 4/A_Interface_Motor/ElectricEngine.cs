using C_Interface_Motor;
namespace B_Interface_Motor;

public class ElectricEngine : IEnginestater
{
	public string aki;
	public ElectricEngine(string aki)
	{
		this.aki = aki;
	}
	public void EngineOn()
	{
		Console.WriteLine("Engine On");
	}
}