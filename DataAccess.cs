using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Data;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace gradingPractice
{
    public class DataAccess
    {        
        DataTable testData = new DataTable();


     

        public Student GetStudent(List<Answer> answers)
        {
            Student currentStudent = new Student(answers[0].Content, answers);
            return currentStudent;
        }

        public List<string> GetStudentNames(List<Student> students)
        {
            List<string> studentNames = new List<string>();

            foreach(Student s in students)
            {
                studentNames.Add(s.Name);
            }

            return studentNames;
        }

        public List<Answer> GetStudentAnswers(List<List<string>> testDataInRows, int studentNumber, int numberOfQuestions)
        {
            List<Answer> studentAnswers = new List<Answer>();

            for (int questionNumber = 0; questionNumber <= numberOfQuestions; questionNumber++)
            {
                Answer currentAnswer = new Answer(testDataInRows[studentNumber][questionNumber].Trim(),questionNumber);
                studentAnswers.Add(currentAnswer);
            }

            return studentAnswers;
        }


        public List<int> CreateListOfQuestionNumbers (int numberOfQuestions)
        {
            List<int> listOfQuestionNumbers = new List<int>();

            for (int i = 0; i <= numberOfQuestions; i++)
            {
                listOfQuestionNumbers.Add(i);
            }

            return listOfQuestionNumbers;
        }

        public List<string> GetAnswerKey(List<List<string>> testDataInRows)
        {
            List<string> answerKey = new List<string>();
            answerKey = testDataInRows[0];
            return answerKey;          
        }

        public int GetNumberOfQuestions(DataTable testDataTable)
        {
            int _numberOfQuestions;
            _numberOfQuestions = testDataTable.Columns.Count - 1;
            return _numberOfQuestions;
        }

        public int GetNumberOfStudents(DataTable testDataTable)
        {
            int _numberOfStudents;
            _numberOfStudents = testDataTable.Rows.Count - 1;
            return _numberOfStudents;
        }      

        public List<List<string>> GetTestDataAsRows(DataTable tableToConvert)
        {
            var q = from row in tableToConvert.AsEnumerable()
                    select row.ItemArray.Select(x => x.ToString()).ToList<string>();

            List<List<string>> testDataInRows = q.ToList();            
            //List<List<string>> testDataInRows = tableToConvert.Rows.Cast<DataRow>().ToList();
            return testDataInRows;
        }


        public DataTable GetDataTable(string fileName)
        {
            
            testData = ConvertCSVtoDataTable(fileName);
            return testData;
        }


        private DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            DataTable dt = new DataTable();

            //how to handle escape in c#
            using (TextFieldParser parser = new TextFieldParser(strFilePath))
            {
                // set the parser variables
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                bool firstLine = true;

                while (!parser.EndOfData)
                {
                    //Processing row
                    string[] fields = parser.ReadFields();

                    // get the column headers
                    if (firstLine)
                    {
                        foreach (var val in fields)
                        {
                            dt.Columns.Add(val);
                        }

                        firstLine = false;

                        continue;
                    }

                    // get the row data
                    dt.Rows.Add(fields);
                }

                return dt;
            }
        } 
    }
}
