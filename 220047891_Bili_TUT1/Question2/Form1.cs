using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Question2
{


    public partial class Form1 : Form
    {
        public string stuNum;
        public string FinalScore;
        public int stuMarkAss ;
        public int stuMarkExam ;
        public int stuMarkTest;


        List<ListViewItem> studentRecords = new List<ListViewItem>();
        ListViewItem student_Records = new ListViewItem();

        public Form1()
        {
            InitializeComponent();

            List<ListViewItem> studentRecords = new List<ListViewItem>();
            ListViewItem student_Records = new ListViewItem();
            



          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int numberOfRecords = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            numberOfRecords = numberOfRecords + 1;
            try
            {
                stuMarkAss = Convert.ToInt32(textBox3.Text);
                stuMarkExam = Convert.ToInt32(textBox4.Text);
                stuMarkTest = Convert.ToInt32(textBox2.Text);
                stuNum = textBox1.Text;

                Student stu = new Student(stuMarkAss, stuMarkTest, stuMarkExam, textBox1.Text);
                FinalScore = stu.FinalMarkCalc();


                StudentRecord stup = new StudentRecord(stuNum, FinalScore);
                textBox5.Text = stup.FinalResults;
            }
            catch 
            {
                MessageBox.Show("enter required information");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentRecord addRec = new StudentRecord(stuNum, FinalScore);
            MessageBox.Show("Record" +
              "" + numberOfRecords + " has been added to the list", " ");
            addRec.StoreData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filePath = "exam.txt";
            StudentRecord yes = new StudentRecord(stuNum, FinalScore);


            StudentRecord addRec = new StudentRecord(stuNum, FinalScore);
            addRec.StoreData();
            try
            {
                    // Write "Hello, world!" to the file
                    using (StreamWriter writer = new StreamWriter(filePath,true))
                    {
                   
                    writer.WriteLine("student number: "+stuNum +" Assignment: " +stuMarkAss + " Test: "+ stuMarkTest + " Exam: " + stuMarkExam + " Final Mark :" + FinalScore +" no " + addRec.StoreData());
                    MessageBox.Show("writng to list");
                }
                

            }
            catch
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Hello, world!2");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
