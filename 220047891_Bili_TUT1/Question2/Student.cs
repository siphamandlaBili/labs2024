using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Question2
{
    internal class Student
    {
        public string studentNumber;
        public int assignment, test, exam;
        public string finalMark;

        public Student()
        {
            
        }
        public Student( int assignment, int test, int exam, string studentNumber)
        {
            this.assignment = assignment;
            this.test = test;
            this.exam = exam;
            this.studentNumber = studentNumber;
        }
        public string FinalMarkCalc()
        {
            double finalGrade = (0.20 * assignment) + (0.30 * test) + (0.50 * exam);
            finalMark = Convert.ToString(finalGrade);
            return finalMark;
        }

    }
}
