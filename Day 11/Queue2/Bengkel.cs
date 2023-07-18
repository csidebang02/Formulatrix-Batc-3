public class Bengkel
{
    public AntrianMotor AntrianMotor { get; private set; }

    public Bengkel()
    {
        AntrianMotor = new AntrianMotor();
    }

    public void TambahMotorKeAntrian(Motor motor)
    {
        AntrianMotor.TambahMotor(motor);
    }

    public void ProsesMotorBerikutnya()
    {
        Motor motorBerikutnya = AntrianMotor.AmbilMotorDariDepan();
        if (motorBerikutnya != null)
        {
            Console.WriteLine("Motor berikutnya yang akan diproses:");
            Console.WriteLine(motorBerikutnya);
        }
        else
        {
            Console.WriteLine("Tidak ada motor dalam antrian.");
        }
    }
}