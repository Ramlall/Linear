using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linear
{
    public partial class Form1 : Form
    {
        public Form1()
            {
            InitializeComponent();
            comboBox1.Items.Add("2x2");
            comboBox1.Items.Add("3x3");
            //comboBox1.Items.Add("4x4"); // Add a 4x4 matrix later when you support the matrices.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            // If the combobox is selected to be 2x2, disable the extra textbox's.
            if (comboBox1.Text == "2x2")
                {
                textBox3.Enabled = false;
                textBox5.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox12.Enabled = false;
                textBox15.Enabled = false;
                }
            // If the combobox is selected to be 2x2, enable the extra textbox's.
            if (comboBox1.Text == "3x3")
                {
                textBox3.Enabled = true;
                textBox5.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox12.Enabled = true;
                textBox15.Enabled = true;
                }
            }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
