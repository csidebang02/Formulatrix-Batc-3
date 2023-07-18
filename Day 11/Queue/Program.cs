class Program
{
    static void Main()
    {
        Queue<string> antrianMotor = new Queue<string>();

        // Menambahkan motor ke dalam antrian
        antrianMotor.Enqueue("Motor A");
        antrianMotor.Enqueue("Motor B");
        antrianMotor.Enqueue("Motor C");
        antrianMotor.Enqueue("Motor D");

        Console.WriteLine("Jumlah motor dalam antrian: " + antrianMotor.Count);

        // Menampilkan motor yang sedang berada di depan antrian (tanpa menghapusnya dari antrian)
        string motorDepan = antrianMotor.Peek();
        Console.WriteLine("Motor yang berada di depan antrian: " + motorDepan);

        // Mengeluarkan motor dari depan antrian (proses keluar dari antrian)
        string motorKeluar = antrianMotor.Dequeue();
        Console.WriteLine("Motor yang keluar dari antrian: " + motorKeluar);

        Console.WriteLine("Jumlah motor dalam antrian setelah satu motor keluar: " + antrianMotor.Count);

        // Menambahkan motor baru ke dalam antrian
        antrianMotor.Enqueue("Motor E");

        Console.WriteLine("Jumlah motor dalam antrian setelah satu motor masuk: " + antrianMotor.Count);

        // Menampilkan semua motor yang masih dalam antrian
        Console.WriteLine("Motor yang masih dalam antrian:");
        foreach (string motor in antrianMotor)
        {
            Console.WriteLine(motor);
        }
    }
}