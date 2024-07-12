using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication19
{
    public partial class Form1 : Form
    {
        double kottu = 600;
        double burgur = 300;
        double friedrice = 1300;
        double pizza = 1200;
        double frechfries = 600;
        double ice = 150;
       
        double tax = 1.5;
        double change, stot, tot, itax;

        double[] itemcost = new double[6];

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                textBox1.Focus();
                textBox1.Text = "";
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Enabled = true;
                textBox2.Focus();
                textBox2.Text = "";
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Enabled = true;
                textBox3.Focus();
                textBox3.Text = "";
            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                textBox6.Enabled = true;
                textBox6.Focus();
                textBox6.Text = "";
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                textBox7.Enabled = true;
                textBox7.Focus();
                textBox7.Text = "";
            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                textBox8.Enabled = true;
                textBox8.Focus();
                textBox8.Text = "";
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            itemcost[0] = double.Parse(textBox1.Text);
            itemcost[1] = double.Parse(textBox2.Text);
            itemcost[2] = double.Parse(textBox3.Text);
            itemcost[3] = double.Parse(textBox6.Text);
            itemcost[4] = double.Parse(textBox7.Text);
            itemcost[5] = double.Parse(textBox8.Text);

            stot = (itemcost[0] * burgur) + (itemcost[1] * kottu) + (itemcost[2] * friedrice) + (itemcost[3] * pizza) + (itemcost[4] * frechfries) + (itemcost[5] * ice);

            itax = (stot * tax)/100;

            textBox11.Text = stot.ToString();
            textBox4.Text = itax.ToString();
            double tot = stot + itax;
            textBox12.Text = tot.ToString();


        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!char.IsDigit(number) || number == (char)Keys.Back || number == (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";


            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox6.Checked = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
