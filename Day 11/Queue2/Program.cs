using System;

class Program
{
    static void Main()
    {
        Bengkel bengkel = new Bengkel();

        // Menambahkan motor ke dalam antrian
        bengkel.TambahMotorKeAntrian(new Motor("B 1234 AB", "Honda", "Vario"));
        bengkel.TambahMotorKeAntrian(new Motor("B 5678 CD", "Yamaha", "NMAX"));
        bengkel.TambahMotorKeAntrian(new Motor("B 9876 EF", "Suzuki", "Address"));

        // Memproses motor berikutnya dalam antrian
        bengkel.ProsesMotorBerikutnya();

        // Menambahkan motor baru ke dalam antrian
        bengkel.TambahMotorKeAntrian(new Motor("B 4321 BA", "Kawasaki", "Ninja"));

        // Memproses motor berikutnya lagi setelah ditambahkan motor baru
        bengkel.ProsesMotorBerikutnya();
    }
}