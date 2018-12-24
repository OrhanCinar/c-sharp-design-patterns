using System;
using System.Drawing;
using System.Windows.Forms;

namespace FlyweightPattern
{
    public partial class Form1 : Form
    {
        Button startDrawing;
        Panel drawingPanel = new Panel();
        int windowWidth = 1750;
        int windowHeight = 1024;

        Color[] shapeColor = { Color.Orange, Color.Red, Color.Yellow, Color.Blue, Color.Pink, Color.Cyan, Color.Magenta, Color.Black, Color.Gray };

        public Form1()
        {
            InitializeComponent();

            this.Width = windowWidth;
            this.Height = windowHeight;

            this.drawingPanel.Width = windowWidth;
            this.drawingPanel.Height = windowHeight;

            startDrawing = new Button
            {
                Text = "Draw",
                Height = 25,
                Width = 100
            };

            startDrawing.Click += StartDrawing_Click;


            this.Controls.Add(startDrawing);
            //  this.Controls.Add(drawingPanel);
        }

        private void StartDrawing_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            long startTime = DateTime.Now.Millisecond;


            for (int i = 0; i < 100000; i++)
            {
                MyRect rect = RectFactory.GetRect(GetRandColor());
                rect.Draw(g, getRandX(), getRandY(), getRandX(), getRandY());
            }

            long endTime = DateTime.Now.Millisecond;

            Console.WriteLine("That took " + (endTime - startTime));
        }

        Random random = new Random();

        private int getRandY()
        {

            double randInt = random.NextDouble();
            var value = (int)(randInt * windowWidth);

            return value;
        }

        private int getRandX()
        {

            double randInt = random.NextDouble();
            var value = (int)(randInt * windowWidth);

            return value;
        }

        private Color GetRandColor()
        {

            int randInt = random.Next(9);

            return shapeColor[randInt];
        }
    }
}
