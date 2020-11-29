using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;
using System.Linq;

namespace Lab06
{
    public class LibInfo:Library
    {
        public int BooksAmount()
        {
            return Books.Count;
        }
        public int JournalssAmount()
        {
            return Journals.Count;
        }
        public int ManualsAmount()
        {
            return Manuals.Count;
        }

        public void BooksList(int year)
        {
            for(int i =0;i< Books.Count;i++)
            {
                if (Books[i].Info.ReleaseYear > year)
                Console.WriteLine(Books[i].BookName);
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

        public void FromTXT(string path)
        {
            string bookname = "", temp;
            int cost = 0;
            int release = 0;
            StreamReader fread = new StreamReader(path);
            temp = fread.ReadLine();
            if (temp!=null && temp.ToLower() == "книги")
            {
                while (temp != "журналы"&& !fread.EndOfStream)
                {
                    bookname = fread.ReadLine();
                    cost = int.Parse(fread.ReadLine());
                    release = int.Parse(fread.ReadLine());
                    Books.Add(new Book { BookName = bookname, Info = { Cost = cost, ReleaseYear = release } });
                    temp = fread.ReadLine().ToLower();
                }
                while (temp != "учебники"&& !fread.EndOfStream)
                {
                    bookname = fread.ReadLine();
                    cost = int.Parse(fread.ReadLine());
                    release = int.Parse(fread.ReadLine());
                    Journals.Add(new Journal { JournalName = bookname, Info = { Cost = cost, ReleaseYear = release } });
                    temp = fread.ReadLine().ToLower();
                }
                while (!fread.EndOfStream)
                {
                    bookname = fread.ReadLine();
                    cost = int.Parse(fread.ReadLine());
                    release = int.Parse(fread.ReadLine());
                    Manuals.Add(new Manual { ManualName = bookname, Info = { Cost = cost, ReleaseYear = release } });
                }
            }
            else Console.WriteLine("Неверный формат");
            fread.Close();
        }

        public void BooksFromJSON(string path)
        {
            StreamReader fread = new StreamReader(path);
            LibInfo lib = new LibInfo();
            while (!fread.EndOfStream)
            {
                lib.AddLiterature(JsonSerializer.Deserialize<Book>(fread.ReadLine()));
            }
            fread.Close();
            //var result = Books.Union(lib.Books);
            for (int i = 0; i < lib.BooksAmount(); i++)
                Books.Add(lib.Books[i]);
        }
    }
}
