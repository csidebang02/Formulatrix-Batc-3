using C_Interface_Motor;
namespace B_Interface_Motor;

public class DinamaoEngine : IEnginestater
{
	public string aki;
	public DinamaoEngine(string aki)
	{
		this.aki = aki;
	}
	public void EngineOn()
	{
		Console.WriteLine("Engine On");
	}
}