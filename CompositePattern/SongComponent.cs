using System;

namespace CompositePattern
{
    public abstract class SongComponent
    {
        public virtual void Add(SongComponent newSongComponent)
        {
            throw new Exception("Not SUpported");
        }

        public virtual void Remove(SongComponent newSongComponent)
        {
            throw new Exception("Not SUpported");
        }

        public virtual SongComponent GetComponent(int componentIndex)
        {
            throw new Exception("Not SUpported");
        }

        public virtual string GetBandName()
        {
            throw new Exception("Not SUpported");
        }

        public virtual int GetReleaseYear()
        {
            throw new Exception("Not SUpported");
        }

        public virtual void DisplaySongInfo()
        {
            throw new Exception("Not SUpported");
        }
    }
}
