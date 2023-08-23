using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;
            char operation = '-'; // Mengganti operasi penjumlahan dengan operasi pengurangan

            int result = 0;
            if (operation == '-')
            {
                result = num1 - num2; // Memperbaiki operasi pengurangan
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
