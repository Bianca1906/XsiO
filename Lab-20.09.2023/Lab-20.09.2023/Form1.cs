using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_20._09._2023
{
    public partial class Form1 : Form
    {
        int k = 0;
        //k=0 --> Tura lui O -> culoare roz
        //k=1 --> Tura lui X -> culoare albastru
        int[,] a;
        
        public Form1()
        {
            InitializeComponent();
            a = new int[3, 3];
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                k = 1 - k;
                if (k == 0)
                    button1.Text = "O";
                else if (k == 1)
                    button1.Text = "X";
                if (k == 0)
                    pictureBox1.BackColor = Color.LightBlue;
                else if (k == 1)
                    pictureBox1.BackColor = Color.LightPink;
                if (k == 0)
                    label1.Text = "Tura lui X";
                else if (k == 1)
                    label1.Text = "Tura lui O";
                if (button1.Text == "X")
                    a[1, 1] = 1;
                if (button1.Text == "O")
                    a[1, 1] = 0;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                k = 1 - k;
                if (k == 0)
                    button2.Text = "O";
                else if (k == 1)
                    button2.Text = "X";
                if (k == 0)
                    pictureBox1.BackColor = Color.LightBlue;
                else if (k == 1)
                    pictureBox1.BackColor = Color.LightPink;
                if (k == 0)
                    label1.Text = "Tura lui X";
                else if (k == 1)
                    label1.Text = "Tura lui O";
                if (button2.Text == "X")
                    a[1, 2] = 1;
                if (button2.Text == "O")
                    a[1, 2] = 0;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                k = 1 - k;
                if (k == 0)
                    button3.Text = "O";
                else if (k == 1)
                    button3.Text = "X";
                if (k == 0)
                    pictureBox1.BackColor = Color.LightBlue;
                else if (k == 1)
                    pictureBox1.BackColor = Color.LightPink;
                if (k == 0)
                    label1.Text = "Tura lui X";
                else if (k == 1)
                    label1.Text = "Tura lui O";
                if (button3.Text == "X")
                    a[1, 3] = 1;
                if (button3.Text == "O")
                    a[1, 3] = 0;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                k = 1 - k;
                if (k == 0)
                    button4.Text = "O";
                else if (k == 1)
                    button4.Text = "X";
                if (k == 0)
                    pictureBox1.BackColor = Color.LightBlue;
                else if (k == 1)
                    pictureBox1.BackColor = Color.LightPink;
                if (k == 0)
                    label1.Text = "Tura lui X";
                else if (k == 1)
                    label1.Text = "Tura lui O";
                if (button4.Text == "X")
                    a[2, 1] = 1;
                if (button4.Text == "O")
                    a[2, 1] = 0;
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                k = 1 - k;
                if (k == 0)
                    button5.Text = "O";
                else if (k == 1)
                    button5.Text = "X";
                if (k == 0)
                    pictureBox1.BackColor = Color.LightBlue;
                else if (k == 1)
                    pictureBox1.BackColor = Color.LightPink;
                if (k == 0)
                    label1.Text = "Tura lui X";
                else if (k == 1)
                    label1.Text = "Tura lui O";
                if (button5.Text == "X")
                    a[2, 2] = 1;
                if (button5.Text == "O")
                    a[2, 2] = 0;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                k = 1 - k;
                if (k == 0)
                    button6.Text = "O";
                else if (k == 1)
                    button6.Text = "X";
                if (k == 0)
                    pictureBox1.BackColor = Color.LightBlue;
                else if (k == 1)
                    pictureBox1.BackColor = Color.LightPink;
                if (k == 0)
                    label1.Text = "Tura lui X";
                else if (k == 1)
                    label1.Text = "Tura lui O";
                if (button6.Text == "X")
                    a[2, 3] = 1;
                if (button6.Text == "O")
                    a[2, 3] = 0;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                k = 1 - k;
                if (k == 0)
                    button7.Text = "O";
                else if (k == 1)
                    button7.Text = "X";
                if (k == 0)
                    pictureBox1.BackColor = Color.LightBlue;
                else if (k == 1)
                    pictureBox1.BackColor = Color.LightPink;
                if (k == 0)
                    label1.Text = "Tura lui X";
                else if (k == 1)
                    label1.Text = "Tura lui O";
                if (button7.Text == "X")
                    a[3, 1] = 1;
                if (button7.Text == "O")
                    a[3, 1] = 0;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                k = 1 - k;
                if (k == 0)
                    button8.Text = "O";
                else if (k == 1)
                    button8.Text = "X";
                if (k == 0)
                    pictureBox1.BackColor = Color.LightBlue;
                else if (k == 1)
                    pictureBox1.BackColor = Color.LightPink;
                if (k == 0)
                    label1.Text = "Tura lui X";
                else if (k == 1)
                    label1.Text = "Tura lui O";
                if (button8.Text == "X")
                    a[3, 2] = 1;
                if (button8.Text == "O")
                    a[3, 2] = 0;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                k = 1 - k;
                if (k == 0)
                    button9.Text = "O";
                else if (k == 1)
                    button9.Text = "X";
                if (k == 0)
                    pictureBox1.BackColor = Color.LightBlue;
                else if (k == 1)
                    pictureBox1.BackColor = Color.LightPink;
                if (k == 0)
                    label1.Text = "Tura lui X";
                else if (k == 1)
                    label1.Text = "Tura lui O";
                if (button9.Text == "X")
                    a[3, 3] = 1;
                if (button9.Text == "O")
                    a[3, 3] = 0;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
