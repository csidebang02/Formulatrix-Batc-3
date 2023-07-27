class Program
{
    static void Main()
    {
        Console.Write("Masukkan angka: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("n = " + n);

        FooBarGenerator generator = new FooBarGenerator();

        Console.Write("Masukkan aturan (contoh: 3 = foo, 5 = bar): ");
        string ruleInput = Console.ReadLine();

        ParseRules(generator, ruleInput);

        string result = generator.GenerateFooBar(n);
        Console.WriteLine(result);

        Console.WriteLine("Pilih aksi:");
        Console.WriteLine("1. Tambah Kondisi");
        Console.WriteLine("2. Hapus Kondisi");
        Console.WriteLine("3. Daftar Semua Kondisi");
        Console.WriteLine("4. Periksa Angka Tunggal");
        Console.WriteLine("0. Keluar");

        int choice;
        while (true)
        {
            Console.Write("Pilihan Anda: ");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        AddCondition(generator);
                        result = generator.GenerateFooBar(n);
                        Console.WriteLine(result);
                        break;
                    case 2:
                        RemoveCondition(generator);
                        result = generator.GenerateFooBar(n);
                        Console.WriteLine(result);
                        break;
                    case 3:
                        ListAllCondition(generator);
                        break;
                    case 4:
                        CheckSingleNumber(generator);
                        break;
                    case 0:
                        Console.WriteLine("Terima kasih! Sampai jumpa!");
                        return;
                    default:
                        Console.WriteLine("Pilihan tidak valid. Silakan pilih kembali.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Input tidak valid. Silakan pilih kembali.");
            }
        }
    }

    static void ParseRules(FooBarGenerator generator, string input)
    {
        string[] rulePairs = input.Split(',');

        foreach (string rulePair in rulePairs)
        {
            string[] parts = rulePair.Trim().Split('=');

            if (parts.Length == 2)
            {
                int number = Convert.ToInt32(parts[0].Trim());
                string keyword = parts[1].Trim();
                generator.AddCondition(number, keyword);
            }
        }
    }

    static void AddCondition(FooBarGenerator generator)
    {
        Console.Write("Masukkan angka baru: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan kata kunci baru: ");
        string keyword = Console.ReadLine();

        generator.AddCondition(number, keyword);

        Console.WriteLine("Kondisi berhasil ditambahkan.");
    }

    static void RemoveCondition(FooBarGenerator generator)
    {
        Console.Write("Masukkan angka yang akan dihapus kondisinya: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (generator.RemoveCondition(number))
        {
            Console.WriteLine("Kondisi berhasil dihapus.");
        }
        else
        {
            Console.WriteLine("Angka tidak ditemukan dalam kondisi.");
        }
    }

    static void ListAllCondition(FooBarGenerator generator)
    {
        Console.WriteLine("Daftar Kondisi:");
        List<string> conditionsList = generator.ListAllConditions();
        foreach (string condition in conditionsList)
        {
            Console.WriteLine(condition);
        }
    }

    static void CheckSingleNumber(FooBarGenerator generator)
    {
        Console.Write("Masukkan angka yang akan diperiksa: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string keyword = generator.CheckSingleNumber(number);

        Console.WriteLine($"Kata kunci untuk angka {number}: {keyword}");
    }
}