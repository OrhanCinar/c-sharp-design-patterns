using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SongComponent industrialMusic = new SongGroup("Industrial","ind desc");

            SongComponent heavyMetalMusic = new SongGroup("Heavy Metal", "heavy metal desc");

            SongComponent dubstepMusic = new SongGroup("Dubstep", "dubstep desc");

            SongComponent everySong = new SongGroup("Song List", "Every Song Available");

            everySong.Add(industrialMusic);

            industrialMusic.Add(new Song("Head Like a Hole", "NIN", 1990));
            industrialMusic.Add(new Song("Headhunder", "Front 242", 1988));

            industrialMusic.Add(dubstepMusic);

            dubstepMusic.Add(new Song("Centipede", "Knfie Part", 2012));
            dubstepMusic.Add(new Song("Tetris", "Doctor P", 2011));

            everySong.Add(heavyMetalMusic);

            heavyMetalMusic.Add(new Song("War Pigs", "Black Sabath", 1970));
            heavyMetalMusic.Add(new Song("Ace of Spades", "Motorhead", 1980));

            DiscJockey dj = new DiscJockey(everySong);

            dj.GetSongList();

            Console.ReadKey();
        }
    }
}
