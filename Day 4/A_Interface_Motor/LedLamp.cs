using C_Interface_Motor;
namespace B_Interface_Motor;

public class LedLamp : ILamp
{
	public string lamp;
	public LedLamp(string lamp)
	{
		this.lamp = lamp;
	}
	public void LedLampOn()
	
	{
		Console.WriteLine("LED Lamp On ");
	}
}