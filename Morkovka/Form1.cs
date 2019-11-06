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
            Answer a1, a2, a3;
            Question q1, q2;
            List<String> str = new List<String>();
            List<Link> lnk = new List<Link>();


            a1 = new Answer("A1");
            a2 = new Answer("A2");
            a3 = new Answer("A3");


            str.Add("a1");
            str.Add("a2");
            lnk.Add(a1);
            lnk.Add(a2);
            q1 = new Question("q1", str, lnk);


            str.Clear();
            lnk.Clear();


            str.Add("a3");
            str.Add("q1");
            lnk.Add(a3);
            lnk.Add(q1);
            q2 = new Question("q2", str, lnk);
            myGUI = new StudentGUI(this, new TestProcessing(q2));
            //TODO заполнение дерева линков и корректное создание TestProcessing
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        internal void setMainText(string text)
        {
            Controls.Remove(mainTextLable);
            mainTextLable = new Label();
            mainTextLable.Name = "MainText";
            mainTextLable.Location = new Point(100, 100);
            mainTextLable.Font = new Font(FontFamily.GenericSansSerif, 15);
            mainTextLable.Text = text;
            Controls.Add(mainTextLable);
            
        }

        internal void addButtons(List<Button> buts)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible =  false;
            myGUI.start();
        }
    }
}
