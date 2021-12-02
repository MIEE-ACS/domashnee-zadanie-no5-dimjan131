using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pixel l = new Pixel();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                l.X = int.Parse(textBox1.Text);
                l.Y = int.Parse(textBox2.Text);
                l.R = int.Parse(textBox3.Text);
                l.G = int.Parse(textBox4.Text);
                l.B = int.Parse(textBox5.Text);

                Graphics g = pictureBox1.CreateGraphics();

                Pen p = new Pen(l.GetColor(),3);
                g.DrawRectangle(p, l.X, l.Y, 1, 1);
                textBox6.Text = l.ToString();
            }
            catch(Exception ex)
            {
                textBox6.Text = ex.Message;
            }
        }
    }
}
