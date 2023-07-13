namespace BengkelMotorKawasaki
{
    class Program
    {
        static void Main()
        {
            Motor motor1 = new Motor("Ninja 250", 2021, 50000000);
            Motor motor2 = new Motor("Ninja 250", 2021, 40000000);

            Motor motorTambah = motor1 + motor2;
            Console.WriteLine("Hasil penjumlahan:");
            Console.WriteLine(motorTambah);

            Motor motorKurang = motor1 - motor2;
            Console.WriteLine("Hasil pengurangan:");
            Console.WriteLine(motorKurang);

            // Console.ReadLine();
        }
    }
}
