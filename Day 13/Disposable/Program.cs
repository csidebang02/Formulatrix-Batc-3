public class DisposableResource : IDisposable
{
	private bool disposed = false;
	private IntPtr unmanagedResource;
	
	public DisposableResource()
	
	{
		unmanagedResource = AllocateUnmanagedResource();
		Console.WriteLine("Unmanaged resource allocated");
	}
	private IntPtr AllocateUnmanagedResource()
	
	{
		return IntPtr.Zero;
	}
	
	private void CleanupUnmanagedResource()
	
	{
		Console.WriteLine("Cleaning Up unmanaged resourch...");
	}
	public void Dispose()
	
	{
		Dispose(true);
	}
}