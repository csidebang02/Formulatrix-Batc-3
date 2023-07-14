class ClubSepakBola
{
    public string Nama { get; set; }
    public string Kota { get; set; }
    public int JumlahPemain { get; set; }
    public List<string> NamaPemain { get; set; }
    public Dictionary<string, int> StatistikKejuaraan { get; set; }

    public ClubSepakBola(string nama, string kota, int jumlahPemain)
    {
        Nama = nama;
        Kota = kota;
        JumlahPemain = jumlahPemain;
        NamaPemain = new List<string>();
        StatistikKejuaraan = new Dictionary<string, int>();
    }

    public void TambahPemain(string namaPemain)
    {
        NamaPemain.Add(namaPemain);
    }

    public void TambahKejuaraan(string namaKejuaraan, int jumlahGol)
    {
        if (StatistikKejuaraan.ContainsKey(namaKejuaraan))
            StatistikKejuaraan[namaKejuaraan] += jumlahGol;
        else
            StatistikKejuaraan[namaKejuaraan] = jumlahGol;
    }

    public static bool operator ==(ClubSepakBola club1, ClubSepakBola club2)
    {
        if (ReferenceEquals(club1, club2))
            return true;

        if (ReferenceEquals(club1, null) || ReferenceEquals(club2, null))
            return false;

        return club1.Nama == club2.Nama && club1.Kota == club2.Kota && club1.JumlahPemain == club2.JumlahPemain;
    }

    public static bool operator !=(ClubSepakBola club1, ClubSepakBola club2)
    {
        return !(club1 == club2);
    }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        ClubSepakBola other = (ClubSepakBola)obj;
        return this == other;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Nama, Kota, JumlahPemain);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ClubSepakBola club1 = new ClubSepakBola("Real Madrid", "Madrid", 25);
        club1.TambahPemain("Cristiano Ronaldo");
        club1.TambahPemain("Sergio Ramos");
        club1.TambahKejuaraan("La Liga", 3);
        club1.TambahKejuaraan("Liga Champions", 4);

        ClubSepakBola club2 = new ClubSepakBola("Barcelona", "Barcelona", 25);
        club2.TambahPemain("Lionel Messi");
        club2.TambahPemain("Gerard Pique");
        club2.TambahKejuaraan("La Liga", 5);
        club2.TambahKejuaraan("Liga Champions", 3);

        int pilihan;
        do
        {
            Console.WriteLine("Menu Pilihan:");
            Console.WriteLine("1. Info Club");
            Console.WriteLine("2. Nama-Nama Pemain");
            Console.WriteLine("3. Statistik Kejuaraan");
            Console.WriteLine("0. Keluar");
            Console.Write("Masukkan pilihan Anda: ");
            pilihan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (pilihan)
            {
                case 1:
                    Console.WriteLine("Info Club:");
                    Console.WriteLine("Nama Club: " + club1.Nama);
                    Console.WriteLine("Kota: " + club1.Kota);
                    Console.WriteLine("Jumlah Pemain: " + club1.JumlahPemain);
                    Console.WriteLine();
                    break;

                case 2:
                    Console.WriteLine("Nama-Nama Pemain:");
                    foreach (string namaPemain in club1.NamaPemain)
                    {
                        Console.WriteLine(namaPemain);
                    }
                    Console.WriteLine();
                    break;

                case 3:
                    Console.WriteLine("Statistik Kejuaraan:");
                    foreach (KeyValuePair<string, int> kejuaraan in club1.StatistikKejuaraan)
                    {
                        Console.WriteLine("Kejuaraan: " + kejuaraan.Key + ", Jumlah Gol: " + kejuaraan.Value);
                    }
                    Console.WriteLine();
                    break;

                case 0:
                    Console.WriteLine("Terima kasih. Program berakhir.");
                    break;

                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih menu yang benar.");
                    Console.WriteLine();
                    break;
            }

        } while (pilihan != 0);
    }
}
