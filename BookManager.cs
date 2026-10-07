using System;
using System.Collections.Generic;
using System.Text;

namespace MethodCollections
{
    internal class BookManager
    {
        public List<Bok> allaBöckerIHelaBiblioteket = new List<Bok>();

        public void AddBookMetod()
        {
            Bok bookAttLäggaTillIListan = new Bok();
            Console.WriteLine("Ange titel:");
            bookAttLäggaTillIListan.Title = Console.ReadLine()!;
            Console.WriteLine("Ange författare:");
            bookAttLäggaTillIListan.Author = Console.ReadLine()!;
            Console.WriteLine("Ange årtal:");
            bookAttLäggaTillIListan.YearPublished = int.Parse(Console.ReadLine()!);

            // LÄGG TILL BOKEN I LISTAN
            allaBöckerIHelaBiblioteket.Add(bookAttLäggaTillIListan);

            bookAttLäggaTillIListan.DisplayBookInfo();

            Console.WriteLine("Tryck enter för att komma tillbaka till meny");
            Console.ReadLine();
        }

        public void ShowAllBooks()
        {
            foreach (Bok book in allaBöckerIHelaBiblioteket)
            {
                book.DisplayBookInfo();
            }
            Console.WriteLine("Tryck enter för att komma tillbaka till meny");
            Console.ReadLine();
        }

        public void SearchBookByTitle()
        {
            // FRÅGA ANVÄNDAREN OM TITELN DE VILL SÖKA EFTER
            Console.WriteLine("Ange titeln på boken du vill söka efter:");
            string titleToSearch = Console.ReadLine()!;

            //allaBöckerIHelaBiblioteket.First().Title = titleToSearch; --- LINQ
            List<Bok> allaBöckerSomInnehållerMatchandeTitle = allaBöckerIHelaBiblioteket.FindAll(book => book.Title.ToLower().Contains(titleToSearch.ToLower()));
            allaBöckerSomInnehållerMatchandeTitle.ForEach(book => book.DisplayBookInfo());
            Console.WriteLine("Tryck enter för att komma tillbaka till meny");
            Console.ReadLine();
        }
    }
}