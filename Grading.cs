using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradingPractice
{
    class Grading
    {
       public double GradeStudent(Student currentStudent)
       {
           double grade = 0;

           foreach (Answer a in currentStudent.Answers)
           {
               grade = grade + a.Credit;
           }

           return grade;
       }

       public double GradeMultiAnswerQuestion(bool oneIsCorrect, bool twoIsCorrect, bool threeIsCorrect, bool fourIsCorrect, bool fiveIsCorrect, string multiAnswerStudentAnswer)
       {
           double credit = 0;

           if (multiAnswerStudentAnswer.Contains("1") && multiAnswerStudentAnswer.Contains("2")
               && multiAnswerStudentAnswer.Contains("3") && multiAnswerStudentAnswer.Contains("4") && multiAnswerStudentAnswer.Contains("5"))
           {
               credit = 0;
           }
           else if (multiAnswerStudentAnswer.ToString() == "")
           {
               credit = 0;
           }
           else
           {
               if (multiAnswerStudentAnswer.Contains("1") && oneIsCorrect == true)
               {
                   credit = credit + .2;
               }
               else if (!multiAnswerStudentAnswer.Contains("1") && oneIsCorrect == false)
               {
                   credit = credit + .2;
               }

               if (multiAnswerStudentAnswer.Contains("2") && twoIsCorrect == true)
               {
                   credit = credit + .2;
               }
               else if (!multiAnswerStudentAnswer.Contains("2") && twoIsCorrect == false)
               {
                   credit = credit + .2;
               }

               if (multiAnswerStudentAnswer.Contains("3") && threeIsCorrect == true)
               {
                   credit = credit + .2;
               }
               else if (!multiAnswerStudentAnswer.Contains("3") && threeIsCorrect == false)
               {
                   credit = credit + .2;
               }

               if (multiAnswerStudentAnswer.Contains("4") && fourIsCorrect == true)
               {
                   credit = credit + .2;
               }
               else if (!multiAnswerStudentAnswer.Contains("4") && fourIsCorrect == false)
               {
                   credit = credit + .2;
               }

               if (multiAnswerStudentAnswer.Contains("5") && fiveIsCorrect == true)
               {
                   credit = credit + .2;
               }
               else if (!multiAnswerStudentAnswer.Contains("5") && fiveIsCorrect == false)
               {
                   credit = credit + .2;
               }

           }

           return credit;
       }

       public DataTable GetStudentReport(Student selectedStudent)
       {
           DataTable studentReport = new DataTable();

           
           
           return studentReport;
       }

    }
}
