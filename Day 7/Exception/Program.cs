public class Program
{
    static void Main()
    {
        try
        {
            // Memasukkan informasi motor
            Console.WriteLine("Masukkan informasi motor:");
            string nomorPolisi = GetInput("Nomor Polisi");
            string merkMotor = GetInput("Merk Motor");
            string tahunProduksi = GetInput("Tahun Produksi");

            // Membuat objek motor
            Motor motor = new Motor(nomorPolisi, merkMotor, tahunProduksi);

            // Memasukkan informasi service
            Console.WriteLine("\nMasukkan informasi service:");
            string jenisService = GetInput("Jenis Service");
            int biayaService = GetBiayaService();

            // Menjalankan service motor
            ServiceMotor(motor, jenisService, biayaService);
        }
        catch (MotorNotFoundException ex)
        {
            Console.WriteLine($"Motor tidak ditemukan: {ex.Message}");
        }
        catch (InvalidServiceException ex)
        {
            Console.WriteLine($"Service tidak valid: {ex.Message}");
        }
        catch (NegativePriceException ex)
        {
            Console.WriteLine($"Harga tidak valid: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Terjadi kesalahan: {ex.Message}");
        }

        Console.ReadLine();
    }

    static string GetInput(string prompt)
    {
        Console.Write($"{prompt}: ");
        return Console.ReadLine();
    }

    static int GetBiayaService()
    {
        int biayaService;
        while (true)
        {
            Console.Write("Biaya Service: ");
            if (int.TryParse(Console.ReadLine(), out biayaService) && biayaService >= 0)
            {
                break;
            }
            Console.WriteLine("Harga tidak valid. Masukkan harga yang valid.");
        }
        return biayaService;
    }

    static void ServiceMotor(Motor motor, string jenisService, int biaya)
    {
        // Cek apakah motor ditemukan berdasarkan nomor polisi
        if (motor == null)
        {
            throw new MotorNotFoundException("Motor tidak ditemukan.");
        }

        // Cek apakah jenis service valid
        if (string.IsNullOrEmpty(jenisService))
        {
            throw new InvalidServiceException("Jenis service tidak boleh kosong.");
        }

        // Cek apakah biaya service positif
        if (biaya < 0)
        {
            throw new NegativePriceException();
        }

        // Proses service motor
        Console.WriteLine($"\nMotor dengan nomor polisi {motor.NomorPolisi} sedang diservis...");
        Console.WriteLine($"Jenis Service: {jenisService}");
        Console.WriteLine($"Biaya Service: {biaya}");
        // Kode lain untuk proses service motor
        Console.WriteLine("Service selesai.");
    }
}