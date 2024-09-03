//Basic Review

//int var examples
{ 
    int x = 10;

    x = 20 * 10;

    Console.WriteLine(x);
    int a = 50;
    a = 50 - 45;
    Console.WriteLine(a);
}

    //string var examples
{   
    string x = "hello world";
    Console.WriteLine(x);
}

//bool var examples
{
    bool example = true;

    if (example)
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
    Console.WriteLine("is this NOT an example?");
    Console.WriteLine(example);
}

//Differint Type Conversions


class TypeConversionDemo
{
    static void Main()
    {
        // Implicit conversion
        int intValue = 42;
        double doubleValue = intValue; // int to double
        Console.WriteLine($"Implicit Conversion: int ({intValue}) to double ({doubleValue})");

        // Explicit conversion
        double anotherDoubleValue = 99.99;
        int anotherIntValue = (int)anotherDoubleValue; // double to int
        Console.WriteLine($"Explicit Conversion: double ({anotherDoubleValue}) to int ({anotherIntValue})");

        // Convert class methods
        string stringValue = "123";
        int convertedIntValue = Convert.ToInt32(stringValue); // string to int
        double convertedDoubleValue = Convert.ToDouble(stringValue); // string to double
        Console.WriteLine($"Convert Class: string ({stringValue}) to int ({convertedIntValue}), double ({convertedDoubleValue})");

        // Parse methods
        string hexValue = "1A";
        int parsedIntValue = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber); // Hexadecimal string to int
        Console.WriteLine($"Parse Method: Hex string ({hexValue}) to int ({parsedIntValue})");

        // TryParse method
        string invalidStringValue = "abc";
        if (int.TryParse(invalidStringValue, out int result))
        {
            Console.WriteLine($"TryParse Success: string ({invalidStringValue}) to int ({result})");
        }
        else
        {
            Console.WriteLine($"TryParse Failure: Unable to convert string ({invalidStringValue}) to int");
        }

        // Object to specific type conversion
        object objValue = "This is an object";
        string stringFromObject = (string)objValue; // object to string
        Console.WriteLine($"Object to String: object ({objValue}) to string ({stringFromObject})");

        // DateTime conversion
        string dateTimeString = "2024-09-01";
        DateTime dateTimeValue = DateTime.Parse(dateTimeString); // string to DateTime
        Console.WriteLine($"DateTime Conversion: string ({dateTimeString}) to DateTime ({dateTimeValue})");
    }
}
