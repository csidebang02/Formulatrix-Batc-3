// Membuat kelas penerima acara
public class Bengkel
{
    private MotorKawasaki motor;

    public Bengkel()
    {
        // Membuat objek MotorKawasaki
        motor = new MotorKawasaki();
    }

    public void RegisterHandler()
    {
        // Mendaftarkan event handler ke acara ProblemDetected pada MotorKawasaki
        motor.ProblemDetected += HandleProblem;
    }

    public void UnregisterHandler()
    {
        // Membatalkan pendaftaran event handler dari acara ProblemDetected pada MotorKawasaki
        motor.ProblemDetected -= HandleProblem;
    }

    // Metode event handler untuk menangani acara
    public void HandleProblem(object sender, KawasakiMotorEventArgs e)
    {
        Console.WriteLine("Bengkel menerima masalah pada motor Kawasaki:");
        Console.WriteLine("Model: {0}", e.Model);
        Console.WriteLine("Problem: {0}", e.Problem);
        Console.WriteLine("Year: {0}", e.Year);
        Console.WriteLine("Owner: {0}", e.Owner);
        Console.WriteLine("Menangani masalah...");
    }
}
