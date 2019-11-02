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
            GameTest = new TestProcessing(root);
            var answers = GameTest.getAnswers();
            var CurrentQuest = GameTest.getCurLinkText();
            foreach (var a in answers) { richTextBox2.Text += "\n" + a; }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var CurrentQuest = GameTest.getCurLinkText();
            richTextBox1.Text += CurrentQuest;

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
            var CurrentQuest = GameTest.getCurLinkText();
            richTextBox1.Text += CurrentQuest;
            richTextBox3.Text = "";

        }
    }
}
