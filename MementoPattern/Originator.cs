using System;

namespace MementoPattern
{
    public class Originator
    {
        string article;

        public void Set(string newArtice)
        {
            article = newArtice;
            Console.WriteLine($"From Originator : Currence Versin of Article\n {newArtice} \n");
        }

        public Memento StoreInMemento()
        {
            Console.WriteLine("From Originator: Saving to Memento");

            return new Memento(article);
        }

        public string restoreFromMemento(Memento memento)
        {
            article = memento.GetSavedArticle();

            Console.WriteLine($"From Originator: Previous Article Saved in Memento\n {article} \n");

            return article;
        }
    }
}
