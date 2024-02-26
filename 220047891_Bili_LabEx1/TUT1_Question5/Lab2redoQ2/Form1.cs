using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2redoQ2
{
    public partial class Form1 : Form
    {

        private double purchasedPrice;
        private double balance;
        private const double interestRate = 0.25;
        private const double paymentPercentage = 0.12;
        private const double minimumPayment = 15;

        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.Columns.Add("Payment", 150);
            listView1.Columns.Add("New Balance", 150);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if(double.TryParse(txtPrice.Text, out purchasedPrice) ) {

                balance = purchasedPrice;

                while(balance > 0)
                {
                    double interest = balance * interestRate;
                    double payment = balance * paymentPercentage + interest;

                    ListViewItem listItems = new ListViewItem(payment.ToString("C"));
                    listItems.SubItems.Add((balance - payment).ToString("C"));
                    listView1.Items.Add(listItems);


                    balance -= payment;
                    
                    if(balance <= minimumPayment)
                    {
                        ListViewItem finalPayment = new ListViewItem($"The final payement: {balance:C}");
                        listView1.Items.Add(finalPayment);
                        break;
                    }
                    
                }

            }
            else
            {
                MessageBox.Show("Invalid Purchase Price. Please enter a valid purchase price");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
