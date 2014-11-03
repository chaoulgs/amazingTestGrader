namespace gradingPractice
{
    partial class frmChooseFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChooseFile));
            this.filedialogCsv = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.lblFileNameAdvice = new System.Windows.Forms.Label();
            this.lblSelectedFile = new System.Windows.Forms.Label();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filedialogCsv
            // 
            this.filedialogCsv.FileName = "filedialogCsv";
            this.filedialogCsv.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Location = new System.Drawing.Point(12, 35);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(194, 23);
            this.btnChooseFile.TabIndex = 0;
            this.btnChooseFile.Text = "Select File...";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // lblFileNameAdvice
            // 
            this.lblFileNameAdvice.AutoSize = true;
            this.lblFileNameAdvice.Location = new System.Drawing.Point(11, 89);
            this.lblFileNameAdvice.Name = "lblFileNameAdvice";
            this.lblFileNameAdvice.Size = new System.Drawing.Size(71, 13);
            this.lblFileNameAdvice.TabIndex = 1;
            this.lblFileNameAdvice.Text = "Selected File:";
            // 
            // lblSelectedFile
            // 
            this.lblSelectedFile.AutoSize = true;
            this.lblSelectedFile.Location = new System.Drawing.Point(88, 89);
            this.lblSelectedFile.Name = "lblSelectedFile";
            this.lblSelectedFile.Size = new System.Drawing.Size(80, 13);
            this.lblSelectedFile.TabIndex = 2;
            this.lblSelectedFile.Text = "No file selected";
            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Location = new System.Drawing.Point(12, 9);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(128, 13);
            this.lblAdvice.TabIndex = 3;
            this.lblAdvice.Text = "Select a CSV file to grade";
            this.lblAdvice.Click += new System.EventHandler(this.lblAdvice_Click);
            // 
            // frmChooseFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 113);
            this.Controls.Add(this.lblAdvice);
            this.Controls.Add(this.lblSelectedFile);
            this.Controls.Add(this.lblFileNameAdvice);
            this.Controls.Add(this.btnChooseFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmChooseFile";
            this.Text = "File Selection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmChooseFile_FormClosed);
            this.Load += new System.EventHandler(this.frmChooseFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog filedialogCsv;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label lblFileNameAdvice;
        private System.Windows.Forms.Label lblSelectedFile;
        private System.Windows.Forms.Label lblAdvice;
    }
}