
class Program
{
    static void Main()
    {
        Dictionary<string, int> modelMotor = new Dictionary<string, int>();

        // Menambahkan data ke dictionary
        modelMotor.Add("ZX14R", 2023);
        modelMotor.Add("Z900RS CAFE", 2024);
        modelMotor.Add("Ninja 250SE", 2014);

        // Mengakses nilai dalam dictionary
        int tahunZX14R = modelMotor["ZX14R"];
        Console.WriteLine("Tahun ZX14R: " + tahunZX14R);

        // Mengubah nilai dalam dictionary
        modelMotor["Z900RS CAFE"] = 2024;

        // Menghapus data dari dictionary
        modelMotor.Remove("Ninja 250SE");

        // Menampilkan semua data dalam dictionary
        Console.WriteLine("Data Motor:");
        foreach (var pair in modelMotor)
        {
            Console.WriteLine(pair.Key + ": " + pair.Value);
        }

        Console.ReadLine();
    }
}
