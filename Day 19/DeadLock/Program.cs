using System;
using System.Threading;

class Program
{
	static object lockA = new object();
	static object lockB = new object();

	static void Main()
	{
		Thread threadA = new Thread(DoWorkA);
		Thread threadB = new Thread(DoWorkB);

		threadA.Start();
		threadB.Start();

		threadA.Join();
		threadB.Join();

		Console.WriteLine("Main thread finished.");
	}

	static void DoWorkA()
	{
		lock (lockA)
		{
			Console.WriteLine("Thread A: Holding lockA...");
			Thread.Sleep(100);

			Console.WriteLine("Thread A: Waiting for lockB...");
			lock (lockB)
			{
				Console.WriteLine("Thread A: Acquired lockB...");
			}
		}
	}

	static void DoWorkB()
	{
		lock (lockB)
		{
			Console.WriteLine("Thread B: Holding lockB...");

			Thread.Sleep(1000);

			Console.WriteLine("Thread B: Waiting for lockA...");
			lock (lockA)
			{
				Console.WriteLine("Thread B: Acquired lockA...");
			}
		}
	}
}