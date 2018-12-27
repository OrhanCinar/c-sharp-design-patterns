using System;
using System.Windows.Forms;

namespace MementoPattern
{
    public partial class Form1 : Form
    {
        Originator originator;
        CareTaker careTaker;
        int saveFiles = 0;
        int currentArticle = 0;

        public Form1()
        {
            InitializeComponent();

            originator = new Originator();
            careTaker = new CareTaker();

            btnRedo.Click += BtnRedo_Click;
            btnSave.Click += BtnSave_Click;
            btnUndo.Click += BtnUndo_Click;

            btnUndo.Enabled = false;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string textArea = lbText.Text;
            originator.Set(textArea);

            careTaker.AddMemento(originator.StoreInMemento());

            saveFiles++;
            currentArticle++;

            btnUndo.Enabled = true;
            Console.WriteLine(string.Format("Save Files {0}", saveFiles));
        }

        private void BtnUndo_Click(object sender, EventArgs e)
        {
            if (currentArticle >= 1)
            {
                currentArticle--;

                string prevText = originator.restoreFromMemento(careTaker.GetMemento(currentArticle));

                lbText.Text = prevText;

                btnRedo.Enabled = true;
            }
        }

        private void BtnRedo_Click(object sender, EventArgs e)
        {
            if (currentArticle <= 0)
            {
                btnUndo.Enabled = false;
            }

            if ((saveFiles - 1) > currentArticle)
            {
                currentArticle++;

                string textArea = originator.restoreFromMemento(careTaker.GetMemento(currentArticle));
                //originator.Set(textArea);
                lbText.Text = textArea;
                btnUndo.Enabled = true;
            }
            else
            {
                btnRedo.Enabled = false;
            }
        }
    }
}
