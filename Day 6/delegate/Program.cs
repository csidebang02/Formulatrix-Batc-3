// Definisikan delegasi untuk menghandle pekerjaan pada motor
delegate void MotorDelegate(string motor);

class BengkelMotor
{
    public void PeriksaMotor(string motor)
    {
        Console.WriteLine("Memeriksa motor: " + motor);
    }

    public void GantiOli(string motor)
    {
        Console.WriteLine("Mengganti oli motor: " + motor);
    }

    public void TuneUpMotor(string motor)
    {
        Console.WriteLine("Melakukan tune-up pada motor: " + motor);
    }
}

class Program
{
    static void Main()
    {
        BengkelMotor bengkel = new BengkelMotor();

        // Buat instance dari delegasi MotorDelegate
        MotorDelegate pekerjaanMotor = null;

        // Tambahkan metode-metode bengkel ke delegasi
        pekerjaanMotor += bengkel.PeriksaMotor;
        pekerjaanMotor += bengkel.GantiOli;
        pekerjaanMotor += bengkel.TuneUpMotor;

        // Panggil delegasi untuk menjalankan semua metode yang terhubung
        pekerjaanMotor("Kawasaki Ninja");

        Console.ReadLine();
    }
}
