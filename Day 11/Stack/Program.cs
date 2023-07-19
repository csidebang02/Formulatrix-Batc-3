using System;
class Program
{
    static void Main()
    {
        // Inisialisasi perpustakaan
        Library library = new Library();

        // Menambahkan beberapa buku ke perpustakaan
        library.AddBook(new Book("Buku 1", "Penulis 1", 2000));
        library.AddBook(new Book("Buku 2", "Penulis 2", 2010));
        library.AddBook(new Book("Buku 3", "Penulis 3", 2020));
        library.AddBook(new Book("Buku 4", "Penulis 4", 1990));
        library.AddBook(new Book("Buku 5", "Penulis 5", 1985));
        library.AddBook(new Book("Buku 6", "Penulis 6", 2005));

        // Menampilkan buku-buku di perpustakaan
        library.DisplayBooks();

        // Peminjaman buku
        Console.WriteLine("\nMeminjam buku:");
        Book borrowedBook = library.BorrowBook();
        if (borrowedBook != null)
        {
            Console.WriteLine("Buku yang dipinjam: " + borrowedBook);
        }

        // Menampilkan buku-buku di perpustakaan setelah peminjaman
        library.DisplayBooks();
    }
}
