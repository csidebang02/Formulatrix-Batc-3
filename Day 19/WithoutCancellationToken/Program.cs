using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program dimulai. Tekan tombol Enter untuk menghentikan...");

        // Membuat sebuah thread baru untuk menjalankan metode yang panjang
        Thread longRunningThread = new Thread(LongRunningMethod);
        longRunningThread.Start();

        // Menunggu hingga tombol Enter ditekan
        Console.ReadLine();

        // Menghentikan thread yang berjalan
        longRunningThread.Abort();

        Console.WriteLine("Program berakhir.");
    }

    static void LongRunningMethod()
    {
        try
        {
            while (true)
            {
                Console.WriteLine("Metode panjang sedang berjalan...");
                Thread.Sleep(1000);
            }
        }
        catch (ThreadAbortException)
        {
            Console.WriteLine("Metode panjang dihentikan.");
            Thread.ResetAbort();
        }
    }
}