using System;

class Book
{
    public string Code;
    public string Name;

    public Book(string code, string name)
    {
        Code = code;
        Name = name;
    }
}

class Library
{
    static void Main()
    {
        Book[] books = new Book[3];

        for (int i = 0; i < books.Length; i++)
        {
            Console.Write("Enter book code: ");
            string code = Console.ReadLine();
            Console.Write("Enter book name: ");
            string name = Console.ReadLine();
            books[i] = new Book(code, name);
        }

        Console.WriteLine("\nBooks in the Library:");
        foreach (Book b in books)
        {
            Console.WriteLine($"Code: {b.Code}, Name: {b.Name}");
        }
    }
}