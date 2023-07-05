class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan angka: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
                Console.Write("foobar ");
            else if ((i + 1) % 3 == 0)
                Console.Write("foo ");
            else if ((i + 1) % 5 == 0)
                Console.Write("bar ");
            else
                Console.Write($"{i + 1} ");
        }
    }
}
