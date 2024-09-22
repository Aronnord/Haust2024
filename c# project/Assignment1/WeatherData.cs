using System;

public class WeatherData
{
    private double temperature;
    private double humidity;
    private string scale;
    
    public WeatherData(double temperature = 0.0, double humidity = 0.0, string scale = "Celsius")
    {
        this.Temperature = temperature;
        this.Humidity = humidity;
        this.Scale = scale;
    }
    
    public double Temperature
    {
        get { return temperature; }
        set
        {
            if (Scale == "Celsius" && (value < -60 || value > 60))
            {
                Console.WriteLine("The temperature value is unrealistic; it must have been a mistake.");
            }
            else if (Scale == "Fahrenheit" && (value < -76 || value > 140))
            {
                Console.WriteLine("The temperature value is unrealistic; it must have been a mistake.");
            }
            else
            {
                temperature = value;
            }
        }
    }
    
    public double Humidity
    {
        get { return humidity; }
        set { humidity = value; }
    }
    
    public string Scale
    {
        get { return scale; }
        set
        {
            if (value != "Celsius" && value != "Fahrenheit")
            {
                throw new ArgumentException("Scale must be 'Celsius' or 'Fahrenheit'.");
            }
            scale = value;
        }
    }
    
    public void SetScaleAndTemperatureFromUserInput()
    {
        Console.WriteLine("Choose the temperature scale (Celsius/Fahrenheit): ");
        string inputScale = Console.ReadLine()?.Trim();
        
        if (inputScale.Equals("Fahrenheit", StringComparison.OrdinalIgnoreCase))
        {
            Scale = "Fahrenheit";
        }
        else
        {
            Scale = "Celsius";
            if (!inputScale.Equals("Celsius", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Invalid scale input. Defaulting to Celsius.");
            }
        }
        
        Console.Write($"Enter the temperature in {Scale}: ");
        string inputTemp = Console.ReadLine();
        
        if (double.TryParse(inputTemp, out double temp))
        {
            Temperature = temp; // This will trigger the validation inside the setter
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
   
    public override string ToString()
    {
        return $"Temperature: {Temperature}° {Scale}, Humidity: {Humidity}%";
    }
}