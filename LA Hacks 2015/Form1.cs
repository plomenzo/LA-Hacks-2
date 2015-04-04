using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LA_Hacks_2015
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t2");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void pictureBox3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

       

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void introButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t2");
            level_1_Button.Enabled = true;
        }

        private void level_1_Button_Click(object sender, EventArgs e)
        {
            level_2_Button.Enabled = true;
        }

        private void exitButton2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void backtoMM2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t1");
        }

        private void Skip2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t3");
        }
    }
}
