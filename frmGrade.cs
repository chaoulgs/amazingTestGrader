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


namespace gradingPractice
{
    public partial class frmGrade : Form
    {

        List<Student> students = new List<Student>();
        DataAccess da = new DataAccess();
        Grading g = new Grading();        

        int selectedQuestionNumber;
        string filePath;


        public frmGrade()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rBtn100.Checked = false;
            rBtn90.Checked = false;
            rBtn50.Checked = false;
            //rBtn0.Checked = false;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmChooseFile fileChooser = new frmChooseFile();

            fileChooser.ShowDialog();
            filePath = fileChooser.FileName;
            fileChooser.Hide();
            
            DataTable testDataTable = da.GetDataTable(filePath);                     

            List<List<string>> testDataAsRows = da.GetTestDataAsRows(testDataTable);

            List<string> answerKey = da.GetAnswerKey(testDataAsRows);
            List<string> answerKeyDivided = new List<string>();
            //List<string> incorrectAnswers = new List<string>();
            List<Answer> incorrectAnswers = new List<Answer>();
            

            List<int> questionNumbers = da.CreateListOfQuestionNumbers(da.GetNumberOfQuestions(testDataTable));            

            int numberOfStudents = da.GetNumberOfStudents(testDataTable);
            int numberOfQuestions = da.GetNumberOfQuestions(testDataTable);

            //gets all students and populates the students list with them
            for (int studentNumber = 0; studentNumber <= numberOfStudents; studentNumber++)
            {
                students.Add(da.GetStudent(da.GetStudentAnswers(testDataAsRows, studentNumber, numberOfQuestions)));

                for (int questionNumber = 0; questionNumber <= numberOfQuestions; questionNumber++)
                {
                    
                    int multiAnswerKeyAsInt;
                    List<char> multiAnswerKeyAsCharList = new List<char>();
                    List<int> multiAnswerKey = new List<int>();

                    
                    List<char>multiAnswerStudentAnswerAsCharList = new List<char>();
                    List<int> multiAnswerStudentAnswer = new List<int>();

                    //see if this is a multiple answer question, indicated by the answers being numbers
                    if (int.TryParse(answerKey[questionNumber], out multiAnswerKeyAsInt))
                    {
                        bool oneIsCorrect;
                        bool twoIsCorrect;
                        bool threeIsCorrect;
                        bool fourIsCorrect;
                        bool fiveIsCorrect;

                        int multiAnswerStudentAnswerAsInt;
                        if (int.TryParse(students[studentNumber].Answers[questionNumber].Content, out multiAnswerStudentAnswerAsInt))
                        {
                            multiAnswerStudentAnswerAsInt = int.Parse(students[studentNumber].Answers[questionNumber].Content);
                        }

                        multiAnswerKeyAsCharList = multiAnswerKeyAsInt.ToString().ToList();

                        foreach (char c in multiAnswerKeyAsCharList)
                        {
                            multiAnswerKey.Add(int.Parse(c.ToString()));
                        }

                        foreach (char c in multiAnswerStudentAnswerAsCharList)
                        {
                            multiAnswerStudentAnswer.Add(int.Parse(c.ToString()));
                        }

                        //create bools which act as triggers to which numbers are correct
                        if (multiAnswerKey.Contains(1))
                            oneIsCorrect = true;
                        else oneIsCorrect = false;

                        if (multiAnswerKey.Contains(2))
                            twoIsCorrect = true;
                        else twoIsCorrect = false;

                        if (multiAnswerKey.Contains(3))
                            threeIsCorrect = true;
                        else threeIsCorrect = false;

                        if (multiAnswerKey.Contains(4))
                            fourIsCorrect = true;
                        else fourIsCorrect = false;

                        if (multiAnswerKey.Contains(5))
                            fiveIsCorrect = true;
                        else fiveIsCorrect = false;

                        //grade a multi-answer question
                        if (students[studentNumber].Answers[questionNumber].Content == answerKey[questionNumber])
                        {
                            students[studentNumber].Answers[questionNumber].Credit = 1;
                            students[studentNumber].Answers[questionNumber].IsCorrect = true;
                        }
                        else
                        {                            
                           students[studentNumber].Answers[questionNumber].Credit =  g.GradeMultiAnswerQuestion(oneIsCorrect, twoIsCorrect, threeIsCorrect, fourIsCorrect, fiveIsCorrect, students[studentNumber].Answers[questionNumber].Content);
                        }
                        
                        


                    }
                    else //this initiates the normal grading process
                    {
                        //this divides the answer key into a list of strings, slashes determine separate entries
                        answerKeyDivided = answerKey[questionNumber].Trim().ToUpper().Split('/').ToList<string>();
                                               
                        //set answers that perfectly match the answer key to full credit
                        foreach (string s in answerKeyDivided)
                        {
                            if (students[studentNumber].Answers[questionNumber].Content.Equals(s, StringComparison.OrdinalIgnoreCase)/*answerKey[questionNumber]*/)
                            {
                                students[studentNumber].Answers[questionNumber].Credit = 1;
                                students[studentNumber].Answers[questionNumber].IsCorrect = true;
                            }
                            else
                            {
                            }
                        }
                    }
                }

            }



