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
        public Form1()
        {
            InitializeComponent();
            Link root = new Link();
            List<String> str = new List<String>();
            List<Link> lnk = new List<Link>();
            myGUI = new StudentGUI(this, new TestProcessing(new Link()));
            TestProcessing GameTest = new TestProcessing(root);
            str = GameTest.getAnswers();


            //TODO заполнение дерева линков и корректное создание TestProcessing
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        internal void setMainText(string text)
        {
            mainTextLable.Text = text;
        }

        internal void addButtons(List<Button> buts)
        {
            for (int i = 50; i < buts.Count * 50; i = i + 50)
            {
                //if (buts.Count==2)
                buts[i].Location = new Point(Width-i, Height-i);
                Controls.Add(buts[i]);
                
            }
        }
    }
}
