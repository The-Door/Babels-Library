using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    class BookManage
    {

        private static List<Book> dataBase = new List<Book>();



        public static void BookAdd()
        {

            Console.Write("Hur många böcker vill du lägga till? ");
            int numberOfBooks;

            while (!int.TryParse(Console.ReadLine(), out numberOfBooks) || numberOfBooks <= 0)
            {
                Console.WriteLine("Mata in ett heltal större än noll!");
                Console.Write("Hur många böcker vill du lägga till? ");
            }

            for (int i = 0; i < numberOfBooks; i++)
            {
                Console.WriteLine($"\nMata in detaljer för bok {i + 1}:");

                Console.Write("Mata in bokens titel: ");
                var title = Console.ReadLine();

                Console.Write("Mata in bokens författare: ");
                var author = Console.ReadLine();

                int pages;
                Console.Write("Mata in bokens sidor: ");
                while (!int.TryParse(Console.ReadLine(), out pages) || pages <= 0)
                {
                    Console.WriteLine("Mata in ett heltal större än noll!");
                    Console.Write("Mata in bokens sidor: ");
                }

                bool loan = false;

                Book book = new Book(title, author, pages, loan);
                dataBase.Add(book);
            }

            Console.Clear();
        }


        public static void BookRemove()
        {
            Console.WriteLine("Vilken bok vill du ta bort? ");
            string removeBook = Console.ReadLine();

            for (int i = 0; i < dataBase.Count; i++)
            {
                if (removeBook == dataBase[i].title)
                {
                    Console.WriteLine($"{dataBase[i].title} har tagits bort från biblioteket.");
                    dataBase.RemoveAt(i);
                }
            }

            Console.ReadKey();
            Console.Clear();
        }


        public static void Loan()
        {

            Console.WriteLine("Vilken bok vill du ta låna? ");
            
            
            string loanBook = Console.ReadLine();


            for (int i = 0; i < dataBase.Count; i++)
            {
                if (loanBook == dataBase[i].title)
                {
                    dataBase[i].loan = true;
                    Console.WriteLine("Du har lånat: " + dataBase[i].title);
                }
                else
                {
                    Console.WriteLine("Boken finns inte i biblioteket eller så har du stavat fel!");
                }
            }

            Console.ReadKey();
            Console.Clear();

        }

        public static void Return()
        {

            Console.WriteLine("Vilken bok vill du lämna tillbaka? ");

            string returnBook = Console.ReadLine();

            for (int i = 0; i < dataBase.Count; i++)
            {
                if (returnBook == dataBase[i].title)
                {
                    dataBase[i].loan = false;
                    Console.WriteLine("Du har lämnat tillbaka: " + dataBase[i].title);
                }
                else
                {
                    Console.WriteLine("Boken finns inte i biblioteket eller så har du stavat fel!");
                }
            }
            Console.ReadKey();
            Console.Clear();
        }





        public static void LibraryInfo()
        {
            Console.WriteLine();
            Console.WriteLine("Du har " + dataBase.Count + " böcker.");
            Console.WriteLine("De är:");
            foreach (var book in dataBase)
            {
                string status;
                switch (book.loan)
                {
                    case true:
                        status = "Boken är utlånad.";
                        break;
                    case false:
                        status = "Boken finns tillgänglig";
                        break;
                }



                Console.WriteLine($"Titel: {book.title}, Författare: {book.author}, Sidor: {book.pages}, status: {status}");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
