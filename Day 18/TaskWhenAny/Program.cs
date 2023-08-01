using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Starting the program...");

        // Create a list of tasks
        List<Task<string>> tasks = new List<Task<string>>();

        // Add two methods that include Console.ReadLine() inside
        tasks.Add(MethodWithUserInput());
        tasks.Add(AnotherMethodWithUserInput());

        // Wait for any of the tasks to complete
        Task<string> firstCompletedTask = await Task.WhenAny(tasks);

        // The result will be the first completed task's output
        string result = await firstCompletedTask;

        Console.WriteLine($"The first completed task returned: {result}");

        Console.WriteLine("Back to the main method. Press Enter to exit.");
        Console.ReadLine();
    }

    public static async Task<string> MethodWithUserInput()
    {
        Console.WriteLine("Inside MethodWithUserInput. Please enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Now I will call another method.");

        // Simulate some delay
        await Task.Delay(2000);

        return $"MethodWithUserInput - Hello, {name}!";
    }

    public static async Task<string> AnotherMethodWithUserInput()
    {
        Console.WriteLine("Inside AnotherMethodWithUserInput. Please enter your age:");
        string ageInput = Console.ReadLine();

        if (int.TryParse(ageInput, out int age))
        {
            Console.WriteLine($"You entered {age} years old.");
            if (age >= 18)
                Console.WriteLine("You are an adult!");
            else
                Console.WriteLine("You are a minor!");
        }
        else
        {
            Console.WriteLine("Invalid age input. Please enter a valid number.");
        }

        // Simulate some delay
        await Task.Delay(3000);

        return $"AnotherMethodWithUserInput - Age: {age}";
    }
}