
bool runProgram = true;
while (runProgram)
{
    // Read user input
    Console.WriteLine("Commands available: lend, return & exit");
    string userInput = Console.ReadLine()
        ?? throw new ArgumentNullException("Your input came back as null");

    // Loaning the book
    if (userInput == "lend")
    {
        Console.WriteLine("Lending a book");
    }

    // Returning the book
    else if (userInput == "return")
    {
        Console.WriteLine("Returning a book");
    }

    // Exit program
    else if (userInput == "exit")
    {
        runProgram = false;
    }
}