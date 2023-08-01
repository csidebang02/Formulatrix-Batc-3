//Mengembalikan nilai dari Task
using System;
using System.Threading.Tasks;

class Program
{
    static async Task<int> HitungJumlahAsync(int a, int b)
    {
        await Task.Delay(1000); // Simulasi tugas asynchronous
        return a + b;
    }

    static async Task Main()
    {
        int hasil = await HitungJumlahAsync(5, 10);
        Console.WriteLine("Hasil: " + hasil);
    }
}