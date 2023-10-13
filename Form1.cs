using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppsFormRegis
{
    public partial class Form1 : Form
    {
 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.Write("checko ");
        }

        private void btnClickThis_Click(object sender, EventArgs e)
        {
            lblHelloW.Text = "Thanks for Submit!! ";
            Debug.WriteLine("check button");
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("show button push");

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               // show the open dialog if the user clicks ok,
               // picture that the user choose.
               pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("clear button");
            pictureBox1.Image = null;
        }

        private void setbgBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("setbg button");
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("close button");
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("check box changed!");
            if (checkBox1.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("checking the picture box");
        }
    }
}
