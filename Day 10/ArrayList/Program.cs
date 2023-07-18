using System.Collections;

class BengkelMotor
{
    static void Main()
    {
        ArrayList daftarKendaraan = new ArrayList();

        // Menambahkan kendaraan ke daftar
        daftarKendaraan.Add(new Motor("Honda", "CBR250RR"));
        daftarKendaraan.Add(new Motor("Yamaha", "R15"));
        daftarKendaraan.Add(new Motor("Kawasaki", "Ninja 250"));
        daftarKendaraan.Add(new Motor("Suzuki", "GSX-R150"));

        // Menampilkan daftar kendaraan
        Console.WriteLine("Daftar Kendaraan di Bengkel Motor:");
        foreach (object obj in daftarKendaraan)
        {
            if (obj is Motor motor)
            {
                Console.WriteLine("Merk: {0}, Model: {1}", motor.Merk, motor.Model);
            }
        }

        // Menghapus kendaraan dari daftar
        daftarKendaraan.RemoveAt(2);

        // Menampilkan daftar kendaraan setelah penghapusan
        Console.WriteLine("\nDaftar Kendaraan setelah penghapusan:");
        foreach (object obj in daftarKendaraan)
        {
            if (obj is Motor motor)
            {
                Console.WriteLine("Merk: {0}, Model: {1}", motor.Merk, motor.Model);
            }
        }
    }
}

class Motor
{
    public string Merk { get; set; }
    public string Model { get; set; }

    public Motor(string merk, string model)
    {
        Merk = merk;
        Model = model;
    }
}
