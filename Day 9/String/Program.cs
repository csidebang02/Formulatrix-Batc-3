class Program
{
    static List<string> antrian = new List<string>();
    static List<Mobil> daftarMobil = new List<Mobil>();

    static void Main()
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("== Showroom Mobil ==");
            Console.WriteLine("1. Isi Antrian");
            Console.WriteLine("2. Daftar Mobil");
            Console.WriteLine("3. Sisa Antrian");
            Console.WriteLine("4. Keluar");
            Console.WriteLine("====================");
            Console.Write("Pilihan Anda: ");
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    IsiAntrian();
                    break;
                case "2":
                    TampilkanDaftarMobil();
                    break;
                case "3":
                    TampilkanSisaAntrian();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid.");
                    break;
            }

            Console.WriteLine("Tekan Enter untuk melanjutkan...");
            Console.ReadLine();
        }
    }

    static void IsiAntrian()
    {
        Console.Clear();
        Console.WriteLine("== Isi Antrian ==");
        Console.Write("Nama: ");
        string nama = Console.ReadLine();
        Console.Write("Tujuan: ");
        string tujuan = Console.ReadLine();

        string antrianBaru = $"Nama: {nama}, Tujuan: {tujuan}";
        antrian.Add(antrianBaru);

        Console.WriteLine("Antrian berhasil ditambahkan!");
    }

    static void TampilkanDaftarMobil()
    {
        Console.Clear();
        Console.WriteLine("== Daftar Mobil ==");

        if (daftarMobil.Count == 0)
        {
            Console.WriteLine("Belum ada mobil yang terdaftar.");
        }
        else
        {
            foreach (var mobil in daftarMobil)
            {
                Console.WriteLine($"Tipe: {mobil.Tipe}, Tahun: {mobil.Tahun}, Harga: {mobil.Harga:C0}");
            }
        }
    }

    static void TampilkanSisaAntrian()
    {
        Console.Clear();
        Console.WriteLine("== Sisa Antrian ==");

        if (antrian.Count == 0)
        {
            Console.WriteLine("Tidak ada antrian.");
        }
        else
        {
            foreach (var antrianItem in antrian)
            {
                Console.WriteLine(antrianItem);
            }
        }
    }
}

class Mobil
{
    public string Tipe { get; set; }
    public int Tahun { get; set; }
    public int Harga { get; set; }
}