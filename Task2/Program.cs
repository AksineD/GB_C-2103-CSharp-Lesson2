// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the number of the month (from 1 to 12)");

var month = GetUserInput();

getFullName(month);

void getFullName(int month)
{
    DateTime date = new DateTime(2020, month, 1);
    var str = date.ToString("MMMM");
    Console.WriteLine($"Input month is {str}");
}

int GetUserInput()
{
    if (int.TryParse(Console.ReadLine(), out var result))
    {
        if (result > 0 && result < 13)
        {
            return result;
        }
    }

    Console.WriteLine("Enter a valid value");
    GetUserInput();

    return result;
}