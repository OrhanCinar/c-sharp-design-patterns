using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace FlyweightPattern
{
    public class RectFactory
    {
        static readonly Dictionary<Color, MyRect> rectsByColor = new Dictionary<Color, MyRect>();

        public static MyRect GetRect(Color color)
        {
            MyRect rect = rectsByColor.FirstOrDefault(c => c.Key == color).Value;

            if (rect == null)
            {
                rect = new MyRect(color);
                rectsByColor.Add(color, rect);
            }

            return rect;
        }
    }
}
