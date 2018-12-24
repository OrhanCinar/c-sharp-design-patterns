using System.Drawing;

namespace FlyweightPattern
{
    public class MyRect
    {
        private Color color;
        private int x, y, x2, y2;


        public MyRect(Color color)
        {
            this.color = color;
        }

        public void Draw(Graphics g, int upperX, int upperY, int lowerX, int lowerY)
        {
            var pen = new SolidBrush(color);
            g.FillRectangle(pen, upperX, upperY, lowerX, lowerY);
        }

        //public MyRect(Color color, int upperX, int upperY, int lowerX, int lowerY)
        //{
        //    this.color = color;
        //    x = upperX;
        //    y = upperY;
        //    x2 = lowerX;
        //    y2 = lowerY;
        //}


        //public void Draw(Graphics g)
        //{
        //    var pen = new Pen(new SolidBrush(color));
        //    g.DrawRectangle(pen, new Rectangle(x, y, x2, y2));
        //}
    }
}
