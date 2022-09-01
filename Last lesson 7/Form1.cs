using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Last_lesson_7
{
    public partial class Form1 : Form
    {
        public int q = 0;
        public int x1;
        public int x2 = 1;
        public Form1()
        {
            
            InitializeComponent();
            button3.Text = "+1";
            button4.Text = "x2";

            initPlay();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            x2++;
            label4.Text = $"{x2}";
            q++;
            label6.Text = $"{q}";
            if (x2 == x1)
            {
                label7.Text = "победа!!!";

            }
            else
            {
                label7.Text = "";
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {

            x2 = x2 * 2;
            label4.Text = $"{x2}";
            q++;
            label6.Text = $"{q}";
            if (x2 == x1) 
            {
                label7.Text = "победа!!!";

            }
            else
            {
                label7.Text = "";
            }


        }


        private void buttonPlay_Click(object sender, EventArgs e)
        {
            initPlay();

            

        }

        private void initPlay()
        {
            buttonPlay.Visible = false;
            label8.Visible = true;
            label9.Visible = true;
            button1.Visible = true;
            Random rnd = new Random();
            pictureBox1.Visible = true;
            x2 = 1;
            //Получить очередное (в данном случае - первое) случайное число
            x1 = rnd.Next(10, 100);
            label3.Text = $"{x1}";
            label4.Text = $"{x2}";
            label6.Text = $"{q}";
            label9.Text = $"{x1}";
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonPlay.Visible = true;
            pictureBox1.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            button1.Visible = false;
        }
    }
}
