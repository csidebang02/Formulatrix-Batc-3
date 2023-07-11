class Program
{
    static void Main()
    {
        Console.Write("Masukkan angka: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("n = " + n);

        FooBarGenerator generator = new FooBarGenerator();
        string result = generator.GenerateFooBar(n);

        Console.WriteLine(result);
        //Console.ReadLine();
    }
}
