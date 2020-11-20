using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public class PublishingHouse
    {
        public string PublisherName { get; set; }
    }
    public abstract class PrintedEdition : PublishingHouse
    {
        public enum EditionType { Journal, Book, Manual }
        public struct EditionInfo
        {
            public int ReleaseYear { get; set; }
            public int Cost { get; set; }
        }
        public EditionInfo Info = new EditionInfo();
    }
    public partial class Journal : PrintedEdition, IShow
    {
        public EditionType Type { get; protected set; }
        public string JournalName { get; set; }

        public Journal()
        {
            Type = EditionType.Journal;
        }
        public Journal(string name, int releaseYear, int cost)
        {
            PublisherName = base.PublisherName;
            Info.Cost = cost;
            Info.ReleaseYear = releaseYear;
            JournalName = name;
        }
        public Journal(string name, string publisherName, int releaseYear, int cost)
        {
            Info.Cost = cost;
            Info.ReleaseYear = releaseYear;
            JournalName = name;
        }
    }
    public partial class Book : PrintedEdition, IShow
    {
        public EditionType Type { get; protected set; }
        public string BookName { get; set; }
        public Book()
        {
            Type = EditionType.Book;
        }
    }
    public partial class Manual : PrintedEdition, IShow
    {
        public EditionType Type { get; protected set; }
        public string ManualName { get; set; }
        public Manual()
        {
            Type = EditionType.Manual;
        }
    }
}
