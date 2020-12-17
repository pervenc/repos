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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   //Convert inserted number from string to float
            float value = float.Parse(textBox1.Text) + float.Parse(textBox2.Text);
            //Change result box text based on result and convert it to string
            textBox3.Text = Convert.ToString(value);
        }

        private void button2_Click(object sender, EventArgs e)
        {   //Convert inserted number from string to float
            float value = float.Parse(textBox1.Text) - float.Parse(textBox2.Text);
            //Change result box text based on result and convert it to string
            textBox3.Text = Convert.ToString(value);
        }

        private void button3_Click(object sender, EventArgs e)
        {   //Convert inserted number from string to float
            float value = float.Parse(textBox1.Text) * float.Parse(textBox2.Text);
            //Change result box text based on result and convert it to string
            textBox3.Text = Convert.ToString(value);
        }

        private void button4_Click(object sender, EventArgs e)
        {   //Convert inserted number from string to float
            float value = float.Parse(textBox1.Text) / float.Parse(textBox2.Text);
            //Change result box text based on result and convert it to string
            textBox3.Text = Convert.ToString(value);
        }

        private void button5_Click(object sender, EventArgs e)
        { //Set all input boxes to null upon clicking on clear button
            string value = "";
            textBox1.Text = value;
            textBox2.Text = value;
            textBox3.Text = value;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string input = textBox1.Text;
            //Check if input is not a positive number
            if (!int.TryParse(input, out _))
            {
                Console.WriteLine("Not an integer");
                //if its not a number, clear it
                textBox1.Text = "";

            }

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            string input = textBox2.Text;
            //Check if input is not a positive number
            if (!int.TryParse(input, out _))
            {
                Console.WriteLine("Not an integer");
                //if its not a number, clear it
                textBox2.Text = "";

            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
