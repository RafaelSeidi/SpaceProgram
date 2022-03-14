using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Parent = pictureBox2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            pictureBox1.Load("fogueteC.png");
            if (pictureBox1.Top < 0)
            {
                pictureBox1.Top = 255;
                pictureBox2.Load("isso.png");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            pictureBox1.Load("fogueteE.png");
            if (pictureBox1.Left < 0)
            {
                pictureBox1.Left = 1016;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            pictureBox1.Load("fogueteD.png");
            if (pictureBox1.Left > 1016)
            {
                pictureBox1.Left = 0;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            pictureBox1.Load("fogueteB.png");
            if (pictureBox1.Top > 255)
            {
                pictureBox1.Top = 0;
                pictureBox2.Load("elliptical_elegance.jpg");
            }
        }
    }
}
