using System.Security.Cryptography.X509Certificates;

class Library
{
    public List<Book> Books;

    public Library()
    {
        Books = new();

        Books.Add(new Book("You Shall Not Fast: A Cookbook", "Gandalf the Grey", new DateTime(3019, 3, 25)));
        Books.Add(new Book("How to Knock Over Everything", "Whiskers the Cat", new DateTime(2023, 1, 1)));
        Books.Add(new Book("Am I Overthinking This?", "An Elf on the Shelf", new DateTime(2020, 12, 1)));
        Books.Add(new Book("Infinite Loops and Caffeine", "Anonymous Programmer", new DateTime(2024, 5, 7)));
        Books.Add(new Book("Never Leg Day", "Skip Legman", new DateTime(2022, 4, 12)));
        Books.Add(new Book("I'll Finish This Book Tomorrow", "Pro Crastinator", new DateTime(2025, 6, 30)));
        Books.Add(new Book("The Art of the Perfect Nap", "Garfield", new DateTime(1978, 6, 19)));
        Books.Add(new Book("Oh, Really?", "Dr. Sarcasm", new DateTime(2018, 9, 15)));
        Books.Add(new Book("Earthlings: A Field Guide", "Zorg of Planet X", new DateTime(2050, 11, 11)));
        Books.Add(new Book("Oops, Wrong Century", "Time Traveler X", new DateTime(1805, 3, 14)));
    }

    public void AddNewBook(Book newBook)
    {
        Books.Add(newBook);
    }

    public void ListAvailableBooks()
    {
        Console.WriteLine("Here are the list of available books:");

        foreach (Book b in Books)
        {
            Console.WriteLine("\"{0}\" by {1}. Released in {2}", b.Title, b.Author, b.PublishingDate.Year);
        }
    }

    public Book? LendBook(string? title)
    {
        Book? book = Books.Find(b => b.Title == title);

        if(book != null) return book;
        else return null;
    }
}