using System;

namespace CarWorkshop
{
    class Program
    {
        public void RepairEngine(bool hasIssue)
        {
            try
            {
                // Kode perbaikan mesin mobil
                if (hasIssue)
                {
                    Console.WriteLine("Engine repaired.");
                }
                else
                {
                    Console.WriteLine("No issue found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Repair failed. Error: " + ex.Message);
            }   
        }

        static void Main(string[] args)
        {
            bool engineHasIssue = true; // Set ke true untuk mensimulasikan masalah pada mesin
            Program program = new Program();
            program.RepairEngine(engineHasIssue);
        }
    }
}
