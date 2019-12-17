using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morkovka
{
    public partial class Form1 : Form
    {
        Label mainTextLable;
        StudentGUI myGUI;
        List<Button> buttonsForRemove = new List<Button>();
        int j = 0;
        public Form1()
        {
            InitializeComponent();
            mainTextLable = new Label();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        internal void setMainText(string text)
        {
            mainTextLable.Location = new Point((int)(Width * 0.07), (int)(Height / 3));
            Controls.Add(mainTextLable);
            mainTextLable.Text = text;
        }

        internal void removeButtons()
        {
            foreach (var it in buttonsForRemove)
            {
                Controls.Remove(it);
            }
        }
        internal void addButtons(List<Button> buts)
        {
            removeButtons();
            var startPoint = new Point((int)(Width * 0.07), (int)(Height / 2));
            int buttonWidth = (int)(Width * 0.2);
            int buttonHeigth = (int)(Height * 0.1);
            for (int i = 0; i < buts.Count; i++)
            {
                buts[i].Location = new Point((int)(startPoint.X + i * buttonWidth), startPoint.Y * (i / 4 + 1));
                buts[i].Width = buttonWidth;
                buts[i].Height = buttonHeigth;
                this.Controls.Add(buts[i]);
                buttonsForRemove.Add(buts[i]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myGUI.start();
        }
    }
}
