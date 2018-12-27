namespace MementoPattern
{
    public class Memento
    {
        string article;

        public Memento(string articleSave)
        {
            article = articleSave;
        }

        public string GetSavedArticle()
        {
            return article;
        }
    }
}
