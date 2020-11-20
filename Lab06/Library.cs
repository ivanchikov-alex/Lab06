using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class Library
    {
        protected List<Book> Books = new List<Book>();
        protected List<Journal> Journals = new List<Journal>();
        protected List<Manual> Manuals = new List<Manual>();

        public void AddLiterature(PrintedEdition literature)
        {
            if (literature is Book)
                Books.Add(literature as Book);
            if (literature is Journal)
                Journals.Add(literature as Journal);
            if (literature is Manual)
                Manuals.Add(literature as Manual);
        }
        public void DelLiterature(PrintedEdition literature)
        {
            if (literature is Book)
                Books.Remove(literature as Book);
            if (literature is Journal)
                Journals.Remove(literature as Journal);
            if (literature is Manual)
                Manuals.Remove(literature as Manual);
        }

        public void ToConsole()
        {
            Console.WriteLine("Книги");
            for (int i=0;i < Books.Count;i++)
                Console.WriteLine(Books[i].BookName);
            Console.WriteLine("\nЖурналы");
            for (int i = 0; i < Journals.Count; i++)
                Console.WriteLine(Journals[i].JournalName);
            Console.WriteLine("\nУчебники");
            for (int i = 0; i < Manuals.Count; i++)
                Console.WriteLine(Manuals[i].ManualName);
        }
    }
}
