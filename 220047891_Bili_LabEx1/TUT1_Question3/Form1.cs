using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUT1_Question3
{
    public partial class Form1 : Form
    {
        int total;

        
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (largebtn.Checked)
            {
                total = total + 55;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 55;
                label3.Text = total.ToString();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                total = total + 7;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 7;
                label3.Text = total.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
           
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void smallbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (smallbtn.Checked)
            {
                total = total + 25;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 25;
                label3.Text = total.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void medium_CheckedChanged(object sender, EventArgs e)
        {
            if (medium.Checked)
            {
                total = total + 35;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 35;
                label3.Text = total.ToString();
            }
        }

        private void thickbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (thickbtn.Checked)
            {
                total = total + 2;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 2;
                label3.Text = total.ToString();
            }
        }

        private void thinbtn_CheckedChanged(object sender, EventArgs e)
        {
            if (thinbtn.Checked)
            {
                total = total + 1;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 1;
                label3.Text = total.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                total = total + 7;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 7;
                label3.Text = total.ToString();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                total = total + 7;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 7;
                label3.Text = total.ToString();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                total = total + 7;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 7;
                label3.Text = total.ToString();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                total = total + 7;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 7;
                label3.Text = total.ToString();
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                total = total + 7;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 7;
                label3.Text = total.ToString();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                total = total + 7;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 7;
                label3.Text = total.ToString();
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                total = total + 7;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 7;
                label3.Text = total.ToString();
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                total = total + 7;
                label3.Text = total.ToString();
            }
            else
            {
                total = total - 7;
                label3.Text = total.ToString();
            }
        }
    }
}
