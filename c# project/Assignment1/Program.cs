
/*class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        string input;
        
        Console.WriteLine("Enter numbers (press enter without numbers to exit!");

        while (true)
        {
            Console.WriteLine("Enter a number:");
            input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                break;

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number!");
            }
        }
        
        Console.WriteLine("\nYou have chose this number:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
*/

using System;

public class Pprogram
{
    public static void Main()
    {
        WeatherData weather = new WeatherData();
        Console.WriteLine(weather);

        weather.SetScaleAndTemperatureFromUserInput();
        weather.Humidity = 65;
        
        Console.WriteLine(weather);
    }
}    
