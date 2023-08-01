// Menerapkan multiple Task secara parallel
using System;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		Task<int> task1 = Task.Run(() =>
		{
			// Tugas pertama
			return 1;
		});

		Task<int> task2 = Task.Run(() =>
		{
			// Tugas kedua
			return 1;
		});

		Task.WhenAll(task1, task2).ContinueWith(tasks =>
		{
			// Setelah kedua task selesai, dijalankan kode berikut ini:
			int hasil1 = task1.Result;
			int hasil2 = task2.Result;
			Console.WriteLine("Hasil Task 1: " + hasil1);
			Console.WriteLine("Hasil Task 2: " + hasil2);
			Console.WriteLine("Hasil Total: " + (hasil1 + hasil2));
		}).Wait();
	}
}
