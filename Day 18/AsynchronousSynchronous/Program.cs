using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Mulai");

        // Panggil metode synchronous
        DoSomethingSynchronous();

        // Panggil metode asynchronous dengan kata kunci "await"
        await DoSomethingAsynchronous();

        Console.WriteLine("Selesai");
    }

    static void DoSomethingSynchronous()
    {
        // Menunggu selama 3 detik (simulasi pekerjaan yang berat)
        Thread.Sleep(3000);

        Console.WriteLine("Tugas synchronous selesai");
    }

    static async Task DoSomethingAsynchronous()
    {
        // Menunggu selama 3 detik dengan Task.Delay (simulasi pekerjaan yang berat)
        await Task.Delay(3000);

        Console.WriteLine("Tugas asynchronous selesai");
    }
}