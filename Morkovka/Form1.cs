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
        TestProcessing GameTest;

        public Form1()
        {
            InitializeComponent();
            Link root = FillQuestions();
            GameTest = new TestProcessing(root);
            var answers = GameTest.getAnswers();
            foreach (var a in answers) { richTextBox2.Text += "\n" + a; }
        }

        private Link FillQuestions()
        {
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

            return q2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";

            GameTest.goNext(richTextBox3.Text);
            var answers = GameTest.getAnswers();
            
            foreach (var a in answers)
            {
                richTextBox2.Text += "\n" + a;
            }
            //TODO: возможность в гейм тестинге получить доступ к текущему линку 
            
            richTextBox3.Text = "";
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
