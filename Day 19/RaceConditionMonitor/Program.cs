using System;
using System.Threading;
using System.Threading.Tasks;

static class Program
{
	static object lockObject = new object();
	static int sharedResource = 0;

	static async Task Main(string[] args)
	{
		Task t1 = IncrementResourceAsync();
		Task t2 = IncrementResourceAsync();

		await Task.WhenAll(t1, t2);

		Console.WriteLine("Final value of sharedResource: " + sharedResource);
		Console.ReadKey();
	}

	static async Task IncrementResourceAsync()
	{
		for (int i = 0; i < 10; i++)
		{
			bool lockTaken = false;			
			try
			{
				Monitor.Enter(lockObject, ref lockTaken);
				sharedResource++;
				Console.WriteLine("Final value of sharedResource: " + sharedResource);
			}
			finally
			
			{
				if(lockTaken)	
				{
					Monitor.Exit(lockObject);
				}
			}
			await Task.Delay(100); // Yield to other tasks
			
		}
	}
}