using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SingletonPattern
{
    public class Singleton
    {
        private static Singleton firstInstance;

        string[] scrabbleLetters = {"a", "a", "a", "a", "a", "a", "a", "a", "a",
            "b", "b", "c", "c", "d", "d", "d", "d", "e", "e", "e", "e", "e",
            "e", "e", "e", "e", "e", "e", "e", "f", "f", "g", "g", "g", "h",
            "h", "i", "i", "i", "i", "i", "i", "i", "i", "i", "j", "k", "l",
            "l", "l", "l", "m", "m", "n", "n", "n", "n", "n", "n", "o", "o",
            "o", "o", "o", "o", "o", "o", "p", "p", "q", "r", "r", "r", "r",
            "r", "r", "s", "s", "s", "s", "t", "t", "t", "t", "t", "t", "u",
            "u", "u", "u", "v", "v", "w", "w", "x", "y", "y", "z",};


        private LinkedList<string> letterList;

        static bool firstThread = true;


        private Singleton()
        {
            //shuffle array
            Random rnd = new Random();
            letterList = new LinkedList<string>(scrabbleLetters.OrderBy(c => rnd.Next()).ToArray());
        }

        public static Singleton getInstance()
        {
            if (firstInstance == null)
            {
                if (firstThread)
                {
                    firstThread = false;

                    Thread.Sleep(1000);

                }

                firstInstance = new Singleton();
            }

            return firstInstance;
        }


        public LinkedList<string> getLetterList()
        {
            return firstInstance.letterList;
        }

        public LinkedList<string> getTiles(int howManyTiles)
        {
            LinkedList<string> tilesToSend = new LinkedList<string>();

            for (int i = 0; i <= howManyTiles; i++)
            {
                var node = firstInstance.letterList.First;

                firstInstance.letterList.RemoveFirst();
                tilesToSend.AddLast(node);

            }

            return tilesToSend;
        }
    }
}
