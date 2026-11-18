namespace c_basics_session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Assignment 2 Q 5
            //int pages = 300;
            //double result = pages;

            //Console.WriteLine(result);
            #endregion

            #region Assignment 2 Q 6
            //double price = 49.99;
            //int result = (int)price;

            //Console.WriteLine(result);
            #endregion

            #region Assignment 2 Q 7
            //String pagesText = "464";
            //int pages = Convert.ToInt32 (pagesText);

            //Console.WriteLine(pages);
            #endregion

            #region Assignment 2 Q 8

            //string yearText = "2023";
            //int year = int.Parse(yearText);

            //Console.WriteLine(year);

            //string badText = "abc";

            //if (int.TryParse(badText, out int result))
            //{
            //    Console.WriteLine(result);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion

            #region Assignment 2 Q 9
            //int pages = 464;

            //string result = pages.ToString();

            //Console.WriteLine(result);
            //Console.WriteLine(result.GetType());
            #endregion

            #region Assignment 2 Q 10
            //int copies = 100;

            //object obj = copies;

            //int newCopies = (int)obj;

            //Console.WriteLine(obj);
            //Console.WriteLine(newCopies);
            #endregion

            #region Assignment 2 Q 11
            //int? year = null;

            //Console.WriteLine(year.HasValue);

            //year = 2023;

            //Console.WriteLine(year.Value);
            #endregion

            #region Assignment 2 Q 12
            //string? reviewer = null;

            //Console.WriteLine(reviewer == null);
            #endregion

            #region Assignment 2 Q 13
            //Book? book = null;

            //Console.WriteLine(book?.title);
            #endregion

            #region Assignment 2 Q 14
            //string? title = null;

            //Console.WriteLine(title ?? "Untitled");

            //title ??= "Untitled";

            //Console.WriteLine(title);
            #endregion

            #region Assignment 2 Q 15
            //string? name = "Ahmed";

            //string confirmedName = name!;

            //Console.WriteLine(confirmedName);
            #endregion

            //*********************************************************************

            #region Assignment 3 Q 8
            //int pages = 464;

            //if (pages > 300)
            //{
            //    Console.WriteLine("Long Book");
            //}
            //else
            //{
            //    Console.WriteLine("Short Book");
            //}
            #endregion

            #region Assignment 3 Q 9
            //int pages = 464;
            //bool isAvailable = true;

            //if (pages > 300 && isAvailable)
            //{
            //    Console.WriteLine("You can borrow this book");
            //}
            #endregion

            #region Assignment 3 Q 10
            //string title = "Refactoring";

            //switch (title)
            //{
            //    case "Clean Code":
            //        Console.WriteLine("Great choice!");
            //        break;

            //    case "Refactoring":
            //        Console.WriteLine("Nice pick!");
            //        break;

            //    default:
            //        Console.WriteLine("Never heard of it");
            //        break;
            //}
            #endregion

            #region Assignment 3 Q 11
            //int pages = 464;

            //string sizeLabel = pages > 300 ? "Long Book" : "Short Book";

            //Console.WriteLine(sizeLabel);
            #endregion

            #region Assignment 3 Q 12
            //  string[] books =
            //{
            //  "Clean Code",
            //  "The Pragmatic Programmer",
            //  "Refactoring"
            //};

            //  for (int i = 0; i < books.Length; i++)
            //  {
            //      Console.WriteLine($"{i + 1}. {books[i]}");
            //  }
            #endregion

            #region Assignment 3 Q 13
            //string[] books =
            //{
            // "Clean Code",
            // "The Pragmatic Programmer",
            // "Refactoring"
            //};

            //int i = 0;

            //while (i < books.Length)
            //{
            //    Console.WriteLine(books[i]);
            //    i++;
            //}
            #endregion

            #region Assignment 3 Q 14
            //int i = 0;

            //do
            //{
            //    Console.WriteLine("Checking book...");
            //    i++;
            //}
            //while (i < 3);
            #endregion

            #region Assignment 3 Q 15
            //string[] books =
            //{
            // " Clean Code",
            // " The Pragmatic Programmer",
            // " Refactoring"
            //};

            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);
            //}
            #endregion

            #region Assignment 3 Q 16
            //string[] books =
            //{
            // "Clean Code",
            // "The Pragmatic Programmer",
            // "Refactoring"
            //};

            //foreach (string book in books)
            //{
            //    Console.WriteLine(book);

            //    if (book == "Refactoring")
            //    {
            //        break;
            //    }
            //}
            #endregion

            #region Assignment 3 Q 17
            //string[] books =
            //{
            // "Clean Code",
            // "The Pragmatic Programmer",
            // "Refactoring"
            //};

            //foreach (string book in books)
            //{
            //    if (book == "The Pragmatic Programmer")
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(book);
            //}
            #endregion

            #region  Assignment 3 Q 18
            //string[] books =
            //{
            // "Clean Code",
            // "The Pragmatic Programmer",
            // "Refactoring"
            //};

            //PrintFirstBook(books);
            #endregion

        }

        class Book
        {
            public String title;
        }

        static void PrintFirstBook(string[] books)    // For Question 18 ***
        {
            if (books.Length == 0)
            {
                return;
            }

            Console.WriteLine(books[0]);
        }
    }
}
