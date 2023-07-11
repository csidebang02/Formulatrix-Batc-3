// Membuat kelas EventArg untuk data acara
public class KawasakiMotorEventArgs : EventArgs
{
    public string Model { get; set; }
    public string Problem { get; set; }
    public int Year { get; set; }
    public string Owner { get; set; }

    public KawasakiMotorEventArgs(string model, string problem, int year, string owner)
    {
        Model = model;
        Problem = problem;
        Year = year;
        Owner = owner;
    }
}

// Membuat kelas MotorKawasaki yang melempar acara
public class MotorKawasaki
{
    // Deklarasi delegate untuk event handler
    public delegate void KawasakiMotorEventHandler(object sender, KawasakiMotorEventArgs e);

    // Deklarasi event handler dengan tipe KawasakiMotorEventArgs
    public event KawasakiMotorEventHandler ProblemDetected;

    public void DetectProblem(string model, string problem, int year, string owner)
    {
        Console.WriteLine("Mendeteksi masalah pada motor Kawasaki: {0} - {1}", model, problem);

        // Cek apakah ada handler yang terdaftar
        if (ProblemDetected != null)
        {
            // Membuat objek event argument
            KawasakiMotorEventArgs args = new KawasakiMotorEventArgs(model, problem, year, owner);
            // Memanggil event handler dan melempar event argument
            ProblemDetected(this, args);
        }
    }
}
