using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace LA_Hacks_2015
{
 
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Hide();
            InitializeComponent();

            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            

            Thread.Sleep(5000);

            t.Abort();
            this.Show();

        }



        public void SplashStart()
        {
            Application.Run(new SlashScreen());
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
            //level_1_Button.Enabled = true;
        }

        private void level_1_Button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t3");
            //level_2_Button.Enabled = true;
        }

        private void level_2_Button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t5");
            //level_2_Button.Enabled = true;
        }

        private void level_3_Button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t8");
            //level_2_Button.Enabled = true;
        }

        private void level_4_Button_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("t11");
            //level_2_Button.Enabled = true;
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

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "The Price Is Right - Manuela_s Blooper";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void t1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void level_2_Button_Click_1(object sender, EventArgs e)
        {

        }
    }
}
