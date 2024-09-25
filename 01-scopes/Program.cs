
{
Console.WriteLine("Give me a number");
string? userInput = Console.ReadLine();
int parsedInput;
while (!int.TryParse(userInput, out parsedInput))
    
    {
        Console.WriteLine("Wrong, give me a numbers and no characters.");
        userInput = Console.ReadLine();
    
    }
    int intUserInput = Convert.ToInt32(userInput);
    Console.WriteLine(intUserInput+82);
}

{
Console.WriteLine("Give me a another number");
int userInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(++userInput);
}

{
    
    Console.WriteLine("Give me a another number");
    string userInput = Console.ReadLine();
    userInput = ":";
    Console.WriteLine(userInput);
    
    
}