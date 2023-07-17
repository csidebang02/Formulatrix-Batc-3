using B_Interface_Motor;
class Program
{
	static void Main()
	
	{
		BajaSuspensi motorSuspensi = new BajaSuspensi("YSS");
		DinamaoEngine motorEngine = new DinamaoEngine("Kawasaki");
		LedLamp motorLamp = new LedLamp("Rayton");
		
		AlumuniumSuspensi alumuniumSuspensi = new AlumuniumSuspensi("Baja");
		XenonLamp xenonLamp = new XenonLamp("Pillips");
		ElectricEngine electricEngine = new ElectricEngine("");
		
		Motor motor = new Motor(electricEngine, xenonLamp, alumuniumSuspensi);
		Motor motor1 = new Motor(motorEngine, motorLamp, motorSuspensi);
		
		motor.onMotor();
		motor1.onMotor();
	}
}