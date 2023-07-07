// using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        // Menggunakan StringBuilder
        stopwatch.Start();

        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 100000; i++)
        {
            sb.Append("M");
        }

        stopwatch.Stop();
        TimeSpan elapsedTime1 = stopwatch.Elapsed;

        // Menggunakan String Concatenation
        stopwatch.Reset();
        stopwatch.Start();

        string result2 = string.Empty;
        for (int i = 0; i < 100000; i++)
        {
            result2 += "M";
        }

        stopwatch.Stop();
        TimeSpan elapsedTime2 = stopwatch.Elapsed;

        // Menampilkan hasil waktu eksekusi
        Console.WriteLine("Time StringBuilder: " + elapsedTime1);
        Console.WriteLine("Time String Concatenation: " + elapsedTime2);

        Console.ReadLine();
    }
}