            lblNumberOfStudents.Text = numberOfStudents.ToString();
            lblNumberOfQuestions.Text = numberOfQuestions.ToString(); 
            randomListBox.DataSource = incorrectAnswers;
            ddlQuestionList.DataSource = questionNumbers;
            ddlStudentNames.DataSource = da.GetStudentNames(students);
            dataGridView1.DataSource = testDataTable;
            


            foreach (Student s in students)
            {
                s.Grade = g.GradeStudent(s);
            }

            foreach (Student s in students)
            {
                ListViewItem student = new ListViewItem(s.Name);
                student.SubItems.Add(s.Grade.ToString());
                lvStudentGrades.Items.Add(student);
            }



        }

        private void ddlQuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
           
        }

        private void ddlQuestionList_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable testDataTable = da.GetDataTable(filePath);

            List<List<string>> testDataAsRows = da.GetTestDataAsRows(testDataTable);

            List<string> answerKey = da.GetAnswerKey(testDataAsRows);
            List<List<Answer>> answers = new List<List<Answer>>();
            List<List<string>> answersContent = new List<List<string>>();
            List<Answer> studentAnswers = new List<Answer>();
            List<string> currentStudentAnswersContent = new List<string>();
            List<string> currentQuestionIncorrectAnswersContent = new List<string>();
            List<string> answerKeyDivided = new List<string>();
            

            List<int> questionNumbers = da.CreateListOfQuestionNumbers(da.GetNumberOfQuestions(testDataTable));

            int numberOfStudents = da.GetNumberOfStudents(testDataTable);
            int numberOfQuestions = da.GetNumberOfQuestions(testDataTable);

            if (ddlQuestionList.SelectedItem != null)
            {
                selectedQuestionNumber = int.Parse(ddlQuestionList.SelectedItem.ToString());
            }
            else
            {
                selectedQuestionNumber = 0;
            }

            if (int.Parse(ddlQuestionList.Text) == 0)
            {
                rBtn0.Hide();
                rBtn50.Hide();
                rBtn90.Hide();
                rBtn100.Hide();
            }
            else
            {
                rBtn0.Show();
                rBtn50.Show();
                rBtn90.Show();
                rBtn100.Show();
            }
             
            //populate the answers list with each student's answers
            for (int studentNumber = 0; studentNumber <= numberOfStudents; studentNumber++)
            {
  
                studentAnswers = (da.GetStudentAnswers(testDataAsRows, studentNumber,numberOfQuestions));
                answers.Add(studentAnswers);
                
            }

            //populates a list with the INCORRECT answers by each student for the selected question
            foreach (List<Answer> student in answers)
            {
                answerKeyDivided = answerKey[selectedQuestionNumber].Trim().ToUpper().Split('/').ToList<string>();
                bool answerIsCorrect = answerKeyDivided.Any(x => x.Equals(student[selectedQuestionNumber].Content.Trim(), StringComparison.OrdinalIgnoreCase));

                if (!answerIsCorrect && student[selectedQuestionNumber].Content != answerKey[selectedQuestionNumber]) /*answerKey[selectedQuestionNumber].Trim()*/
                {
                        currentQuestionIncorrectAnswersContent.Add(student[selectedQuestionNumber].Content.ToLower());
                }

                currentQuestionIncorrectAnswersContent.Sort();
            }

            randomListBox.DataSource = currentQuestionIncorrectAnswersContent.Union(currentQuestionIncorrectAnswersContent).ToList();
            lblCorrectAnswer.Text = answerKey[selectedQuestionNumber];

        }

        private void rBtn100_CheckedChanged(object sender, EventArgs e)
        {

            if (rBtn100.Checked == true)
            {
                foreach (Student s in students)
                {
                    if (s.Answers[selectedQuestionNumber].Content.Equals(randomListBox.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        //students[randomListBox.SelectedIndex].Answers[selectedQuestionNumber].Credit = 1;
                        s.Answers[selectedQuestionNumber].Credit = 1;
                        s.Grade = g.GradeStudent(s);
                    }
                }

                lvStudentGrades.Items.Clear();

                foreach (Student s in students)
                {
                    ListViewItem student = new ListViewItem(s.Name);
                    student.SubItems.Add(s.Grade.ToString());
                    lvStudentGrades.Items.Add(student);
                }
            }
        }

        private void rBtn90_CheckedChanged(object sender, EventArgs e)
        {

            if (rBtn90.Checked == true)
            {
                foreach (Student s in students)
                {
                    if (s.Answers[selectedQuestionNumber].Content.Equals(randomListBox.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        s.Answers[selectedQuestionNumber].Credit = .9;
                        s.Grade = g.GradeStudent(s);
                    }
                }

                lvStudentGrades.Items.Clear();

                foreach (Student s in students)
                {
                    ListViewItem student = new ListViewItem(s.Name);
                    student.SubItems.Add(s.Grade.ToString());
                    lvStudentGrades.Items.Add(student);
                }
            }

        }

        private void rBtn50_CheckedChanged(object sender, EventArgs e)
        {

            if (rBtn50.Checked == true)
            {
                foreach (Student s in students)
                {
                    if (s.Answers[selectedQuestionNumber].Content.Equals(randomListBox.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        s.Answers[selectedQuestionNumber].Credit = .5;
                        s.Grade = g.GradeStudent(s);
                    }
                }

                lvStudentGrades.Items.Clear();

                foreach (Student s in students)
                {
                    ListViewItem student = new ListViewItem(s.Name);
                    student.SubItems.Add(s.Grade.ToString());
                    lvStudentGrades.Items.Add(student);
                }
            }
        }

        private void rBtn0_CheckedChanged(object sender, EventArgs e)
        {
            if (rBtn0.Checked == true)
            {
                foreach (Student s in students)
                {
                    if (s.Answers[selectedQuestionNumber].Content.Equals(randomListBox.SelectedItem.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        s.Answers[selectedQuestionNumber].Credit = 0;
                        s.Grade = g.GradeStudent(s);
                    }
                }

                lvStudentGrades.Items.Clear();

                foreach (Student s in students)
                {
                    ListViewItem student = new ListViewItem(s.Name);
                    student.SubItems.Add(s.Grade.ToString());
                    lvStudentGrades.Items.Add(student);
                }
            }

        }

        private void btnGradeStudents_Click(object sender, EventArgs e)
        {
            foreach (Student s in students)
            {
                s.Grade = g.GradeStudent(s);
            }

            lvStudentGrades.Items.Clear();

            foreach (Student s in students)
            {
                ListViewItem student = new ListViewItem(s.Name);
                student.SubItems.Add(s.Grade.ToString());
                lvStudentGrades.Items.Add(student);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ddlStudentNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvStudentAnswer.Items.Clear();

            DataTable testDataTable = da.GetDataTable(filePath);
            List<List<string>> testDataAsRows = da.GetTestDataAsRows(testDataTable);
            List<string> answerKey = da.GetAnswerKey(testDataAsRows);
            List<int> questionNumbers = da.CreateListOfQuestionNumbers(da.GetNumberOfQuestions(testDataTable));

            //foreach counter - maybe switch to for loop?
            int i = 0; 
            foreach (Answer a in students[ddlStudentNames.SelectedIndex].Answers)
            {                
                ListViewItem answer = new ListViewItem(a.QuestionNumber.ToString());
                answer.SubItems.Add(answerKey[i]);
                answer.SubItems.Add(a.Content);
                answer.SubItems.Add(a.Credit.ToString());
                lvStudentAnswer.Items.Add(answer);
                i++;
            }
        }

        private void lvStudentAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lblCorrectAnswer_Click(object sender, EventArgs e)
        {

        }

        


        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportIndividual();
        }

        private void lblCorrectAnswerAdvice_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExportGrades_Click(object sender, EventArgs e)
        {
            ExportGrades();
        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            ExportAll();
        }

        private void frmGrade_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void frmGrade_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("All unexported progress will be lost - Are you sure you want to exit?", "Close Application", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //MessageBox.Show("The application has been closed.", "Application Closed", MessageBoxButtons.OK);
            }
            else
            {
                e.Cancel = true;
                this.Activate();
            }  
        }

        private void btnGenerateAllReports_Click(object sender, EventArgs e)
        {
            lvAllReports.Items.Clear();

            DataTable testDataTable = da.GetDataTable(filePath);
            List<List<string>> testDataAsRows = da.GetTestDataAsRows(testDataTable);
            List<string> answerKey = da.GetAnswerKey(testDataAsRows);
            List<int> questionNumbers = da.CreateListOfQuestionNumbers(da.GetNumberOfQuestions(testDataTable));

            foreach (Student s in students)
            {
                //foreach counter - maybe switch to for loop?
                int i = 0;
                foreach (Answer a in s.Answers)
                {
                    ListViewItem answer = new ListViewItem(a.QuestionNumber.ToString());
                    answer.SubItems.Add(answerKey[i]);
                    answer.SubItems.Add(a.Content);
                    answer.SubItems.Add(a.Credit.ToString());
                    lvAllReports.Items.Add(answer);
                    i++;
                }
            }
        }

        //export method for individual student
        private void ExportIndividual()
        {
            try
            {
                //lvPDF is nothing but the listview control name
                string[] st = new string[lvStudentAnswer.Columns.Count];
                DirectoryInfo di = new DirectoryInfo(@"c:\AmazingTestGrader\");
                if (di.Exists == false)
                    di.Create();
                StreamWriter sw = new StreamWriter(@"c:\AmazingTestGrader\" + ddlStudentNames.Text + "_Individual_Report.xls", false);
                sw.AutoFlush = true;
                for (int col = 0; col < lvStudentAnswer.Columns.Count; col++)
                {
                    sw.Write("\t" + lvStudentAnswer.Columns[col].Text.ToString());
                }

                int rowIndex = 1;
                int row = 0;
                string st1 = "";
                for (row = 0; row < lvStudentAnswer.Items.Count; row++)
                {
                    if (rowIndex <= lvStudentAnswer.Items.Count)
                        rowIndex++;
                    st1 = "\n";
                    for (int col = 0; col < lvStudentAnswer.Columns.Count; col++)
                    {
                        st1 = st1 + "\t" + "" + lvStudentAnswer.Items[row].SubItems[col].Text.ToString();
                    }
                    sw.WriteLine(st1);
                }
                sw.Close();
                FileInfo fil = new FileInfo(@"c:\AmazingTestGrader\Individual_Report.xls");
               
                MessageBox.Show("Individual report exported for " + ddlStudentNames.Text, "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
            }
        }

        //export method for all students combined
        private void ExportAll()
        {
            try
            {
                //lvPDF is nothing but the listview control name
                string[] st = new string[lvAllReports.Columns.Count];
                DirectoryInfo di = new DirectoryInfo(@"c:\AmazingTestGrader\");
                if (di.Exists == false)
                    di.Create();
                StreamWriter sw = new StreamWriter(@"c:\AmazingTestGrader\All_Students_Report.xls", false);
                sw.AutoFlush = true;
                for (int col = 0; col < lvAllReports.Columns.Count; col++)
                {
                    sw.Write("\t" + lvAllReports.Columns[col].Text.ToString());
                }

                int rowIndex = 1;
                int row = 0;
                string st1 = "";
                for (row = 0; row < lvAllReports.Items.Count; row++)
                {
                    if (rowIndex <= lvAllReports.Items.Count)
                        rowIndex++;
                    st1 = "\n";
                    for (int col = 0; col < lvAllReports.Columns.Count; col++)
                    {
                        st1 = st1 + "\t" + "" + lvAllReports.Items[row].SubItems[col].Text.ToString();
                    }
                    sw.WriteLine(st1);
                }
                sw.Close();
                FileInfo fil = new FileInfo(@"c:\AmazingTestGrader\All_Students_Report.xls");
                if (fil.Exists == true)
                    MessageBox.Show("Combined student report exported", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
            }
        }

        //export method for grade sheet
        private void ExportGrades()
        {
            try
            {
                //TODO - custom filepaths
                string[] st = new string[lvStudentGrades.Columns.Count];
                DirectoryInfo di = new DirectoryInfo(@"c:\AmazingTestGrader\");
                if (di.Exists == false)
                    di.Create();
                StreamWriter sw = new StreamWriter(@"c:\AmazingTestGrader\Student_Grades.xls", false);
                sw.AutoFlush = true;
                for (int col = 0; col < lvStudentGrades.Columns.Count; col++)
                {
                    sw.Write("\t" + lvStudentGrades.Columns[col].Text.ToString());
                }

                int rowIndex = 1;
                int row = 0;
                string st1 = "";
                for (row = 0; row < lvStudentGrades.Items.Count; row++)
                {
                    if (rowIndex <= lvStudentGrades.Items.Count)
                        rowIndex++;
                    st1 = "\n";
                    for (int col = 0; col < lvStudentGrades.Columns.Count; col++)
                    {
                        st1 = st1 + "\t" + "" + lvStudentGrades.Items[row].SubItems[col].Text.ToString();
                    }
                    sw.WriteLine(st1);
                }
                sw.Close();
                FileInfo fil = new FileInfo(@"c:\AmazingTestGrader\Student_Grades.xls");
                if (fil.Exists == true)
                    MessageBox.Show("Student grades exported", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
            }
        }

        

        
    }
}
