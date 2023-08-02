using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
	static async Task Main(string[] args)
	{
		CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
		CancellationToken cancellationToken = cancellationTokenSource.Token;

		Console.WriteLine("Press any key to cancel the operation...");
		Task longRunningTask = LongRunningOperationAsync(cancellationToken);

		// Jika ingin mengaktifkan pembatalan setelah beberapa waktu tertentu, Anda dapat menggunakan Task.Delay().
		// Misalnya, untuk membatalkan operasi setelah 5 detik:
		// await Task.Delay(5000);
		// cancellationTokenSource.Cancel();

		Console.ReadKey();

		cancellationTokenSource.Cancel();

		try
		{
			await longRunningTask;
		}
		catch (TaskCanceledException)
		{
			Console.WriteLine("Operation was cancelled.");
		}
	}

	static async Task LongRunningOperationAsync(CancellationToken cancellationToken)
	{
		try
		{
			for (int i = 1; i <= 100; i++)
			{
				cancellationToken.ThrowIfCancellationRequested();

				Console.WriteLine($"Step {i}");
				await Task.Delay(100, cancellationToken);
			}

			Console.WriteLine("Operation completed successfully.");
		}
		catch (TaskCanceledException)
		{
			Console.WriteLine("Operation was cancelled.");
			// Di sini Anda dapat melakukan penanganan lebih lanjut jika operasi Anda memerlukan.
			Console.ReadLine();
		}
	}
}