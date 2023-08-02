using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("Main thread started.");

        // Membuat tugas asynchronous
        Task<int> task = Task.Run(() => {
            Console.WriteLine("Task started.");
            Thread.Sleep(100); // Simulasi pekerjaan dalam tugas
            Console.WriteLine("Task completed.");
            return 42;
        });

        Console.WriteLine("Main thread continues to work.");

        // Menunggu tugas selesai dan mendapatkan hasilnya
        int result = await task;

        Console.WriteLine($"Main thread got result: {result}");

        Console.WriteLine("Main thread finished.");
    }
}