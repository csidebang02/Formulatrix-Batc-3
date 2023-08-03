class program
{
	static void Main()
	{
		string path = @"C:\Users\Batch 3\Desktop\Formulatrix-Batc-3\Formulatrix-Batc-3\Formulatrix-Batc-3\Formulatrix-Batc-3-1\Day 20\AsyncFile";
		Directory.CreateDirectory(path);
		
		if (Directory.Exists(path))
		{
			Console.WriteLine("Directory");
		}
		string filePath  = Path.Combine(path, "example.txt");
		File.WriteAllText(filePath, "Hello, AsyncFile!");
		
		string[] files = Directory.GetFiles(path);
		foreach (string file in files)
		{
			Console.WriteLine(file);
		}
		Directory.Delete(path, true);
	}
}