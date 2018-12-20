namespace CompositePattern
{
    public class DiscJockey
    {
        SongComponent songList;

        public DiscJockey(SongComponent newSongList)
        {
            songList = newSongList;
        }

        public void GetSongList()
        {
            songList.DisplaySongInfo();
        }
    }
}
