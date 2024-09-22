using System;

public class WeatherData
{
    private double _temperature;
    private int _humidity;
    private char _scale;

    public double Temperature
    {
        get { return _temperature; }
        set
        {
            bool isUnralistic = (_scale == 'C' && (value < -60 || value > 60)) ||
                                (_scale == 'F' && (value < -76 || value > 140));

            if (isUnralistic)
            {
                Console.WriteLine("Reading mistake: The temperature value seems unrealistic.");
            }
            else
            {
                _temperature = value;
            }
        }
    }

    public int Humidity
    {
        get {return _humidity;}
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine("Reading mistake: The humidity must be between 0% and 100%.");
            }
            else
            {
                _humidity = value;
            }
        }
    }

    public char Scale
    {
        get {return _scale;}
        set
        {
            if (value == 'C' || value == 'F')
            {
                _scale = value;
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
            _temperature = temp;
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
        if (_scale == 'C')
        {
            _temperature = (_temperature * 9 / 5) + 32;
            _scale = 'F';
        }
        else if (_scale == 'F')
        {
            _temperature = (_temperature - 32) * 9 / 5;
            _scale = 'C';
        }
    }

    public void Display()
    {
        Console.WriteLine($"Temperature: {_temperature}°{_scale}");
        Console.WriteLine($"Humidity: {_humidity}%");
    }
}

