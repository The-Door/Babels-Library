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
                Console.WriteLine("Tjenare");
                Console.WriteLine("Vill du lägga till en bok (LB), ta bort en bok (RM) eller visa biblioteket (VB)? Om du vill avsulta programmet tryck 'X'");
                Console.WriteLine("Om du vill låna ut en bok, skriv (L)");
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
                else
                {
                    Console.Clear();
                }

            }
        }

    }
}