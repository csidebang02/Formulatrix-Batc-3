using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Mulai program");

        // Panggil metode yang bersifat asinkron
        await DoSomethingAsync();

        Console.WriteLine("Selesai program");
    }

    static async Task DoSomethingAsync()
    {
        Console.WriteLine("Memulai operasi asinkron");

        // Jeda simulasi untuk menunjukkan operasi yang memakan waktu
        await Task.Delay(2000); // Menunggu selama 2 detik (2000 milidetik)

        Console.WriteLine("Operasi asinkron selesai");
    }
}
