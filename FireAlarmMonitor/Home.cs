using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarmMonitor
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FireDetails fd1 = new FireDetails();
            this.Hide();
            fd1.Show();
        }

        private void LoadNextImage()
        {
            if (P1.Visible == true)
            {
                P1.Visible = false;
                P3.Visible = true;
            }

            else if (P3.Visible == true)
            {
                P3.Visible = false;
                P2.Visible = true;
            }

            else if (P2.Visible == true)
            {
                P2.Visible = false;
                P4.Visible = true;
            }

            else if (P4.Visible == true)
            {
                P4.Visible = false;
                P1.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
