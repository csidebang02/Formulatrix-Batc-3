using System;
using System.Threading;

public class MyThreadClass
{
    public void ThreadMethod()
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.Name} dimulai.");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Thread {Thread.CurrentThread.Name}: Iterasi ke-{i}");
            Thread.Sleep(500);
        }
        Console.WriteLine($"Thread {Thread.CurrentThread.Name} selesai.");
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

        // Memberi nama pada thread
        myThread.Name = "MyThread";

        // Memulai eksekusi thread
        myThread.Start();

        // Blok utama tetap berjalan secara paralel dengan thread
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main Thread: Iterasi ke-{i}");
            Thread.Sleep(500);
        }

        // Menunggu thread selesai
        myThread.Join();

        Console.WriteLine("Program selesai.");
    }
}