using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06
{
    public partial class Journal
    {
        public override string ToString()
        {
            return EditionType.Journal + JournalName;
        }
        public override bool Equals(object obj)
        {
            return ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().Length;
        }
        public string ShowInfo()
        {
            return "Тип издания: " + Type + "\nНазвание: " + JournalName;
        }
    }

    public partial class Book
    {
        public override string ToString()
        {
            return EditionType.Book + BookName;
        }
        public override bool Equals(object obj)
        {
            return ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().Length;
        }

        public string ShowInfo()
        {
            return "Тип издания: " + Type + "\nНазвание: " + BookName;
        }
    }

    public partial class Manual
    {
        public override string ToString()
        {
            return EditionType.Manual + ManualName;
        }
        public override bool Equals(object obj)
        {
            return ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return ToString().Length;
        }

        public string ShowInfo()
        {
            return "Тип издания: " + Type + "\nНазвание: " + ManualName;
        }
    }
}
