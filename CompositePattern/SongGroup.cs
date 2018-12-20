using System;
using System.Collections;

namespace CompositePattern
{
    public class SongGroup : SongComponent
    {
        ArrayList songComponents = new ArrayList();

        string groupName;
        string groupDescription;

        public SongGroup(string newGroupName, string newGroupDescription)
        {
            groupName = newGroupName;
            groupDescription = newGroupDescription;
        }

        public string GetGroupName()
        {
            return groupName;
        }

        public string GetGroupDescription()
        {
            return groupDescription;
        }

        public override void Add(SongComponent newSongComponent)
        {
            songComponents.Add(newSongComponent);
        }

        public override void Remove(SongComponent newSongComponent)
        {
            songComponents.Remove(newSongComponent);
        }

        public override SongComponent GetComponent(int componentIndex)
        {
            return (SongComponent)songComponents[componentIndex];
        }

        public override void DisplaySongInfo()
        {
            Console.WriteLine(GetGroupName() + " " + GetGroupDescription() + "\n");

            foreach (SongComponent item in songComponents)
            {
                item.DisplaySongInfo();
            }
        }
    }
}
