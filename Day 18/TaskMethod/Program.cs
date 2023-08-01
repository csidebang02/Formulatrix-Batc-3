using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Membuat task dengan menggunakan Task.Run
        Task task = Task.Run(() =>
        {
            // Kode yang ingin dijalankan dalam task
            Console.WriteLine("Task berjalan di thread: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000); // Simulasi tugas yang memerlukan waktu 2 detik
            Console.WriteLine("Task selesai di thread: " + Thread.CurrentThread.ManagedThreadId);
        });

        // Kode yang tetap berjalan di thread utama
        Console.WriteLine("Kode di thread utama berjalan di thread: " + Thread.CurrentThread.ManagedThreadId);

        // Menunggu task selesai sebelum melanjutkan eksekusi program
        task.Wait();

        Console.WriteLine("Program selesai.");
    }
}