using System;

public class Bengkel
{
    public void ServisKendaraan(ref Kendaraan kendaraan)
    {
        Console.WriteLine("Melakukan servis pada {0} {1}", kendaraan.Merk, kendaraan.Tipe);
        // Logika servis kendaraan
        // ...
        kendaraan.Warna = "Merah"; // Mengubah warna kendaraan setelah servis
    }

    public void TampilkanInfoKendaraanByJenis(JenisKendaraan jenis, out Kendaraan[] kendaraanByJenis)
    {
        if (jenis == JenisKendaraan.Motor)
        {
            kendaraanByJenis = new Kendaraan[]
            {
                new Kendaraan { Merk = "Honda", Tipe = "Beat", Tahun = 2020, Warna = "Merah" },
                new Kendaraan { Merk = "Yamaha", Tipe = "NMAX", Tahun = 2021, Warna = "Hitam" }
            };
        }
        else if (jenis == JenisKendaraan.Mobil)
        {
            kendaraanByJenis = new Kendaraan[]
            {
                new Kendaraan { Merk = "Toyota", Tipe = "Avanza", Tahun = 2019, Warna = "Putih" },
                new Kendaraan { Merk = "Honda", Tipe = "CRV", Tahun = 2022, Warna = "Biru" }
            };
        }
        else
        {
            kendaraanByJenis = new Kendaraan[0];
        }
    }

    public void UbahWarnaKendaraan(in Kendaraan kendaraan, string warnaBaru)
    {
        // Anda tidak dapat mengubah kendaraan dalam metode ini karena menggunakan in parameter
        Console.WriteLine("Gagal mengubah warna kendaraan {0} {1} menjadi {2}.", kendaraan.Merk, kendaraan.Tipe, warnaBaru);
    }
}