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
        Motor motor1;
        bool success1 = CreateMotor("B 1234 ABC", "Ninja", out motor1);
        if (success1)
        {
            Console.WriteLine("Motor 1:");
            Console.WriteLine("Nomor Polisi: " + motor1.NomorPolisi);
            Console.WriteLine("Jenis Motor: " + motor1.JenisMotor);
            Console.WriteLine();
        }

        Motor motor2;
        bool success2 = CreateMotor("B 5678 DEF", "ZSeries", out motor2);
        if (success2)
        {
            Console.WriteLine("Motor 2:");
            Console.WriteLine("Nomor Polisi: " + motor2.NomorPolisi);
            Console.WriteLine("Jenis Motor: " + motor2.JenisMotor);
            Console.WriteLine();
        }
    }

    public static bool CreateMotor(string nomorPolisi, string jenisMotor, out Motor motor)
    {
        // Contoh implementasi sederhana
        if (!string.IsNullOrEmpty(nomorPolisi))
        {
            motor = new Motor(nomorPolisi, jenisMotor);
            return true;
        }

        motor = null;
        return false;
    }
}
