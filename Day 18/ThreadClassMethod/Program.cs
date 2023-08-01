using System;
using System.Threading;

public class MyThreadClass
{
    // Metode yang akan dijalankan pada thread terpisah
    public void ThreadMethod()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"ThreadMethod: Iterasi ke-{i}");
            Thread.Sleep(1000); // Memberikan jeda 1 detik untuk simulasi pekerjaan
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Membuat objek dari kelas MyThreadClass
        MyThreadClass myThreadObj = new MyThreadClass();

        // Membuat thread dan menetapkan metode yang akan dijalankan pada thread tersebut
        Thread myThread = new Thread(myThreadObj.ThreadMethod);

        // Memulai eksekusi thread
        myThread.Start();

        // Blok utama tetap berjalan secara paralel dengan thread
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Main Thread: Iterasi ke-{i}");
            Thread.Sleep(500); // Memberikan jeda 0.5 detik untuk simulasi pekerjaan
        }

        // Menunggu thread selesai
        myThread.Join();

        Console.WriteLine("Program selesai.");
    }
}