class Program
{
    static void Main()
    {
        Console.Write("Masukkan angka: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("n =" + n);

        string[] arr = new string[n + 1]; // Membuat array dengan ukuran n+1

        for (int i = 0; i <= n; i++)
        {
            if (i == 0)
                arr[i] = i.ToString();
            else if (i % 3 == 0 && i % 5 == 0)
                arr[i] = "foobar";
            else if (i % 3 == 0)
                arr[i] = "foo";
            else if (i % 5 == 0)
                arr[i] = "bar";
            else
                arr[i] = i.ToString();
        }

        string result = string.Join(", ", arr); // Menggabungkan elemen array menjadi satu string dengan pemisah koma

        Console.WriteLine(result);
        // Console.ReadLine();
    }
}
