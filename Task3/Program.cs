
Console.WriteLine("Input a number");
var userInput = GetUserInput();

if (userInput % 2 == 0)
{
    Console.WriteLine($"entered number {userInput} is even");
}
else
{
    Console.WriteLine($"entered number {userInput} is odd");
}


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