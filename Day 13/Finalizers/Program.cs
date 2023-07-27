using System;

class MyClass
{
    private IntPtr someResource; // Contoh sumber daya yang perlu dibebaskan

    public MyClass()
    {
        // Inisialisasi objek dan alokasi sumber daya
        someResource = IntPtr.Zero; // Misalnya, mengalokasikan sumber daya unmanaged
        // ...
    }

    ~MyClass()
    {
        // Finalizer untuk membersihkan sumber daya sebelum objek dihapus
        CleanupResources();
    }

    private void CleanupResources()
    {
        // Membersihkan sumber daya yang dialokasikan (misalnya, sumber daya unmanaged)
        // ...
        Console.WriteLine("Cleaning up resources!");
    }

    public void DoSomething()
    {
        // Melakukan tugas objek
        // ...
    }
}

class Program
{
    static void Main()
    {
        // Contoh penggunaan kelas MyClass
        MyClass myObject = new MyClass();
        myObject.DoSomething();

        // Tidak ada pemanggilan GC.Collect() atau GC.WaitForPendingFinalizers() diperlukan di sini,
        // karena Garbage Collector akan secara otomatis memanggil finalizer sebelum menghapus objek.

        // Saat myObject keluar dari cakupan atau dihapus secara eksplisit dengan:
        // myObject = null;
        // Atau ketika program keluar dari blok Main(), Garbage Collector akan menghapus objek tersebut,
        // dan metode finalizer (CleanupResources()) akan dipanggil.

        // Catatan: Penggunaan finalizer harus digunakan dengan hati-hati dan hanya dalam situasi
        // di mana Anda benar-benar perlu membersihkan sumber daya yang terikat dengan objek.
    }
}
