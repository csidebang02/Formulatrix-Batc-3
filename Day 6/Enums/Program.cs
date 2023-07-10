public class Program
{
	// Enum untuk jenis-jenis motor Kawasaki
	public enum KawasakiMotor
	{
		Ninja,
		ZSeries,
		Versys,
		Vulcan
	}

	// Enum untuk status perbaikan motor
	public enum RepairStatus
	{
		BelumDiperiksa,
		DalamPerbaikan,
		SelesaiDiperbaiki
	}

	// Class untuk merepresentasikan motor di bengkel
	public class Motor
	{
		public string NomorPolisi { get; set; }
		public KawasakiMotor JenisMotor { get; set; }
		public RepairStatus StatusPerbaikan { get; set; }
	}

	public static void Main()
	{
		// Membuat objek motor
		Motor motor1 = new Motor
		{
			NomorPolisi = "B 1234 ABC",
			JenisMotor = KawasakiMotor.Ninja,
			StatusPerbaikan = RepairStatus.DalamPerbaikan
		};

		Motor motor2 = new Motor
		{
			NomorPolisi = "B 5678 DEF",
			JenisMotor = KawasakiMotor.ZSeries,
			StatusPerbaikan = RepairStatus.SelesaiDiperbaiki
		};

		// Menampilkan informasi motor
		Console.WriteLine("Motor 1:");
		Console.WriteLine("Nomor Polisi: " + motor1.NomorPolisi);
		Console.WriteLine("Jenis Motor: " + motor1.JenisMotor);
		Console.WriteLine("Status Perbaikan: " + motor1.StatusPerbaikan);
		Console.WriteLine();

		Console.WriteLine("Motor 2:");
		Console.WriteLine("Nomor Polisi: " + motor2.NomorPolisi);
		Console.WriteLine("Jenis Motor: " + motor2.JenisMotor);
		Console.WriteLine("Status Perbaikan: " + motor2.StatusPerbaikan);
		Console.WriteLine();
	}
}
