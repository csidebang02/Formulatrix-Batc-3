public class Motor
{
    public string Merk { get; set; }
    public string Model { get; set; }
    public int Tahun { get; set; }
}

public class Bengkel<T>
{
    private List<T> daftarMotor;

    public Bengkel()
    {
        daftarMotor = new List<T>();
    }

    public void TambahMotor(T motor)
    {
        daftarMotor.Add(motor);
        Console.WriteLine("Motor berhasil ditambahkan ke dalam bengkel");
    }

    public void LayananMotor(T motor)
    {
        if (daftarMotor.Contains(motor))
        {
            Console.WriteLine("Melakukan layanan pada motor: " + motor.ToString());
        }
        else
        {
            Console.WriteLine("Motor tidak ditemukan di bengkel");
        }
    }
}

class Program
{
    static void Main()
    {
        Bengkel<Motor> bengkel = new Bengkel<Motor>();

        Motor motor1 = new Motor { Merk = "Kawasaki", Model = "Ninja", Tahun = 2014 };
        Motor motor2 = new Motor { Merk = "Kawasaki", Model = "ZX-14R", Tahun = 2023 };

        bengkel.TambahMotor(motor1);
        bengkel.TambahMotor(motor2);

        Motor motor3 = new Motor { Merk = "Kawasaki", Model = "Z900RS CAFE", Tahun = 2024 };
        bengkel.LayananMotor(motor3);

        bengkel.LayananMotor(motor1);

        Console.ReadLine();
    }
}
