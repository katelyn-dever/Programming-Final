using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Final_Project___Katelyn_Dever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //method to retrieve and display the file name with the openFileDialog
       private void GetFile()
        {
            StreamReader inputFile;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //open file dialog box
                openFile.Title = "Choose Student Response File";
                inputFile = File.OpenText(openFile.FileName);

                //Display the file name selected
                inputFileLabel.Text = openFile.FileName;

                //close the file
                inputFile.Close();
            }
            else
            {
                MessageBox.Show("Please select a file to continue");
            }
        }

        //Method to compute and display results
        private void ComputeResults(int correct, int incorrect, List<int> incNumbers)
        {
            //Grade
            double grade = (correct * 5);
            gradeLabel.Text = grade.ToString();

            //Pass or Fail determine and display
            if (correct >= 14)
            {
                passFailLabel.Text = "Pass";
            }
            else
            {
                passFailLabel.Text = "Fail";
            }

            //correct and incorrect labels
            correctNumberLabel.Text = correct.ToString();
            incorrectNumberLabel.Text = incorrect.ToString();

            //incorrect answers label
            foreach (int num in incNumbers)
            {
                questionsMissedListBox.Items.Add(num);
            }
        }
            

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            GetFile();
        }

        private void gradeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //array constant size
                const int SIZE = 20;

                // create an array of size 20 to hold student answers
                string[] studAnswers = new string[SIZE];

                //counter variable to use in loop
                int count = 0;

                //streamreader variable
                StreamReader inputFile;

                //open file
                inputFile = File.OpenText(inputFileLabel.Text);

                //Read file's contents into an array
                while (count < studAnswers.Length && !inputFile.EndOfStream)
                {
                    studAnswers[count] = inputFile.ReadLine();
                    count++;
                }

                //close the file
                inputFile.Close();


                //Create an array of Correct Answers
                string[] correctAnswers = {"B","D","A","A","C","A","B","B","C","D","B",
                                            "C","D","A","D","C","C","B","D","A"};

                //variables to count correct and incorrect
                int correct = 0;
                int incorrect = 0;


                //array to hold incorrect question numbers
                List<int> incNumbers = new List<int>();


                //compare arrays loop
                for (int index = 0; index < correctAnswers.Length; index++)
                {
                    if (studAnswers[index] == correctAnswers[index])
                    {
                        correct++;
                    }
                    else
                    {
                        int problemNumber = index + 1;
                        incNumbers.Add(problemNumber);
                        incorrect++;
                    }
                }
                //Call a method to compute and display results
                ComputeResults(correct, incorrect, incNumbers);
            }
            catch
            {
                MessageBox.Show("There was an error processing your results");
            }

            
                
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear all form elements
            inputFileLabel.Text = "";
            gradeLabel.Text = "";
            passFailLabel.Text = "";
            correctNumberLabel.Text = "";
            incorrectNumberLabel.Text = "";
            questionsMissedListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
