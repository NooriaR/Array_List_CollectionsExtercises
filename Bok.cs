using System;
using System.Collections.Generic;
using System.Text;

namespace MethodCollections
{
    internal class Bok
    {
        //Skapa en klass Bok med egenskaper: Title(string), Author(string), YearPublished(int)
        //attributer
        public string Title { get; set; }
        public string Author { get; set; }

        public int YearPublished { get; set; }

        //En metod som skriver ut bokens information i konsolen.
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Titel: {Title}, Författare: {Author}, Årtal: {YearPublished}");
        }

    }
}

