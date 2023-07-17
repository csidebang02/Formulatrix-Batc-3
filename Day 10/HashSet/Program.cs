using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> motorKawasaki = new HashSet<string>();

        // Menambahkan data ke HashSet
        motorKawasaki.Add("Ninja ZX-6R");
        motorKawasaki.Add("Ninja ZX-10R");
        motorKawasaki.Add("Ninja H2");
        motorKawasaki.Add("Z900");
        motorKawasaki.Add("Versys 650");
        motorKawasaki.Add("Vulcan S");

        // Menampilkan semua motor Kawasaki
        Console.WriteLine("Daftar Motor Kawasaki:");
        foreach (var motor in motorKawasaki)
        {
            Console.WriteLine(motor);
        }

        // Menghapus motor dari HashSet
        string motorHapus = "Vulcan S";
        if (motorKawasaki.Contains(motorHapus))
        {
            motorKawasaki.Remove(motorHapus);
            Console.WriteLine($"\nMotor {motorHapus} berhasil dihapus.");
        }
        else
        {
            Console.WriteLine($"\nMotor {motorHapus} tidak terdaftar dalam HashSet. Tidak ada perubahan yang dilakukan.");
        }

        Console.WriteLine("\nSetelah menghapus motor:");
        foreach (var motor in motorKawasaki)
        {
            Console.WriteLine(motor);
        }
    }
}