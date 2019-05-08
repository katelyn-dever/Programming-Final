namespace Final_Project___Katelyn_Dever
{
    partial class Form1
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
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.studentLabel = new System.Windows.Forms.Label();
            this.descPassFailLabel = new System.Windows.Forms.Label();
            this.descCorrectLabel = new System.Windows.Forms.Label();
            this.descIncorrectLabel = new System.Windows.Forms.Label();
            this.descMissedLabel = new System.Windows.Forms.Label();
            this.passFailLabel = new System.Windows.Forms.Label();
            this.correctNumberLabel = new System.Windows.Forms.Label();
            this.incorrectNumberLabel = new System.Windows.Forms.Label();
            this.gradeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.descGradeLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.inputFileLabel = new System.Windows.Forms.Label();
            this.questionsMissedListBox = new System.Windows.Forms.ListBox();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(120, 41);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(207, 17);
            this.studentLabel.TabIndex = 0;
            this.studentLabel.Text = "Choose Student Response File:";
            // 
            // descPassFailLabel
            // 
            this.descPassFailLabel.AutoSize = true;
            this.descPassFailLabel.Location = new System.Drawing.Point(65, 94);
            this.descPassFailLabel.Name = "descPassFailLabel";
            this.descPassFailLabel.Size = new System.Drawing.Size(177, 17);
            this.descPassFailLabel.TabIndex = 1;
            this.descPassFailLabel.Text = "Pass or Fail (70 or higher):";
            // 
            // descCorrectLabel
            // 
            this.descCorrectLabel.AutoSize = true;
            this.descCorrectLabel.Location = new System.Drawing.Point(65, 142);
            this.descCorrectLabel.Name = "descCorrectLabel";
            this.descCorrectLabel.Size = new System.Drawing.Size(185, 17);
            this.descCorrectLabel.TabIndex = 2;
            this.descCorrectLabel.Text = "Number of Correct Answers:";
            // 
            // descIncorrectLabel
            // 
            this.descIncorrectLabel.AutoSize = true;
            this.descIncorrectLabel.Location = new System.Drawing.Point(65, 190);
            this.descIncorrectLabel.Name = "descIncorrectLabel";
            this.descIncorrectLabel.Size = new System.Drawing.Size(194, 17);
            this.descIncorrectLabel.TabIndex = 3;
            this.descIncorrectLabel.Text = "Number of Incorrect Answers:";
            // 
            // descMissedLabel
            // 
            this.descMissedLabel.AutoSize = true;
            this.descMissedLabel.Location = new System.Drawing.Point(65, 238);
            this.descMissedLabel.Name = "descMissedLabel";
            this.descMissedLabel.Size = new System.Drawing.Size(124, 17);
            this.descMissedLabel.TabIndex = 4;
            this.descMissedLabel.Text = "Questions Missed:";
            // 
            // passFailLabel
            // 
            this.passFailLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.passFailLabel.Location = new System.Drawing.Point(384, 81);
            this.passFailLabel.Name = "passFailLabel";
            this.passFailLabel.Size = new System.Drawing.Size(172, 30);
            this.passFailLabel.TabIndex = 5;
            this.passFailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctNumberLabel
            // 
            this.correctNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.correctNumberLabel.Location = new System.Drawing.Point(384, 129);
            this.correctNumberLabel.Name = "correctNumberLabel";
            this.correctNumberLabel.Size = new System.Drawing.Size(172, 30);
            this.correctNumberLabel.TabIndex = 6;
            this.correctNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incorrectNumberLabel
            // 
            this.incorrectNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.incorrectNumberLabel.Location = new System.Drawing.Point(384, 177);
            this.incorrectNumberLabel.Name = "incorrectNumberLabel";
            this.incorrectNumberLabel.Size = new System.Drawing.Size(172, 30);
            this.incorrectNumberLabel.TabIndex = 7;
            this.incorrectNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradeButton
            // 
            this.gradeButton.Location = new System.Drawing.Point(175, 462);
            this.gradeButton.Name = "gradeButton";
            this.gradeButton.Size = new System.Drawing.Size(126, 44);
            this.gradeButton.TabIndex = 9;
            this.gradeButton.Text = "Calculate Grade";
            this.gradeButton.UseVisualStyleBackColor = true;
            this.gradeButton.Click += new System.EventHandler(this.gradeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(329, 462);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(126, 44);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear Form";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(483, 462);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(126, 44);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // descGradeLabel
            // 
            this.descGradeLabel.AutoSize = true;
            this.descGradeLabel.Location = new System.Drawing.Point(65, 46);
            this.descGradeLabel.Name = "descGradeLabel";
            this.descGradeLabel.Size = new System.Drawing.Size(52, 17);
            this.descGradeLabel.TabIndex = 12;
            this.descGradeLabel.Text = "Grade:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gradeLabel.Location = new System.Drawing.Point(384, 33);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(172, 30);
            this.gradeLabel.TabIndex = 13;
            this.gradeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Controls.Add(this.questionsMissedListBox);
            this.groupBoxResults.Controls.Add(this.gradeLabel);
            this.groupBoxResults.Controls.Add(this.descGradeLabel);
            this.groupBoxResults.Controls.Add(this.passFailLabel);
            this.groupBoxResults.Controls.Add(this.correctNumberLabel);
            this.groupBoxResults.Controls.Add(this.incorrectNumberLabel);
            this.groupBoxResults.Controls.Add(this.descMissedLabel);
            this.groupBoxResults.Controls.Add(this.descIncorrectLabel);
            this.groupBoxResults.Controls.Add(this.descPassFailLabel);
            this.groupBoxResults.Controls.Add(this.descCorrectLabel);
            this.groupBoxResults.Location = new System.Drawing.Point(61, 80);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(679, 346);
            this.groupBoxResults.TabIndex = 14;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(344, 38);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(123, 23);
            this.chooseFileButton.TabIndex = 15;
            this.chooseFileButton.Text = "Choose File...";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // inputFileLabel
            // 
            this.inputFileLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputFileLabel.Location = new System.Drawing.Point(489, 35);
            this.inputFileLabel.Name = "inputFileLabel";
            this.inputFileLabel.Size = new System.Drawing.Size(192, 29);
            this.inputFileLabel.TabIndex = 16;
            this.inputFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionsMissedListBox
            // 
            this.questionsMissedListBox.FormattingEnabled = true;
            this.questionsMissedListBox.ItemHeight = 16;
            this.questionsMissedListBox.Location = new System.Drawing.Point(384, 238);
            this.questionsMissedListBox.Name = "questionsMissedListBox";
            this.questionsMissedListBox.Size = new System.Drawing.Size(172, 84);
            this.questionsMissedListBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 533);
            this.Controls.Add(this.inputFileLabel);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.groupBoxResults);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.gradeButton);
            this.Controls.Add(this.studentLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxResults.ResumeLayout(false);
            this.groupBoxResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label descPassFailLabel;
        private System.Windows.Forms.Label descCorrectLabel;
        private System.Windows.Forms.Label descIncorrectLabel;
        private System.Windows.Forms.Label descMissedLabel;
        private System.Windows.Forms.Label passFailLabel;
        private System.Windows.Forms.Label correctNumberLabel;
        private System.Windows.Forms.Label incorrectNumberLabel;
        private System.Windows.Forms.Button gradeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label descGradeLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.Label inputFileLabel;
        private System.Windows.Forms.ListBox questionsMissedListBox;
    }
}

