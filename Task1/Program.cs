// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter the minimum temperature value for the day");
var minval = GetUserInput();

Console.WriteLine("Enter the maximum temperature value for the day");
var maxval = GetUserInput();

CalcAverage(minval, maxval);

float GetUserInput()
{
    if (float.TryParse(Console.ReadLine(), out var result))
    {
        return result;
    }

    Console.WriteLine("Enter a valid value");
    GetUserInput();

    return result;
}

void CalcAverage(float minVal, float maxVal)
{
    var avrTemp = 0.0;
    avrTemp = (maxval + minval) / 2;
    Console.WriteLine($"Average daily temperature is {avrTemp:F1}");
}
