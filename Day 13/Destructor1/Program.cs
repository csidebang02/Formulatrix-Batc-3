class MotorcycleService
{
    public string CustomerName { get; private set; }
    public string MotorcycleModel { get; private set; }
    public List<string> ServiceHistory { get; private set; }

    public MotorcycleService(string customerName, string motorcycleModel)
    {
        CustomerName = customerName;
        MotorcycleModel = motorcycleModel;
        ServiceHistory = new List<string>();
    }

    public void AddService(string serviceDescription)
    {
        ServiceHistory.Add(serviceDescription);
    }

    public void PrintServiceHistory()
    {
        Console.WriteLine($"Service History for {CustomerName}'s {MotorcycleModel}:");
        foreach (var service in ServiceHistory)
        {
            Console.WriteLine("- " + service);
        }
    }

    // Destructor untuk mencatat riwayat layanan ke dalam file log sebelum objek dihapus dari memori.
    ~MotorcycleService()
    {
        SaveServiceHistoryToLog();
        Console.WriteLine($"Motorcycle service history for {CustomerName}'s {MotorcycleModel} has been logged.");
    }

    private void SaveServiceHistoryToLog()
    {
        try
        {
            using (var writer = new System.IO.StreamWriter("service_log.txt", true))
            {
                writer.WriteLine($"Customer: {CustomerName}, Motorcycle Model: {MotorcycleModel}");
                foreach (var service in ServiceHistory)
                {
                    writer.WriteLine($"- {service}");
                }
                writer.WriteLine("---------------------------------------------");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to save service history: {ex.Message}");
        }
    }
}

class Program
{
    static void Main()
    {
        var bengkel = new MotorcycleService("John Doe", "Yamaha XSR700");

        bengkel.AddService("Oil change");
        bengkel.AddService("Brake check and adjustment");
        bengkel.AddService("Tire replacement");

        bengkel.PrintServiceHistory();

        // Simulasi aplikasi ditutup.
        bengkel = null;
        GC.Collect();
        GC.WaitForPendingFinalizers();

        Console.WriteLine("Bengkel aplikasi telah ditutup.");
    }
}