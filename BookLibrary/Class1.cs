namespace BookLibrary
{
    public class Book
        {
            // Properties
            public int BookID { get; set; }
            public string BookName { get; set; }
            public string ISBNNo { get; set; }
            public double Price { get; set; }
            public string Publisher { get; set; }
            public int NumberOfPages { get; set; }
            public string Language { get; set; }
            public string LoT { get; set; }
            public string Summary { get; set; }

            // Constructor
            public Book(int id, string name, string isbn, double price, string publisher,
                        int pages, string language = "English", string lot = "Technical", string summary = "")
            {
                BookID = id;
                BookName = name;
                ISBNNo = isbn;
                Price = price;
                Publisher = publisher;
                NumberOfPages = pages;
                Language = language;
                LoT = lot;
                Summary = summary;
            }

            //Get book details from user
            public void GetDetails()
            {

                bool isInputValid = false;
                while (!isInputValid)
                {
                    Console.WriteLine("Enter Book ID : ");
                    string bookId = Console.ReadLine();

                    bool isIdInt = int.TryParse(bookId, out int id);

                    
                    if (isIdInt && bookId.Length == 5)
                    {
                        BookID = id;
                        isInputValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Id is invalid.");
                    }
                }

                Console.WriteLine("Enter Book Name: ");
                BookName = Console.ReadLine();

                Console.WriteLine("Enter ISBN Number: ");
                ISBNNo = Console.ReadLine();

                Console.WriteLine("Enter Price: ");
                Price = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Publisher: ");
                Publisher = Console.ReadLine();

                Console.WriteLine("Enter Number of Pages: ");
                NumberOfPages = Convert.ToInt32(Console.ReadLine());

               
                Console.WriteLine("Enter Language - Default is English");
                
                Language = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(Language))
                {
                    Language = "English";
                }


            bool isLotValid;
                    Console.WriteLine("Enter LoT (.NET, Java, IMS, V&V, BI, RDBMS): ");
                    LoT = Console.ReadLine();

                    // validating lot values
                   
                    if (LoT.ToLower() == ".net" || LoT.ToLower() == "java" || LoT.ToLower() == "ims" || LoT.ToLower() == "v&v" || LoT.ToLower() == "bi" || LoT.ToLower() == "rdbms")
                    {
                        isLotValid = true;
                    }
                    else
                    {
                //if no lot values is present, then default it is set to technical
                   isLotValid = true;
                    LoT = "Technical";
                     
                       
                    }

            Console.WriteLine("Enter Book summary:");
            Summary = Console.ReadLine();
        }
        }
    
}