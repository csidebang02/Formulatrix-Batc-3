public class Program
{
    public static void Main()
    {
        Bengkel bengkel = new Bengkel();

        // Mendaftarkan event handler ke acara ProblemDetected pada MotorKawasaki
        bengkel.RegisterHandler();

        // Membuat objek MotorKawasaki
        MotorKawasaki motor = new MotorKawasaki();
        // Memanggil metode DetectProblem untuk menguji acara dengan informasi tahun motor dan pemilik motor
        motor.DetectProblem("Ninja 250Fi", "Mesin tidak mau menyala", 2014, "Christian");

        // Membatalkan pendaftaran event handler dari acara ProblemDetected pada MotorKawasaki
        bengkel.UnregisterHandler();

        // Memanggil metode DetectProblem lagi setelah pendaftaran event handler dibatalkan
        motor.DetectProblem("ZX 14R", "Rem blong", 2023, "Diaz");
    }
}
