using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static SemaphoreSlim semaphore = new SemaphoreSlim(1, 2); // Maksimal 2 task dapat mengakses bersamaan

    static async Task Main()
    {
        var tasks = new Task[5];

        for (int i = 0; i < 5; i++)
        {
            int id = i;
            tasks[i] = Task.Run(() => DoWork(id));
        }

        await Task.WhenAll(tasks);

        Console.ReadKey();
    }

    static async void DoWork(int id)
    {
        Console.WriteLine($"Task {id} trying to enter semaphore.");
        await semaphore.WaitAsync(); // Menunggu izin untuk masuk

        Console.WriteLine($"Task {id} entered semaphore.");

        // Simulasi bekerja
        await Task.Delay(10);

        Console.WriteLine($"Task {id} exit.");
        semaphore.Release(); // Melepaskan semaphore setelah selesai
    }
}