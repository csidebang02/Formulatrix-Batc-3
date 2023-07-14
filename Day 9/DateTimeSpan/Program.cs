class Program
{
	static List<string> kondisiMotor = new List<string>();
	static List<string> motorBaruMasuk = new List<string>();
	static Queue<string> antrianMotor = new Queue<string>();
	static int nomorAntrian = 1;
	static Dictionary<string, int> hargaPerbaikan = new Dictionary<string, int>()
	{
		{ "Rem Rusak", 500000 },
		{ "Ganti Ban", 300000 },
		{ "Ganti Oli", 100000 },
		{ "Servis Rutin", 200000 }
	};
	static DateTime tanggalTerima = new DateTime(2023, 7, 14, 9, 0, 0); // Contoh tanggal terima di bengkel
	static DateTime tanggalPerkiraanSelesai = tanggalTerima.AddDays(3).AddHours(6); // Tanggal perkiraan selesai adalah 3 hari dan 6 jam setelah tanggal terima
	static DateTime tanggalSelesai = new DateTime(2023, 7, 17, 15, 30, 0); // Contoh tanggal selesai di bengkel

	static void Main(string[] args)
	{
		// Menambahkan beberapa kondisi motor
		AddCondition("Ganti oli");
		AddCondition("Perbaikan rem");

		// Menampilkan menu pilihan
		DisplayMenu();

		TimeSpan durasiPengerjaan = tanggalSelesai - tanggalTerima;
		TimeSpan durasiPerkiraan = tanggalPerkiraanSelesai - tanggalTerima;

		Console.WriteLine("Durasi pengerjaan: " + durasiPengerjaan.Days + " hari, " +
											  durasiPengerjaan.Hours + " jam, " +
											  durasiPengerjaan.Minutes + " menit.");

		Console.WriteLine("Durasi perkiraan: " + durasiPerkiraan.Days + " hari, " +
											  durasiPerkiraan.Hours + " jam.");

		if (tanggalSelesai > tanggalPerkiraanSelesai)
		{
			TimeSpan durasiTerlambat = tanggalSelesai - tanggalPerkiraanSelesai;
			Console.WriteLine("Terlambat: " + durasiTerlambat.Days + " hari, " +
												durasiTerlambat.Hours + " jam, " +
												durasiTerlambat.Minutes + " menit.");
		}
		else
		{
			Console.WriteLine("Tidak terlambat.");
		}

		Console.ReadLine();
	}

	static void AddCondition(string kondisi)
	{
		kondisiMotor.Add(kondisi);
		Console.WriteLine("Kondisi \"" + kondisi + "\" telah ditambahkan.");
	}

	static void RemoveCondition(string kondisi)
	{
		if (kondisiMotor.Contains(kondisi))
		{
			kondisiMotor.Remove(kondisi);
			Console.WriteLine("Kondisi \"" + kondisi + "\" telah dihapus.");
		}
		else
		{
			Console.WriteLine("Kondisi \"" + kondisi + "\" tidak ditemukan.");
		}
	}

	static void ListAllConditions()
	{
		Console.WriteLine("Daftar semua kondisi motor:");
		foreach (string kondisi in kondisiMotor)
		{
			Console.WriteLine("- " + kondisi);
		}
	}

	static void CheckMotorCondition(string kondisi)
	{
		if (kondisiMotor.Contains(kondisi))
		{
			Console.WriteLine("Motor memiliki kondisi \"" + kondisi + "\".");
		}
		else
		{
			Console.WriteLine("Motor tidak memiliki kondisi \"" + kondisi + "\".");
		}
	}

	static void CheckRepairPrice(string kondisi)
	{
		if (hargaPerbaikan.ContainsKey(kondisi))
		{
			int harga = hargaPerbaikan[kondisi];
			Console.WriteLine("Harga perbaikan untuk kondisi \"" + kondisi + "\": Rp" + harga);
		}
		else
		{
			Console.WriteLine("Kondisi \"" + kondisi + "\" tidak ditemukan dalam daftar harga perbaikan.");
		}
	}

	static void AddNewMotor(string motor)
	{
		motorBaruMasuk.Add(motor);
		antrianMotor.Enqueue(motor);
		Console.WriteLine("Motor \"" + motor + "\" telah ditambahkan sebagai motor baru yang masuk.");
	}

	static void ListAllMotors()
	{
		Console.WriteLine("Daftar semua motor baru yang masuk:");
		foreach (string motor in motorBaruMasuk)
		{
			Console.WriteLine("- " + motor);
		}
	}

	static void RegisterNewMotor()
	{
		Console.WriteLine("=== Pendaftaran Kendaraan Motor Baru Masuk ===");
		Console.Write("Masukkan plat motor: ");
		string platMotor = Console.ReadLine();
		Console.Write("Masukkan merek motor: ");
		string merekMotor = Console.ReadLine();
		Console.Write("Masukkan tahun: ");
		int tahun = int.Parse(Console.ReadLine());
		Console.Write("Masukkan nama pemilik: ");
		string namaPemilik = Console.ReadLine();
		Console.Write("Masukkan kerusakan motor: ");
		string kerusakanMotor = Console.ReadLine();

		string motor = platMotor + " - " + merekMotor + " (" + tahun + ") - " + namaPemilik + " - " + kerusakanMotor;
		AddNewMotor(motor);
		Console.WriteLine("Motor \"" + motor + "\" telah didaftarkan dengan nomor antrian: " + nomorAntrian);
		nomorAntrian++;
	}

	static void CheckQueueStatus()
	{
		if (antrianMotor.Count > 0)
		{
			Console.WriteLine("Jumlah motor dalam antrian: " + antrianMotor.Count);
			Console.WriteLine("Motor berikutnya dalam antrian: " + antrianMotor.Peek());
		}
		else
		{
			Console.WriteLine("Tidak ada motor dalam antrian.");
		}
	}

	static void ProcessNextMotor()
	{
		if (antrianMotor.Count > 0)
		{
			string motorSelesai = antrianMotor.Dequeue();
			Console.WriteLine("Motor \"" + motorSelesai + "\" telah selesai dikerjakan.");
		}
		else
		{
			Console.WriteLine("Tidak ada motor dalam antrian.");
		}
	}

	static void DisplayMenu()
	{
		bool exitMenu = false;

		while (!exitMenu)
		{
			Console.WriteLine();
			Console.WriteLine("Menu Pilihan:");
			Console.WriteLine("1. Lihat Harga Perbaikan");
			Console.WriteLine("2. Lihat Kerusakan Motor");
			Console.WriteLine("3. Daftar Motor Baru yang Masuk");
			Console.WriteLine("4. Pendaftaran Kendaraan Motor Baru Masuk");
			Console.WriteLine("5. Cek Antrian Motor");
			Console.WriteLine("6. Proses Motor Berikutnya");
			Console.WriteLine("7. Lama Waktu Perbaikan");
			Console.WriteLine("8. Sisa Waktu Perbaikan");
			Console.WriteLine("9. Keluar");

			Console.Write("Masukkan pilihan Anda (1-9): ");
			string input = Console.ReadLine();

			switch (input)
			{
				case "1":
					Console.WriteLine("Daftar harga perbaikan:");
					ListAllRepairPrices();
					Console.Write("Masukkan kondisi motor: ");
					string kondisi = Console.ReadLine();
					CheckRepairPrice(kondisi);
					break;
				case "2":
					Console.WriteLine("Daftar semua kondisi motor:");
					ListAllConditions();
					break;
				case "3":
					ListAllMotors();
					break;
				case "4":
					RegisterNewMotor();
					break;
				case "5":
					CheckQueueStatus();
					break;
				case "6":
					ProcessNextMotor();
					break;
				case "7":
					DisplayRepairDuration();
					break;
				case "8":
					DisplayRemainingDuration();
					break;
				case "9":
					exitMenu = true;
					break;
				default:
					Console.WriteLine("Pilihan tidak valid. Silakan masukkan pilihan 1-9.");
					break;
			}
		}
	}

    static void ListAllRepairPrices()
    {
        foreach (KeyValuePair<string, int> entry in hargaPerbaikan)
        {
            Console.WriteLine("- " + entry.Key + ": Rp" + entry.Value);
        }
    }

    static void DisplayRepairDuration()
    {
        TimeSpan durasiPengerjaan = tanggalSelesai - tanggalTerima;
        Console.WriteLine("Durasi pengerjaan: " + durasiPengerjaan.Days + " hari, " +
                                              durasiPengerjaan.Hours + " jam, " +
                                              durasiPengerjaan.Minutes + " menit.");
    }

    static void DisplayRemainingDuration()
    {
        TimeSpan durasiPerkiraan = tanggalPerkiraanSelesai - DateTime.Now;
        Console.WriteLine("Sisa waktu perbaikan: " + durasiPerkiraan.Days + " hari, " +
                                                durasiPerkiraan.Hours + " jam, " +
                                                durasiPerkiraan.Minutes + " menit.");
    }
}