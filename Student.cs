using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradingPractice
{
    public class Student
    {
        public Student(string name, List<Answer> answers)
        {
            Name = name;
            Answers = answers;
            Grade = 0;
        }

        public string Name { get; set; }
        public List<Answer> Answers { get; set; }
        public double Grade { get; set; }
    }
}
