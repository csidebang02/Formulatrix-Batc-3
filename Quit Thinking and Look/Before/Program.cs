using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;
            char operation = '+';

            int result = 0;
            if (operation == '-')
            {
                result = num1 + num2; // Masalah: Operasi penjumlahan pada operasi pengurangan
            }
            else if (operation == '*')
            {
                result = num1 * num2;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
