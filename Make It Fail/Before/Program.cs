using System;

namespace CarWorkshop
{
    class Program
    {
        public void RepairEngine(bool hasIssue)
        {
            // Simulasi: Kode perbaikan mesin mobil
            if (hasIssue)
            {
                Console.WriteLine("Engine repaired.");
            }
            else
            {
                Console.WriteLine("No issue found.");
            }
        }

        static void Main(string[] args)
        {
            bool engineHasIssue = false;
            Program program = new Program();
            program.RepairEngine(engineHasIssue);
        }
    }
}
