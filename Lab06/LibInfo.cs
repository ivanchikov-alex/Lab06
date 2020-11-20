using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class LibInfo:Library
    {
        public int BooksAmount()
        {
            return base.Books.Count;
        }
        public int JournalssAmount()
        {
            return base.Journals.Count;
        }
        public int ManualsAmount()
        {
            return base.Manuals.Count;
        }

        public void BooksList(int year)
        {
            for(int i =0;i< base.Books.Count;i++)
            {
                if (base.Books[i].Info.ReleaseYear > year)
                Console.WriteLine(base.Books[i].BookName);
            }
        }

        public int TotalCost()
        {
            int totalCost = 0;
            for (int i = 0; i < Books.Count; i++)
                totalCost += Books[i].Info.Cost;
            for (int i = 0; i < Journals.Count; i++)
                totalCost += Journals[i].Info.Cost;
            for (int i = 0; i < Manuals.Count; i++)
                totalCost += Manuals[i].Info.Cost;
            return totalCost;
        }
    }
}
