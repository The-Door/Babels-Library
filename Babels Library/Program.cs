using Bibliotek;
using System;
using System.Collections.Generic;

namespace Main
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Välkommen till Babels Bibliotek");
                Console.WriteLine("För att navigera biblioteket bör du känna till ett par funktioner, de är:");

                Console.WriteLine("Lägg till en bok (LB), ta bort en bok (RM), visa biblioteket (VB), låna en bok (L),");
                Console.WriteLine("Lämna tillbaka en bok (RE)");
                Console.WriteLine("Om du vill avsulta programmet tryck 'X'");
                Console.Write("Din inmatning: ");
                string ui = Console.ReadLine();

                if (ui == "LB" || ui == "lb")
                {
                    BookManage.BookAdd();
                }
                else if (ui == "RM" || ui == "rm")
                {
                    BookManage.BookRemove();
                }
                else if (ui == "VB" || ui == "vb")
                {
                    BookManage.LibraryInfo();
                }
                else if (ui == "x" || ui == "X")
                {
                    Environment.Exit(0);
                }
                else if (ui == "l" || ui == "L")
                {
                    BookManage.Loan();
                }
                else if (ui == "RE"||ui=="re")
                {
                    BookManage.Return();
                }
                else
                {
                    Console.Clear();
                }

            }
        }

    }
}