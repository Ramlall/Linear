using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Media3D;

namespace Linear
    {
    public partial class Form1 : Form
        {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public Form1()
            {
            InitializeComponent();
            comboBox1.Items.Add("2x2");
            comboBox1.Items.Add("3x3");
            //comboBox1.Items.Add("4x4"); // Add a 4x4 matrix later when you support the matrices.
            }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Handle what the user picks Matrix A's size to be.
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {
            // If the combobox is selected to be 2x2, disable the extra textbox's.
            if (comboBox1.Text == "2x2")
                {
                textBox3.Enabled = false;
                textBox6.Enabled = false;
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
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox12.Enabled = true;
                textBox15.Enabled = true;
                }
            }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Check the textboxes if the user selects 2x2 and make sure all the textboxes contain doubles.
        public void CheckTextBoxes2x2()
            {
            // 2x2 needs textboxes: 1, 2, 4, 5, 10, 11, 13, 14.
            // Textbox 1
            try
                { double strTxt = Convert.ToDouble(textBox1.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 1 column 1. Make sure that value is a number!"); return; }
            
            // Textbox 2
            try
                { double strTxt = Convert.ToDouble(textBox2.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 1 column 2. Make sure that value is a number!"); return; }

            // Textbox 4
            try
                { double strTxt = Convert.ToDouble(textBox4.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 2 column 1. Make sure that value is a number!"); return; }

            // Textbox 5
            try
                { double strTxt = Convert.ToDouble(textBox5.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 2 column 2. Make sure that value is a number!"); return; }

            // Textbox 10
            try
                { double strTxt = Convert.ToDouble(textBox10.Text); }
            catch
                { MessageBox.Show("Problem with matrix B, row 1 column 1. Make sure that value is a number!"); return; }

            // Textbox 11
            try
                { double strTxt = Convert.ToDouble(textBox11.Text); }
            catch
                { MessageBox.Show("Problem with matrix B, row 2 column 1. Make sure that value is a number!"); return; }

            // Textbox 13
            try
                { double strTxt = Convert.ToDouble(textBox13.Text); }
            catch
                { MessageBox.Show("Problem with matrix C, row 1 column 1. Make sure that value is a number!"); return; }

            // Textbox 14
            try
                { double strTxt = Convert.ToDouble(textBox14.Text); }
            catch
                { MessageBox.Show("Problem with matrix C, row 1 column 2. Make sure that value is a number!"); return; }
            }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // Check the textboxes if the user selects 2x2 and make sure all the textboxes contain doubles.
        public void CheckTextBoxes3x3()
        {
            // 3x3 needs textboxes: all numbers 1 to 15
            // Textbox 1
            try
                { double strTxt = Convert.ToDouble(textBox1.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 1 column 1. Make sure that value is a number!"); return; }

            // Textbox 2
            try
                { double strTxt = Convert.ToDouble(textBox2.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 1 column 2. Make sure that value is a number!"); return; }
            // Textbox 3
            try
                { double strTxt = Convert.ToDouble(textBox3.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 1 column 3. Make sure that value is a number!"); return; }
            // Textbox 4
            try
                { double strTxt = Convert.ToDouble(textBox4.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 2 column 1. Make sure that value is a number!"); return; }

            // Textbox 5
            try
                { double strTxt = Convert.ToDouble(textBox5.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 2 column 2. Make sure that value is a number!"); return; }
            // Textbox 6
            try
                { double strTxt = Convert.ToDouble(textBox6.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 2 column 3. Make sure that value is a number!"); return; }
            // Textbox 7
            try
                { double strTxt = Convert.ToDouble(textBox7.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 3 column 1. Make sure that value is a number!"); return; }
            // Textbox 8
            try
                { double strTxt = Convert.ToDouble(textBox8.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 3 column 2. Make sure that value is a number!"); return; }
            // Textbox 9
            try
                { double strTxt = Convert.ToDouble(textBox9.Text); }
            catch
                { MessageBox.Show("Problem with matrix A, row 3 column 3. Make sure that value is a number!"); return; }

            // Textbox 10
            try
            { double strTxt = Convert.ToDouble(textBox10.Text); }
            catch
                { MessageBox.Show("Problem with matrix B, row 1 column 1. Make sure that value is a number!"); return; }

            // Textbox 11
            try
                { double strTxt = Convert.ToDouble(textBox11.Text); }
            catch
                { MessageBox.Show("Problem with matrix B, row 2 column 1. Make sure that value is a number!"); return; }
            // Textbox 12
            try
                { double strTxt = Convert.ToDouble(textBox12.Text); }
            catch
                { MessageBox.Show("Problem with matrix B, row 3 column 1. Make sure that value is a number!"); return; }

            // Textbox 13
            try
                { double strTxt = Convert.ToDouble(textBox13.Text); }
            catch
                { MessageBox.Show("Problem with matrix C, row 1 column 1. Make sure that value is a number!"); return; }
            // Textbox 14
            try
                { double strTxt = Convert.ToDouble(textBox14.Text); }
            catch
                { MessageBox.Show("Problem with matrix C, row 1 column 2. Make sure that value is a number!"); return; }
            // Textbox 15
            try
                { double strTxt = Convert.ToDouble(textBox15.Text); }
            catch
                { MessageBox.Show("Problem with matrix C, row 1 column 3. Make sure that value is a number!"); return; }
            }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        // This is what happens when our submit button gets clicked. 
        private void button1_Click(object sender, EventArgs e)
            {
            //button1.Enabled = false; // Disables our submit button.

            ///////////////////////////////////////////////////////////////////////////////////////////

            // Handle 2x2 case.
            if (comboBox1.Text == "2x2")
                {
                // First check all the values to make sure they're able to be converted to doubles.
                CheckTextBoxes2x2();
                // If there's a problem with the values the user will get a message to change it.

                // Set up the matrixes A, B, and C.
                // Matrix A has textboxes 1, 2, 4, 5 and 2 zeros added for the offset (it's a Matrix .NET property).
                Matrix A = new Matrix(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), 0, 0);

                // Matrix B uses textboxes 10 and 11.
                Matrix B = new Matrix(Convert.ToDouble(textBox10.Text), 0, Convert.ToDouble(textBox11.Text), 0, 0, 0);

                // Matrix C uses textboxes 13 and 14.
                Matrix C = new Matrix(Convert.ToDouble(textBox13.Text), Convert.ToDouble(textBox14.Text), 0, 0, 0, 0);


                //MessageBox.Show(A.Determinant.ToString());
            }

            ///////////////////////////////////////////////////////////////////////////////////////////

            // Handle 3x3 case.
            if (comboBox1.Text == "3x3" || comboBox1.Text == "")
                {
                CheckTextBoxes3x3();

                // Set up the matrixes A, B, and C.
                // Matrix A has textboxes 1 to 9 and 2 zeros added for the offset (it's a Matrix .NET property).
                Matrix3D A = new Matrix3D(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text), 0, Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text), Convert.ToDouble(textBox6.Text), 0, Convert.ToDouble(textBox7.Text), Convert.ToDouble(textBox8.Text), Convert.ToDouble(textBox9.Text), 0, 0, 0, 0, 1);

                // Matrix B uses textboxes 10, 11, and 12.
                Matrix3D B = new Matrix3D(Convert.ToDouble(textBox10.Text), 0, 0, 0, Convert.ToDouble(textBox11.Text), 0, 0, 0, Convert.ToDouble(textBox12.Text), 0, 0, 0, 0, 0, 0, 1);

                // Matrix C uses textboxes 13, 14, and 15.
                Matrix3D C = new Matrix3D(Convert.ToDouble(textBox13.Text), Convert.ToDouble(textBox14.Text), Convert.ToDouble(textBox15.Text), 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1);
                
                
                //MessageBox.Show("The determinant of A is " + A.Determinant.ToString());
                }

            }
        }
    }
