using BookLibrary;

namespace BookManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();            //Creating object of Book class

            while (true)
            {
                Console.WriteLine("Book Management system:");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. Display all Books");
                Console.WriteLine("3. Delete a Book by ID");
                Console.WriteLine("4. Exit");



                Console.Write("Enter your choice: ");

                string choice;
                choice = Console.ReadLine();
                bool isChoiceDigit = int.TryParse(choice, out int switchChoice);
                 

                if (! isChoiceDigit)
                {
                    Console.WriteLine("Choice is invalid.");
                    continue;
                }

                switch (switchChoice)
                {
                    case 1:
                        AddBook(books);
                        break;
                    case 2:
                        DisplayBooks(books);
                        break;
                    case 3:
                        DeleteBook(books);
                        break;
                    case 4:
                        Console.WriteLine("Exit");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        // Add Book
        static void AddBook(List<Book> books)
        {
            // creating an object of book and assigning values to it
            Book newBook = new Book(0, "", "", 0.0, "", 0);
            //getting input from user
            newBook.GetDetails();
            //add new book to list collection
            var IsSameBookIdPresent = books.Find(book => book.BookID == newBook.BookID);
            if(IsSameBookIdPresent == null)
            {
                books.Add(newBook);
                Console.WriteLine("Book added successfully.");
            }
            else
            {
                Console.WriteLine("Book with same Id is present. Cannot add book");
            }
                                        
            
        }

        //  display all books
        static void DisplayBooks(List<Book> books)
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine($"Book ID: {book.BookID}, Name: {book.BookName}, ISBN_No: {book.ISBNNo}, Price: {book.Price}, " +
                                  $"Publisher: {book.Publisher}, Pages: {book.NumberOfPages}, Language: {book.Language}, " +
                                  $"LoT: {book.LoT}, Summary: {book.Summary}");
            }
        }

        // delete a book by ID
        static void DeleteBook(List<Book> books)
        {
            Console.WriteLine("Enter Book ID to delete: ");
            int bookIdToDelete = Convert.ToInt32(Console.ReadLine());

            Book bookToDelete = books.Find(b => b.BookID == bookIdToDelete);        
            if (bookToDelete != null)
            {
                books.Remove(bookToDelete);
                Console.WriteLine("Book deleted successfully.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
    
}