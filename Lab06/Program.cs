using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    public class Printer
    {
        public static void IAmPrinting(Person newPers)
        {
            if (newPers is Author)
            {
                Console.WriteLine(newPers.ToString());
            }
            else
            {
                Author newAuthor = newPers as Author;
                Console.WriteLine(newPers.ToString());
            }
        }

        public static void IAmPrinting(PrintedEdition printedEdition)
        {
            Console.WriteLine(printedEdition.ToString());
        }
    }
    public abstract class Person
    {
        public enum Talents { JournalWriter, BookWriter, ManualWriter, Talentless }
        protected string PersonName { get; set; }

        public Person(string name)
        {
            PersonName = name;
        }
        public virtual void ChangePerson(string newName)
        {
            PersonName = newName;
        }
    }
    public sealed class Author : Person, IShow
    {
        public string Nickname { get; set; }
        public Talents Talent { get; set; }
        public Author(string name, string nickame = "") : base(name)
        {
            PersonName = name;
            Nickname = nickame;
            Talent = Talents.Talentless;
        }
        public void ChangePerson(string newName, Person.Talents talent)
        {
            base.ChangePerson(newName);
            Talent = talent;
        }

        public override void ChangePerson(string nickname)
        {
            Nickname = nickname;
        }
        public string ShowInfo()
        {
            return "Имя: " + PersonName + "\nПсевдоним: " + Nickname;
        }
    }
    public interface IShow
    {
        public string ShowInfo();
    }

    class Program
    {
        static void Main(string[] args)
        {
            LibInfo lib = new LibInfo();
            lib.FromTXT("LIBINFO.txt");
            lib.BooksFromJSON("BOOKS.json");

            Console.WriteLine($"Количество учебников {lib.ManualsAmount()}");
            Console.WriteLine($"Цена всех печатных изданий {lib.TotalCost()}");
            Console.WriteLine("Книги изданные после 2014:");
            lib.BooksList(2014);
        }
    }
}
