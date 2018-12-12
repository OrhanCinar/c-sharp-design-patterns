using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton newInstance = Singleton.getInstance();

            Console.WriteLine($"Instance Id : {newInstance.GetHashCode()}");
                   
            Console.WriteLine(PrintLinkedList(newInstance.getLetterList()));

            LinkedList<string> playerOneTiles = newInstance.getTiles(7);

            Console.WriteLine($"Player 1 : {PrintLinkedList(playerOneTiles)}");

            Console.WriteLine(PrintLinkedList(newInstance.getLetterList()));


            //Player 2
            Singleton instanceTwo = Singleton.getInstance();

            Console.WriteLine($"Instance Id : {instanceTwo.GetHashCode()}");

            Console.WriteLine(PrintLinkedList(newInstance.getLetterList()));

            LinkedList<string> playerTwoTiles = newInstance.getTiles(7);

            Console.WriteLine($"Player 2 : {PrintLinkedList(playerTwoTiles)}");

            Console.ReadKey();
        }

        private static string PrintLinkedList(LinkedList<string> list)
        {
            var sb = new StringBuilder();
            foreach (var item in list)
            {
                sb.Append(item + " ");
            }

            return sb.ToString();
        }
    }
}
