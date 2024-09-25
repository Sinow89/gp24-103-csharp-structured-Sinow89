
{
    //First scope
    Console.WriteLine("Give me a number");
    string? userInput = Console.ReadLine();
    Console.WriteLine(userInput + "1");

}
//End of first scope
//--------------------------------



//Start of second scope
{
Console.WriteLine("Give me a another number");
string userInput = Console.ReadLine();
int parsedInput;
while (!int.TryParse(userInput, out parsedInput))
    
{
    Console.WriteLine("Wrong, give me a numbers and no characters.");
    userInput = Console.ReadLine();
    
}
Console.WriteLine(++parsedInput);

}


//End of second scope
//--------------------------------



//Start of third scope
{
    
    Console.WriteLine("Give me a another number");
    string? userInput = Console.ReadLine();
    char charUserInput = Convert.ToChar(userInput);
    charUserInput++;
    Console.WriteLine(charUserInput);
    
}

//End of third scope
//--------------------------------