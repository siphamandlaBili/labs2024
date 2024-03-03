using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    

    internal class StudentRecord
    {
        public string studentNumber;
        public string FinalResults;
    
        public object[] studentRecords;

        Form1 f = new Form1();

        public StudentRecord(string stuN,string Fres) 
        { 
            studentNumber = stuN;
            FinalResults = Fres;
            
        }

        public StudentRecord()
        {

        }

        public Student StoreData()
        {
            Student ma = new Student();
            List<Student> numbers = new List<Student>();
            numbers.Add(ma);

            return ma;
        }
    }
}
