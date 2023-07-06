using C_Interface_Motor;
namespace B_Interface_Motor;

public class Motor
{
	public IEnginestater enginestater;
	public ILamp lamp;
	public ISuspensi suspensi;
	
	public Motor(IEnginestater enginestater, ILamp lamp, ISuspensi suspensi)
	{
		this.enginestater = enginestater;
		this.lamp = lamp;
		this.suspensi = suspensi;
	}
}