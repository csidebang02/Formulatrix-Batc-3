using System;

public class Program
{
    static void Main()
    {
        Bengkel bengkel = new Bengkel();

        // Servis Kendaraan dengan menggunakan ref parameter
        Kendaraan motor = new Kendaraan { Merk = "Honda", Tipe = "CBR150R", Tahun = 2021, Warna = "Hitam" };
        Console.WriteLine("Warna motor sebelum servis: {0}", motor.Warna);

        bengkel.ServisKendaraan(ref motor);

        Console.WriteLine("Warna motor setelah servis: {0}", motor.Warna);

        // Menampilkan Info Kendaraan dengan menggunakan out parameter
        JenisKendaraan jenisKendaraan = JenisKendaraan.Motor;
        Kendaraan[] kendaraanByJenis;
        bengkel.TampilkanInfoKendaraanByJenis(jenisKendaraan, out kendaraanByJenis);

        Console.WriteLine("\nDaftar kendaraan {0}:", jenisKendaraan);
        foreach (Kendaraan kendaraan in kendaraanByJenis)
        {
            Console.WriteLine("{0} {1}, Tahun: {2}, Warna: {3}", kendaraan.Merk, kendaraan.Tipe, kendaraan.Tahun, kendaraan.Warna);
        }

        // Mengubah Warna Kendaraan dengan menggunakan in parameter
        Kendaraan mobil = new Kendaraan { Merk = "Toyota", Tipe = "Avanza", Tahun = 2018, Warna = "Silver" };
        Console.WriteLine("\nWarna mobil sebelum diubah: {0}", mobil.Warna);

        string warnaBaru = "Merah";
        bengkel.UbahWarnaKendaraan(in mobil, warnaBaru);
    }
}