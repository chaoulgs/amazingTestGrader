using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gradingPractice
{
    public partial class frmChooseFile : Form
    {
        string _fileName;

        public string FileName { get; set; }

        public frmChooseFile()
        {
            InitializeComponent();
        }

        private void frmChooseFile_Load(object sender, EventArgs e)
        {
            filedialogCsv.Filter = "Csv Files (.csv)|*.csv";
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public void btnChooseFile_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = filedialogCsv.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                _fileName = filedialogCsv.FileName;
                lblSelectedFile.Text = _fileName;
                FileName = _fileName;
                Hide();               
                //gradeAssignment.ShowDialog();

            }
        }

        private void frmChooseFile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblAdvice_Click(object sender, EventArgs e)
        {

        }

        
    }
}
