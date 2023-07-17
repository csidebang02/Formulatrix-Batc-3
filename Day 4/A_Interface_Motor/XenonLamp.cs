using C_Interface_Motor;
namespace B_Interface_Motor;

public class XenonLamp : ILamp
{
	public string lamp;
	public XenonLamp(string lamp) //Konstruktor
	{
		this.lamp = lamp;
	}
	public void LedLampOn()
	
	{
		// Console.WriteLine("Xenon Lamp On ");
		Console.WriteLine("Xenon Lamp On : "+this.lamp);
	}
}