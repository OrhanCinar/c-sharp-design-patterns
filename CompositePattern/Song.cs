using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Song : SongComponent
    {
        string songName;
        string bandName;
        int releaseYear;

        public Song(string newSongName, string newBandName, int newReleaseYear)
        {
            songName = newSongName;
            bandName = newBandName;
            releaseYear = newReleaseYear;
        }
    
        public string GetSongName()
        {
            return songName;
        }

        public override string GetBandName()
        {
            return bandName;
        }

        public override int GetReleaseYear()
        {
            return releaseYear;
        }

        public override  void DisplaySongInfo()
        {
            Console.WriteLine($"{GetSongName()} was recored by {GetBandName()} in {GetReleaseYear()}");           
        }

    }
}
