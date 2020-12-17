using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float value = float.Parse(textBox1.Text) + float.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float value = float.Parse(textBox1.Text) - float.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float value = float.Parse(textBox1.Text) * float.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(value);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float value = float.Parse(textBox1.Text) / float.Parse(textBox2.Text);
            textBox3.Text = Convert.ToString(value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string value = "";
            textBox1.Text = value;
            textBox2.Text = value;
            textBox3.Text = value;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string input = textBox1.Text;
            if (!int.TryParse(input, out _))
            {
                Console.WriteLine("Not an integer");
                textBox1.Text = "";

            }

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            string input = textBox2.Text;
            if (!int.TryParse(input, out _))
            {
                Console.WriteLine("Not an integer");
                textBox2.Text = "";

            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
