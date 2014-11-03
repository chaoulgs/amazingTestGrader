using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradingPractice
{
    public class IncorrectAnswer
    {
        int _creditAwarded;
        Student _student;
        

        public string Content { get; set; }
        public bool IsCorrect { get; set; }
        public double Credit { get; set; }

        /*public Student Student
        {
            get { return _student; }
            set { _student = value; }
        }*/


         
    }
}
