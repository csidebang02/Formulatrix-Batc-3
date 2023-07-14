using System;
using System.Collections.Generic;

class Program
{
    static List<string> kondisiMotor = new List<string>();
    static List<string> motorBaruMasuk = new List<string>();

    static void Main(string[] args)
    {
        DateTime tanggalTerima = new DateTime(2023, 7, 14, 9, 0, 0); // Contoh tanggal terima di bengkel
        DateTime tanggalPerkiraanSelesai = tanggalTerima.AddDays(3).AddHours(6); // Tanggal perkiraan selesai adalah 3 hari dan 6 jam setelah tanggal terima
        DateTime tanggalSelesai = new DateTime(2023, 7, 17, 15, 30, 0); // Contoh tanggal selesai di bengkel

        // Menambahkan beberapa kondisi motor
        AddCondition("Ganti oli");
        AddCondition("Perbaikan rem");

        // Mengecek kondisi motor
        CheckMotorCondition("Perbaikan rem");

        // Mengecek harga perbaikan
        CheckRepairPrice("Ganti oli");

        TimeSpan durasiPengerjaan = tanggalSelesai - tanggalTerima;
        TimeSpan durasiPerkiraan = tanggalPerkiraanSelesai - tanggalTerima;

        Console.WriteLine("Durasi pengerjaan: " + durasiPengerjaan.Days + " hari, " +
                                              durasiPengerjaan.Hours + " jam, " +
                                              durasiPengerjaan.Minutes + " menit.");
        
        Console.WriteLine("Durasi perkiraan: " + durasiPerkiraan.Days + " hari, " +
                                              durasiPerkiraan.Hours + " jam.");

        if (tanggalSelesai > tanggalPerkiraanSelesai)
        {
            TimeSpan durasiTerlambat = tanggalSelesai - tanggalPerkiraanSelesai;
            Console.WriteLine("Terlambat: " + durasiTerlambat.Days + " hari, " +
                                                durasiTerlambat.Hours + " jam, " +
                                                durasiTerlambat.Minutes + " menit.");
        }
        else
        {
            Console.WriteLine("Tidak terlambat.");
        }

        // Menambahkan motor baru yang masuk
        AddNewMotor("Kawasaki Ninja 250");

        Console.ReadLine();
    }

    static void AddCondition(string kondisi)
    {
        kondisiMotor.Add(kondisi);
        Console.WriteLine("Kondisi \"" + kondisi + "\" telah ditambahkan.");
    }

    static void RemoveCondition(string kondisi)
    {
        if (kondisiMotor.Contains(kondisi))
        {
            kondisiMotor.Remove(kondisi);
            Console.WriteLine("Kondisi \"" + kondisi + "\" telah dihapus.");
        }
        else
        {
            Console.WriteLine("Kondisi \"" + kondisi + "\" tidak ditemukan.");
        }
    }

    static void ListAllConditions()
    {
        Console.WriteLine("Daftar semua kondisi motor:");
        foreach (string kondisi in kondisiMotor)
        {
            Console.WriteLine("- " + kondisi);
        }
    }

    static void CheckMotorCondition(string kondisi)
    {
        if (kondisiMotor.Contains(kondisi))
        {
            Console.WriteLine("Motor memiliki kondisi \"" + kondisi + "\".");
        }
        else
        {
            Console.WriteLine("Motor tidak memiliki kondisi \"" + kondisi + "\".");
        }
    }

    static void CheckRepairPrice(string kondisi)
    {
        int hargaPerbaikan = 0;

        if (kondisiMotor.Contains(kondisi))
        {
            if (kondisi == "Ganti oli")
            {
                hargaPerbaikan = 100000; // Contoh harga perbaikan ganti oli
            }
            else if (kondisi == "Perbaikan rem")
            {
                hargaPerbaikan = 500000; // Contoh harga perbaikan perbaikan rem
            }

            Console.WriteLine("Harga perbaikan untuk kondisi \"" + kondisi + "\": Rp" + hargaPerbaikan);
        }
        else
        {
            Console.WriteLine("Motor tidak memiliki kondisi \"" + kondisi + "\".");
        }
    }

    static void AddNewMotor(string motor)
    {
        motorBaruMasuk.Add(motor);
        Console.WriteLine("Motor \"" + motor + "\" telah ditambahkan sebagai motor baru yang masuk.");
    }
}