using System;
public class Perbaikan
{
	public void PeriksaMesin(Motor motor)
	{
		Console.WriteLine($"Melayani pemeriksaan Mesin motor {motor.Merk} {motor.Tipe}.");
		Console.WriteLine("Perbaikan Mesin Selesai");
	}
	public void GantiOli(Motor motor)
	{
		Console.WriteLine($"Melayani pergantian Oli motor {motor.Merk} {motor.Tipe}.");
		Console.WriteLine("Penggantian Oli Selesai");
	}
	public void GantiBan(Motor motor)
	{
		Console.WriteLine($"Melayani pergantian Ban motor {motor.Merk} {motor.Tipe}.");
		Console.WriteLine("Penggantian Ban selesai");
	}
}