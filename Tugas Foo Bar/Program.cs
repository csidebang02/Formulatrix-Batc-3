using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Masukkan angka: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("n = " + n);

        Console.Write("Masukkan aturan (contoh: 3 = foo, 5 = bar): ");
        string ruleInput = Console.ReadLine();

        Dictionary<int, string> rules = ParseRules(ruleInput);

        FooBarGenerator generator = new FooBarGenerator(rules);
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
                        AddCondition(rules);
                        break;
                    case 2:
                        RemoveCondition(rules);
                        break;
                    case 3:
                        ListAllCondition(rules);
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

    static Dictionary<int, string> ParseRules(string input)
    {
        Dictionary<int, string> rules = new Dictionary<int, string>();

        string[] rulePairs = input.Split(',');

        foreach (string rulePair in rulePairs)
        {
            string[] parts = rulePair.Trim().Split('=');

            if (parts.Length == 2)
            {
                int number = Convert.ToInt32(parts[0].Trim());
                string keyword = parts[1].Trim();
                rules.Add(number, keyword);
            }
        }

        return rules;
    }

    static void AddCondition(Dictionary<int, string> rules)
    {
        Console.Write("Masukkan angka baru: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Masukkan kata kunci baru: ");
        string keyword = Console.ReadLine();

        rules[number] = keyword;

        Console.WriteLine("Kondisi berhasil ditambahkan.");
    }

    static void RemoveCondition(Dictionary<int, string> rules)
    {
        Console.Write("Masukkan angka yang akan dihapus kondisinya: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (rules.Remove(number))
        {
            Console.WriteLine("Kondisi berhasil dihapus.");
        }
        else
        {
            Console.WriteLine("Angka tidak ditemukan dalam kondisi.");
        }
    }

    static void ListAllCondition(Dictionary<int, string> rules)
    {
        Console.WriteLine("Daftar Kondisi:");

        foreach (KeyValuePair<int, string> rule in rules)
        {
            Console.WriteLine($"{rule.Key} = {rule.Value}");
        }
    }

    static void CheckSingleNumber(FooBarGenerator generator)
    {
        Console.Write("Masukkan angka yang akan diperiksa: ");
        int number = Convert.ToInt32(Console.ReadLine());

        string keyword = generator.CheckNumber(number);

        Console.WriteLine($"Kata kunci untuk angka {number}: {keyword}");
    }
}