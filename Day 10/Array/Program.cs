class Program
{
    static void Main()
    {
        string[] buah = new string[4]; // Membuat array dengan ukuran 4

        // Menyimpan data tokoh buah ke dalam array
        buah[0] = "Apel";
        buah[1] = "Jeruk";
        buah[2] = "Mangga";
        buah[3] = "Anggur";

        Console.WriteLine("Tokoh-tokoh Buah:");

        // Menampilkan data tokoh buah menggunakan perulangan foreach
        foreach (string tokoh in buah)
        {
            Console.WriteLine(tokoh);
        }

        // Mengubah elemen dalam array
        buah[1] = "Pisang"; // Mengubah nilai tokoh buah pada indeks 1 menjadi "Pisang"

        // Menambahkan elemen baru ke dalam array
        buah[4] = "Semangka"; // Menambahkan "Semangka" sebagai tokoh buah baru pada indeks 4

        Console.WriteLine("\nSetelah Perubahan:");

        // Menampilkan data tokoh buah setelah perubahan
        foreach (string tokoh in buah)
        {
            Console.WriteLine(tokoh);
        }
    }
}