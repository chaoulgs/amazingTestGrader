namespace gradingPractice
{
    partial class frmGrade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrade));
            this.lblNumberOfStudents = new System.Windows.Forms.Label();
            this.lblNumberOfQuestions = new System.Windows.Forms.Label();
            this.randomListBox = new System.Windows.Forms.ListBox();
            this.ddlQuestionList = new System.Windows.Forms.ComboBox();
            this.lblStudentAdvice = new System.Windows.Forms.Label();
            this.lblQuestionAdvice = new System.Windows.Forms.Label();
            this.lblQuestionNumberAdvice = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblListboxAdvice = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.lblCorrectAnswerAdvice = new System.Windows.Forms.Label();
            this.rBtn100 = new System.Windows.Forms.RadioButton();
            this.rBtn90 = new System.Windows.Forms.RadioButton();
            this.rBtn50 = new System.Windows.Forms.RadioButton();
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabInstructions = new System.Windows.Forms.TabPage();
            this.tabGrades = new System.Windows.Forms.TabPage();
            this.lvStudentGrades = new System.Windows.Forms.ListView();
            this.Student = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabIndividual = new System.Windows.Forms.TabPage();
            this.btnExport = new System.Windows.Forms.Button();
            this.lvStudentAnswer = new System.Windows.Forms.ListView();
            this.questionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.keyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.answerColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.creditColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ddlStudentNames = new System.Windows.Forms.ComboBox();
            this.tabAllReports = new System.Windows.Forms.TabPage();
            this.tabRawData = new System.Windows.Forms.TabPage();
            this.rBtn0 = new System.Windows.Forms.RadioButton();
            this.lvAllReports = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExportAll = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectIndividual = new System.Windows.Forms.Label();
            this.btnExportGrades = new System.Windows.Forms.Button();
            this.btnGenerateAllReports = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabMenu.SuspendLayout();
            this.tabInstructions.SuspendLayout();
            this.tabGrades.SuspendLayout();
            this.tabIndividual.SuspendLayout();
            this.tabAllReports.SuspendLayout();
            this.tabRawData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumberOfStudents
            // 
            this.lblNumberOfStudents.AutoSize = true;
            this.lblNumberOfStudents.Location = new System.Drawing.Point(271, 609);
            this.lblNumberOfStudents.Name = "lblNumberOfStudents";
            this.lblNumberOfStudents.Size = new System.Drawing.Size(35, 13);
            this.lblNumberOfStudents.TabIndex = 1;
            this.lblNumberOfStudents.Text = "label1";
            // 
            // lblNumberOfQuestions
            // 
            this.lblNumberOfQuestions.AutoSize = true;
            this.lblNumberOfQuestions.Location = new System.Drawing.Point(508, 609);
            this.lblNumberOfQuestions.Name = "lblNumberOfQuestions";
            this.lblNumberOfQuestions.Size = new System.Drawing.Size(35, 13);
            this.lblNumberOfQuestions.TabIndex = 2;
            this.lblNumberOfQuestions.Text = "label2";
            // 
            // randomListBox
            // 
            this.randomListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.randomListBox.FormattingEnabled = true;
            this.randomListBox.ItemHeight = 16;
            this.randomListBox.Location = new System.Drawing.Point(164, 77);
            this.randomListBox.Name = "randomListBox";
            this.randomListBox.Size = new System.Drawing.Size(378, 516);
            this.randomListBox.TabIndex = 0;
            this.randomListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ddlQuestionList
            // 
            this.ddlQuestionList.FormattingEnabled = true;
            this.ddlQuestionList.IntegralHeight = false;
            this.ddlQuestionList.Location = new System.Drawing.Point(12, 77);
            this.ddlQuestionList.Name = "ddlQuestionList";
            this.ddlQuestionList.Size = new System.Drawing.Size(140, 21);
            this.ddlQuestionList.TabIndex = 3;
            this.ddlQuestionList.SelectedIndexChanged += new System.EventHandler(this.ddlQuestionList_SelectedIndexChanged);
            this.ddlQuestionList.SelectedValueChanged += new System.EventHandler(this.ddlQuestionList_SelectedValueChanged);
            // 
            // lblStudentAdvice
            // 
            this.lblStudentAdvice.AutoSize = true;
            this.lblStudentAdvice.Location = new System.Drawing.Point(161, 609);
            this.lblStudentAdvice.Name = "lblStudentAdvice";
            this.lblStudentAdvice.Size = new System.Drawing.Size(104, 13);
            this.lblStudentAdvice.TabIndex = 4;
            this.lblStudentAdvice.Text = "Number of Students:";
            // 
            // lblQuestionAdvice
            // 
            this.lblQuestionAdvice.AutoSize = true;
            this.lblQuestionAdvice.Location = new System.Drawing.Point(393, 609);
            this.lblQuestionAdvice.Name = "lblQuestionAdvice";
            this.lblQuestionAdvice.Size = new System.Drawing.Size(109, 13);
            this.lblQuestionAdvice.TabIndex = 5;
            this.lblQuestionAdvice.Text = "Number of Questions:";
            // 
            // lblQuestionNumberAdvice
            // 
            this.lblQuestionNumberAdvice.AutoSize = true;
            this.lblQuestionNumberAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblQuestionNumberAdvice.Location = new System.Drawing.Point(12, 55);
            this.lblQuestionNumberAdvice.Name = "lblQuestionNumberAdvice";
            this.lblQuestionNumberAdvice.Size = new System.Drawing.Size(119, 17);
            this.lblQuestionNumberAdvice.TabIndex = 6;
            this.lblQuestionNumberAdvice.Text = "Question Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(451, 590);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblListboxAdvice
            // 
            this.lblListboxAdvice.AutoSize = true;
            this.lblListboxAdvice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblListboxAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblListboxAdvice.ForeColor = System.Drawing.Color.Maroon;
            this.lblListboxAdvice.Location = new System.Drawing.Point(161, 55);
            this.lblListboxAdvice.Name = "lblListboxAdvice";
            this.lblListboxAdvice.Size = new System.Drawing.Size(184, 17);
            this.lblListboxAdvice.TabIndex = 8;
            this.lblListboxAdvice.Text = "Incorrect Answers Below";
            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCorrectAnswer.Location = new System.Drawing.Point(309, 25);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Size = new System.Drawing.Size(77, 17);
            this.lblCorrectAnswer.TabIndex = 9;
            this.lblCorrectAnswer.Text = "unselected";
            this.lblCorrectAnswer.Click += new System.EventHandler(this.lblCorrectAnswer_Click);
            // 
            // lblCorrectAnswerAdvice
            // 
            this.lblCorrectAnswerAdvice.AutoSize = true;
            this.lblCorrectAnswerAdvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCorrectAnswerAdvice.ForeColor = System.Drawing.Color.OliveDrab;
            this.lblCorrectAnswerAdvice.Location = new System.Drawing.Point(161, 25);
            this.lblCorrectAnswerAdvice.Name = "lblCorrectAnswerAdvice";
            this.lblCorrectAnswerAdvice.Size = new System.Drawing.Size(142, 17);
            this.lblCorrectAnswerAdvice.TabIndex = 10;
            this.lblCorrectAnswerAdvice.Text = "Correct answer(s):";
            this.lblCorrectAnswerAdvice.Click += new System.EventHandler(this.lblCorrectAnswerAdvice_Click);
            // 
            // rBtn100
            // 
            this.rBtn100.AutoSize = true;
            this.rBtn100.Location = new System.Drawing.Point(83, 108);
            this.rBtn100.Name = "rBtn100";
            this.rBtn100.Size = new System.Drawing.Size(71, 17);
            this.rBtn100.TabIndex = 11;
            this.rBtn100.TabStop = true;
            this.rBtn100.Text = "Full Credit";
            this.rBtn100.UseVisualStyleBackColor = true;
            this.rBtn100.CheckedChanged += new System.EventHandler(this.rBtn100_CheckedChanged);
            // 
            // rBtn90
            // 
            this.rBtn90.AutoSize = true;
            this.rBtn90.Location = new System.Drawing.Point(83, 132);
            this.rBtn90.Name = "rBtn90";
            this.rBtn90.Size = new System.Drawing.Size(45, 17);
            this.rBtn90.TabIndex = 12;
            this.rBtn90.TabStop = true;
            this.rBtn90.Text = "90%";
            this.rBtn90.UseVisualStyleBackColor = true;
            this.rBtn90.CheckedChanged += new System.EventHandler(this.rBtn90_CheckedChanged);
            // 
            // rBtn50
            // 
            this.rBtn50.AutoSize = true;
            this.rBtn50.Location = new System.Drawing.Point(83, 156);
            this.rBtn50.Name = "rBtn50";
            this.rBtn50.Size = new System.Drawing.Size(45, 17);
            this.rBtn50.TabIndex = 13;
            this.rBtn50.TabStop = true;
            this.rBtn50.Text = "50%";
            this.rBtn50.UseVisualStyleBackColor = true;
            this.rBtn50.CheckedChanged += new System.EventHandler(this.rBtn50_CheckedChanged);
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabInstructions);
            this.tabMenu.Controls.Add(this.tabGrades);
            this.tabMenu.Controls.Add(this.tabIndividual);
            this.tabMenu.Controls.Add(this.tabAllReports);
            this.tabMenu.Controls.Add(this.tabRawData);
            this.tabMenu.Location = new System.Drawing.Point(549, 61);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(465, 586);
            this.tabMenu.TabIndex = 15;
            // 
            // tabInstructions
            // 
            this.tabInstructions.Controls.Add(this.label7);
            this.tabInstructions.Controls.Add(this.label6);
            this.tabInstructions.Controls.Add(this.lblCredit);
            this.tabInstructions.Controls.Add(this.label5);
            this.tabInstructions.Controls.Add(this.label4);
            this.tabInstructions.Controls.Add(this.lblWarning);
            this.tabInstructions.Controls.Add(this.label3);
            this.tabInstructions.Controls.Add(this.label2);
            this.tabInstructions.Controls.Add(this.label1);
            this.tabInstructions.Controls.Add(this.lblInstructions);
            this.tabInstructions.Location = new System.Drawing.Point(4, 22);
            this.tabInstructions.Name = "tabInstructions";
            this.tabInstructions.Padding = new System.Windows.Forms.Padding(3);
            this.tabInstructions.Size = new System.Drawing.Size(457, 560);
            this.tabInstructions.TabIndex = 1;
            this.tabInstructions.Text = "Instructions";
            this.tabInstructions.UseVisualStyleBackColor = true;
            // 
            // tabGrades
            // 
            this.tabGrades.Controls.Add(this.btnExportGrades);
            this.tabGrades.Controls.Add(this.lvStudentGrades);
            this.tabGrades.Location = new System.Drawing.Point(4, 22);
            this.tabGrades.Name = "tabGrades";
            this.tabGrades.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrades.Size = new System.Drawing.Size(457, 560);
            this.tabGrades.TabIndex = 0;
            this.tabGrades.Text = "Grades";
            this.tabGrades.UseVisualStyleBackColor = true;
            // 
            // lvStudentGrades
            // 
            this.lvStudentGrades.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Student,
            this.Grade});
            this.lvStudentGrades.GridLines = true;
            this.lvStudentGrades.Location = new System.Drawing.Point(6, 38);
            this.lvStudentGrades.Name = "lvStudentGrades";
            this.lvStudentGrades.Size = new System.Drawing.Size(443, 555);
            this.lvStudentGrades.TabIndex = 0;
            this.lvStudentGrades.UseCompatibleStateImageBehavior = false;
            this.lvStudentGrades.View = System.Windows.Forms.View.Details;
            this.lvStudentGrades.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Student
            // 
            this.Student.Text = "Name";
            this.Student.Width = 96;
            // 
            // Grade
            // 
            this.Grade.Text = "Grade";
            this.Grade.Width = 80;
            // 
            // tabIndividual
            // 
            this.tabIndividual.Controls.Add(this.lblSelectIndividual);
            this.tabIndividual.Controls.Add(this.btnExport);
            this.tabIndividual.Controls.Add(this.lvStudentAnswer);
            this.tabIndividual.Controls.Add(this.ddlStudentNames);
            this.tabIndividual.Location = new System.Drawing.Point(4, 22);
            this.tabIndividual.Name = "tabIndividual";
            this.tabIndividual.Padding = new System.Windows.Forms.Padding(3);
            this.tabIndividual.Size = new System.Drawing.Size(457, 560);
            this.tabIndividual.TabIndex = 2;
            this.tabIndividual.Text = "Individual Report";
            this.tabIndividual.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(329, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(118, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lvStudentAnswer
            // 
            this.lvStudentAnswer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.questionColumn,
            this.keyColumn,
            this.answerColumn,
            this.creditColumn});
            this.lvStudentAnswer.GridLines = true;
            this.lvStudentAnswer.Location = new System.Drawing.Point(6, 49);
            this.lvStudentAnswer.Name = "lvStudentAnswer";
            this.lvStudentAnswer.Size = new System.Drawing.Size(443, 490);
            this.lvStudentAnswer.TabIndex = 1;
            this.lvStudentAnswer.UseCompatibleStateImageBehavior = false;
            this.lvStudentAnswer.View = System.Windows.Forms.View.Details;
            this.lvStudentAnswer.SelectedIndexChanged += new System.EventHandler(this.lvStudentAnswer_SelectedIndexChanged);
            // 
            // questionColumn
            // 
            this.questionColumn.Text = "Question";
            this.questionColumn.Width = 57;
            // 
            // keyColumn
            // 
            this.keyColumn.Text = "Correct Answer";
            this.keyColumn.Width = 89;
            // 
            // answerColumn
            // 
            this.answerColumn.Text = "Submitted Answer";
            this.answerColumn.Width = 174;
            // 
            // creditColumn
            // 
            this.creditColumn.Text = "Credit Earned";
            this.creditColumn.Width = 77;
            // 
            // ddlStudentNames
            // 
            this.ddlStudentNames.FormattingEnabled = true;
            this.ddlStudentNames.Location = new System.Drawing.Point(6, 19);
            this.ddlStudentNames.Name = "ddlStudentNames";
            this.ddlStudentNames.Size = new System.Drawing.Size(241, 21);
            this.ddlStudentNames.TabIndex = 0;
            this.ddlStudentNames.SelectedIndexChanged += new System.EventHandler(this.ddlStudentNames_SelectedIndexChanged);
            // 
            // tabAllReports
            // 
            this.tabAllReports.Controls.Add(this.btnGenerateAllReports);
            this.tabAllReports.Controls.Add(this.btnExportAll);
            this.tabAllReports.Controls.Add(this.lvAllReports);
            this.tabAllReports.Location = new System.Drawing.Point(4, 22);
            this.tabAllReports.Name = "tabAllReports";
            this.tabAllReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllReports.Size = new System.Drawing.Size(457, 560);
            this.tabAllReports.TabIndex = 3;
            this.tabAllReports.Text = "All Reports";
            this.tabAllReports.UseVisualStyleBackColor = true;
            // 
            // tabRawData
            // 
            this.tabRawData.Controls.Add(this.dataGridView1);
            this.tabRawData.Location = new System.Drawing.Point(4, 22);
            this.tabRawData.Name = "tabRawData";
            this.tabRawData.Padding = new System.Windows.Forms.Padding(3);
            this.tabRawData.Size = new System.Drawing.Size(457, 560);
            this.tabRawData.TabIndex = 4;
            this.tabRawData.Text = "Raw Test Data";
            this.tabRawData.UseVisualStyleBackColor = true;
            // 
            // rBtn0
            // 
            this.rBtn0.AutoSize = true;
            this.rBtn0.Location = new System.Drawing.Point(83, 180);
            this.rBtn0.Name = "rBtn0";
            this.rBtn0.Size = new System.Drawing.Size(69, 17);
            this.rBtn0.TabIndex = 17;
            this.rBtn0.TabStop = true;
            this.rBtn0.Text = "No Credit";
            this.rBtn0.UseVisualStyleBackColor = true;
            this.rBtn0.CheckedChanged += new System.EventHandler(this.rBtn0_CheckedChanged);
            // 
            // lvAllReports
            // 
            this.lvAllReports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvAllReports.GridLines = true;
            this.lvAllReports.Location = new System.Drawing.Point(0, 39);
            this.lvAllReports.Name = "lvAllReports";
            this.lvAllReports.Size = new System.Drawing.Size(454, 500);
            this.lvAllReports.TabIndex = 2;
            this.lvAllReports.UseCompatibleStateImageBehavior = false;
            this.lvAllReports.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Question";
            this.columnHeader1.Width = 57;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Correct Answer";
            this.columnHeader2.Width = 98;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Submitted Answer";
            this.columnHeader3.Width = 174;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Credit Earned";
            this.columnHeader4.Width = 80;
            // 
            // btnExportAll
            // 
            this.btnExportAll.BackColor = System.Drawing.Color.Transparent;
            this.btnExportAll.Location = new System.Drawing.Point(319, 6);
            this.btnExportAll.Name = "btnExportAll";
            this.btnExportAll.Size = new System.Drawing.Size(132, 27);
            this.btnExportAll.TabIndex = 3;
            this.btnExportAll.Text = "Export to Excel";
            this.btnExportAll.UseVisualStyleBackColor = false;
            this.btnExportAll.Click += new System.EventHandler(this.btnExportAll_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(3, 15);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(441, 39);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Ensure data is prepared to be graded by making sure the first column in your spre" +
    "adsheet is the name/pledge columns, with answers beginning at the second column." +
    "  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "The second row of your spreadsheet must be the answer key values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select a question from the drop down box to the left to begin";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "Choose an answer from the incorrect answers box and use the buttons on the left t" +
    "o determine how much credit to award for that answer - this automatically update" +
    "s the grade totals in the Grades tab";
            // 
            // lblSelectIndividual
            // 
            this.lblSelectIndividual.AutoSize = true;
            this.lblSelectIndividual.Location = new System.Drawing.Point(7, 4);
            this.lblSelectIndividual.Name = "lblSelectIndividual";
            this.lblSelectIndividual.Size = new System.Drawing.Size(84, 13);
            this.lblSelectIndividual.TabIndex = 3;
            this.lblSelectIndividual.Text = "Select a student";
            // 
            // btnExportGrades
            // 
            this.btnExportGrades.Location = new System.Drawing.Point(341, 6);
            this.btnExportGrades.Name = "btnExportGrades";
            this.btnExportGrades.Size = new System.Drawing.Size(106, 23);
            this.btnExportGrades.TabIndex = 1;
            this.btnExportGrades.Text = "Export to Excel";
            this.btnExportGrades.UseVisualStyleBackColor = true;
            this.btnExportGrades.Click += new System.EventHandler(this.btnExportGrades_Click);
            // 
            // btnGenerateAllReports
            // 
            this.btnGenerateAllReports.Location = new System.Drawing.Point(7, 7);
            this.btnGenerateAllReports.Name = "btnGenerateAllReports";
            this.btnGenerateAllReports.Size = new System.Drawing.Size(156, 23);
            this.btnGenerateAllReports.TabIndex = 4;
            this.btnGenerateAllReports.Text = "Generate Combined Report";
            this.btnGenerateAllReports.UseVisualStyleBackColor = true;
            this.btnGenerateAllReports.Click += new System.EventHandler(this.btnGenerateAllReports_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWarning.ForeColor = System.Drawing.Color.Crimson;
            this.lblWarning.Location = new System.Drawing.Point(6, 489);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(373, 36);
            this.lblWarning.TabIndex = 4;
            this.lblWarning.Text = "DO NOT CLOSE THIS BEFORE YOU FINISH GRADING - YOU WILL LOSE YOUR PROGRESS";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(2, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(441, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "The denominator of the grade displayed in the \"Grades\" tab is equal to the Number" +
    " of Question in the bottom center";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(436, 60);
            this.label5.TabIndex = 6;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCredit.Location = new System.Drawing.Point(6, 527);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(257, 12);
            this.lblCredit.TabIndex = 7;
            this.lblCredit.Text = "Created by Gabriel S. Chaoul for the VCU Biology Department";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(440, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "If the answer to the question is in numbers, the program has already automaticall" +
    "y graded it, no further action is needed (answers in numbers indicates that the " +
    "question was a multi-answer question)";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(434, 34);
            this.label7.TabIndex = 9;
            this.label7.Text = "When creating your answer key, if you\'d like for there to be multiple correct ans" +
    "wers, just separate them with a backslash ( / ) - no spaces between answers nece" +
    "ssary";
            // 
            // frmGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 631);
            this.Controls.Add(this.rBtn0);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.rBtn50);
            this.Controls.Add(this.rBtn90);
            this.Controls.Add(this.rBtn100);
            this.Controls.Add(this.lblCorrectAnswerAdvice);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.lblListboxAdvice);
            this.Controls.Add(this.lblQuestionNumberAdvice);
            this.Controls.Add(this.lblQuestionAdvice);
            this.Controls.Add(this.lblStudentAdvice);
            this.Controls.Add(this.ddlQuestionList);
            this.Controls.Add(this.lblNumberOfQuestions);
            this.Controls.Add(this.lblNumberOfStudents);
            this.Controls.Add(this.randomListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGrade";
            this.Text = "The Amazing Test Grader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmGrade_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGrade_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabMenu.ResumeLayout(false);
            this.tabInstructions.ResumeLayout(false);
            this.tabInstructions.PerformLayout();
            this.tabGrades.ResumeLayout(false);
            this.tabIndividual.ResumeLayout(false);
            this.tabIndividual.PerformLayout();
            this.tabAllReports.ResumeLayout(false);
            this.tabRawData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberOfStudents;
        private System.Windows.Forms.Label lblNumberOfQuestions;
        private System.Windows.Forms.ListBox randomListBox;
        private System.Windows.Forms.ComboBox ddlQuestionList;
        private System.Windows.Forms.Label lblStudentAdvice;
        private System.Windows.Forms.Label lblQuestionAdvice;
        private System.Windows.Forms.Label lblQuestionNumberAdvice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblListboxAdvice;
        private System.Windows.Forms.Label lblCorrectAnswer;
        private System.Windows.Forms.Label lblCorrectAnswerAdvice;
        private System.Windows.Forms.RadioButton rBtn100;
        private System.Windows.Forms.RadioButton rBtn90;
        private System.Windows.Forms.RadioButton rBtn50;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabInstructions;
        private System.Windows.Forms.TabPage tabGrades;
        private System.Windows.Forms.ListView lvStudentGrades;
        private System.Windows.Forms.ColumnHeader Student;
        private System.Windows.Forms.ColumnHeader Grade;
        private System.Windows.Forms.TabPage tabIndividual;
        private System.Windows.Forms.RadioButton rBtn0;
        private System.Windows.Forms.TabPage tabAllReports;
        private System.Windows.Forms.TabPage tabRawData;
        private System.Windows.Forms.ComboBox ddlStudentNames;
        private System.Windows.Forms.ListView lvStudentAnswer;
        private System.Windows.Forms.ColumnHeader questionColumn;
        private System.Windows.Forms.ColumnHeader keyColumn;
        private System.Windows.Forms.ColumnHeader answerColumn;
        private System.Windows.Forms.ColumnHeader creditColumn;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ListView lvAllReports;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnExportAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Label lblSelectIndividual;
        private System.Windows.Forms.Button btnExportGrades;
        private System.Windows.Forms.Button btnGenerateAllReports;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

