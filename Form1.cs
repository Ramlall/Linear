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

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
