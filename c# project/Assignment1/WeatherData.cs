using System;

public class WeatherData
{
    private double temperature;
    private int humidity;
    private char scale;

    public double Temperature
    {
        get {return temperature;}
        set
        {
            if ((scale == 'C' && (value < -60 || value > 60)) ||
                (scale == 'F' && (value < -76 || value > 140)))
            {
                Console.WriteLine("The temperature value seems unrealistic.");
            }
            else
            {
                temperature = value;
            }
        }
    }

    public int Humidity
    {
        get {return humidity;}
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine("The humidity must be between 0% and 100%.");
            }
            else
            {
                humidity = value;
            }
        }
    }

    public char Scale
    {
        get {return scale;}
        set
        {
            if (value == 'C' || value == 'F')
            {
                scale = value;
            }
            else
            {
                Console.WriteLine("Invalid scale: Use 'C' for Celsius or 'F' for Fahrenheit.");
            }
        }
    }

    public void SetData()
    {
        Console.WriteLine("Enter the temperature value: ('C' for Celsius or 'F' for Fahrenheit.)");
        char inputScale = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();
        Scale = inputScale;
        
        Console.Write("Enter the temperature: ");
        if (double.TryParse(Console.ReadLine(), out double temp))
        {
            temperature = temp;
        }
        else
        {
            Console.WriteLine("Invalid temperature value. Please enter a number");
        }
        
        Console.Write("Enter the humidity 0 to 100: ");
        if (int.TryParse(Console.ReadLine(), out int humid))
        {
            Humidity = humid;
        }
        else
        {
            Console.WriteLine("Invalid humidity value. Please enter a number");
        }
    }

    public void Convert()
    {
        if (scale == 'C')
        {
            temperature = (temperature * 9 / 5) + 32;
            scale = 'F';
        }
        else if (scale == 'F')
        {
            temperature = (temperature - 32) * 9 / 5;
            scale = 'C';
        }
    }

    public void Display()
    {
        Console.WriteLine($"Temperature: {temperature}°{scale}");
        Console.WriteLine($"Humidity: {humidity}%");
    }
}

