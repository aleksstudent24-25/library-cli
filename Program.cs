Library library = new Library();

//Create Book
Book ninetyEightyFour = new Book("1984", "George Orwell", new DateTime(1949, 6, 8));

//Add Book
library.AddNewBook(ninetyEightyFour);

bool runProgram = true;
while (runProgram)
{
    // Read user input
    Console.WriteLine("Commands available: list, lend, return & exit");
    string userInput = Console.ReadLine()
        ?? throw new ArgumentNullException("Your input came back as null");

    // Book List
    if (userInput == "list")
    {
        library.ListAvailableBooks();
    }
    // Loaning the book
    else if (userInput == "lend")
    {
        Console.WriteLine("What book do you want to loan?");
        string? bookTitle = Console.ReadLine();
        Book? lentBook = library.LendBook(bookTitle);

        if (lentBook != null)
        {
            Console.WriteLine("You have successfully loaned {0}.", lentBook.Title);
        }
        else Console.WriteLine("Sorry, we couldn't find the book you were looking for.");
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