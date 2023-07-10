public class Program
{
    public class Motor
    {
        public string NomorPolisi { get; set; }
        public string JenisMotor { get; set; }

        public Motor(string nomorPolisi, string jenisMotor)
        {
            NomorPolisi = nomorPolisi;
            JenisMotor = jenisMotor;
        }
    }

    public static void Main()
    {
        Motor motor1 = new Motor("B 1234 ABC", "Ninja");
        Motor motor2 = new Motor("B 5678 DEF", "ZSeries");

        DisplayMotorInfo(in motor1);
        DisplayMotorInfo(in motor2);
    }

    public static void DisplayMotorInfo(in Motor motor)
    {
        Console.WriteLine("Nomor Polisi: " + motor.NomorPolisi);
        Console.WriteLine("Jenis Motor: " + motor.JenisMotor);
        Console.WriteLine();
    }
}
