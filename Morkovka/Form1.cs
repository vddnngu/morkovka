﻿using System;
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
            myGUI = new StudentGUI(this, new TestProcessing(new Link()));
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
            
        }
    }
}
