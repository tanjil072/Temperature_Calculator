using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempCalc
{
    public partial class Form1 : Form
    {
        String afterConvert = "";

        public Form1()
        {
           
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String value = textBox1.Text;

            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Something");
            }
            else
            {
                
                double val = double.Parse(value);

                //MessageBox.Show(value);


                int isChecked = 0;

                if (radioButton1.Checked)
                {
                    isChecked = 1;

                }
                if (radioButton2.Checked)
                {
                    isChecked = 2;
                }
                if (radioButton3.Checked)
                {
                    isChecked = 3;
                }
                if (radioButton4.Checked)
                {
                    isChecked = 4;

                }
                if (radioButton5.Checked)
                {
                    isChecked = 5;
                }

                switch (isChecked)
                {
                    case 1:
                        double cel1 = 0, fr1 = val;

                        cel1 = (fr1 - 32) * 5 / 9;

                        afterConvert = cel1.ToString("F3");

                        break;
                    case 2:
                        double cel2 = val, fr2 = 0;

                        fr2 = (cel2 * 9) / 5 + 32;

                        afterConvert = fr2.ToString("F3");

                        break;
                    case 3:
                        double cel3 = val, kel1 = 0;

                        kel1 = cel3 + 273.15;

                        afterConvert = kel1.ToString("F3");
                        break;
                    case 4:
                        double cel4 = 0, kel2 = val;

                        cel4 = kel2 - 273.15;

                        afterConvert = cel4.ToString("F3");
                        break;
                    case 5:
                        double fr3 = val, kel3 = 0;

                        kel3 = 273.5 + ((fr3 - 32.0) * (5.0 / 9.0));

                        afterConvert = kel3.ToString("F3");


                        break;

                }

                textBox2.Text = afterConvert;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            afterConvert = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
