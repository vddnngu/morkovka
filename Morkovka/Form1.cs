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
        int j = 0;
        public Form1()
        {
            InitializeComponent();
            mainTextLable = new Label();
            GameTest firstTest = new GameTest();
            myGUI = new StudentGUI(this, firstTest.myTP);
            TestProcessing GameTest = firstTest.myTP;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void but_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello", "Welcome");
        }

        internal void setMainText(string text)
        {
            mainTextLable.Location = new Point(200, 200);
            Controls.Add(mainTextLable);
            mainTextLable.Text = text;
        }

        internal void addButtons(List<Button> buts)
        {
            for (int i = 1; i < buts.Count +1; i ++)
            {
                //if (buts.Count==2)
                buts[i-1].Location = new Point(Width/2-i*100 + j++*10, Height/2);
                this.Controls.Add(buts[i-1]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myGUI.start();
        }
    }
}
