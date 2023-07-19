using System;

public class Library
{
    private Stack<Book> booksStack;

    public Library()
    {
        booksStack = new Stack<Book>();
    }

    public void AddBook(Book book)
    {
        booksStack.Push(book);
    }

    public Book BorrowBook()
    {
        return booksStack.Pop();
    }

    public void DisplayBooks()
    {
        Console.WriteLine("Buku-buku di perpustakaan:");
        foreach (Book book in booksStack)
        {
            Console.WriteLine(book);
        }
    }
}
