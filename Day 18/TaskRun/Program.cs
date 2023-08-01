//Task.Run dengan async/await
using System;
using System.Threading.Tasks;

class Program
{
	static async Task Main()
	{
		// Menjalankan metode dalam bentuk Task.Run dengan async/await
		int hasil = await Task.Run(() => LongRunningOperation());

		Console.WriteLine("Hasil: " + hasil);
	}

	static int LongRunningOperation()
	{
		Console.WriteLine("Operasi berjalan dalam thread: " + System.Threading.Thread.CurrentThread.ManagedThreadId);
		Task.Delay(2000).Wait(); // Simulasi operasi yang memerlukan waktu
		return 42;
	}
}