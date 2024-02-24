using Exam_system_App.Context;
using Exam_system_App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_system_App
{

    public partial class NewExamForm : Form
    {

        DBContext context;
        class ExamQuestion
        {
            public string body { get; set; }
            public string choice1 { get; set; }
            public string choice2 { get; set; }
            public string choice3 { get; set; }
            public string choice4 { get; set; }

        }


        List<String> answers = new List<String>(new String[10]);


        public NewExamForm()
        {
            InitializeComponent();
            context = new();

        }

        private int questionIndex = 0;
        List<Question> ExamQuestions;

        List<ExamQuestion> questions = new List<ExamQuestion>();




        private async void NewExamForm_Load(object sender, EventArgs e)
        {

            var exam = await context.Procedures.Exam_SelectAsync(Constants.CrsID);
            Constants.ExID = exam[0].Exam_ID;
            
            var res = await context.Procedures.Exam_Questions_ReportAsync(exam[0].Exam_ID);

            foreach (var item in res)
            {
                questions.Add(new()
                {
                    body = item.Body,
                    choice1 = item.Choice1,
                    choice2 = item.Choice2,
                    choice3 = item.Choice3,
                    choice4 = item.Choice4
                });
            }


            display(questionIndex);

            //SP EXAM_Question_REPORT

            //Bchoice.Checked = false;
            //Dchoice.Checked = false;



        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (questionIndex > 0)
            {
                questionIndex--;
                display(questionIndex);
            }

        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            questionIndex++;
            display(questionIndex);

        }


        private void display(int i)
        {

            submitbtn.Hide();

            if (i == 9)
            {
                nxtBtn.Hide();
                submitbtn.Show();
            }
            else
            {
                nxtBtn.Show();
            }



            Achoice.Checked = false;
            Bchoice.Checked = false;
            Dchoice.Checked = false;
            Cchoice.Checked = false;
            this.questionLbl.Text = questions[i].body.ToString();
            this.Achoice.Text = questions[i].choice1.ToString();
            this.Bchoice.Text = questions[i].choice2.ToString();
            this.Cchoice.Text = questions[i].choice3?.ToString();
            this.Dchoice.Text = questions[i].choice4?.ToString();

            Debug.WriteLine($"uestion index is :{i}");
            Debug.WriteLine($"ANSWER {i} IS :{answers[i]}");





            if (questions[i].choice3 == null)
            {
                Cchoice.Hide();
                Dchoice.Hide();
            }
            else
            {
                Cchoice.Show();
                Dchoice.Show();
            }

            if (answers.Count > 0)
            {

                if (Achoice.Text == answers[i])
                {
                    Achoice.Checked = true;
                }
                else
                {
                    Achoice.Checked = false;
                }

                if (Bchoice.Text.ToString() == answers[i])
                {
                    Bchoice.Checked = true;

                }
                else
                {
                    Bchoice.Checked = false;
                }

                if (Cchoice.Text.ToString() == answers[i])
                {
                    Cchoice.Checked = true;
                }
                else
                {
                    Cchoice.Checked = false;
                }

                if (Dchoice.Text.ToString() == answers[i])
                {
                    Dchoice.Checked = true;
                }
                else
                {
                    Dchoice.Checked = false;
                }
            }

        }



        private void Achoice_Click(object sender, EventArgs e)
        {
            answers[questionIndex] = Achoice.Text;
            Debug.WriteLine($"Value added :{Achoice.Text}");
        }

        private void Bchoice_Click(object sender, EventArgs e)
        {
            answers[questionIndex] = Bchoice.Text;
            Debug.WriteLine($"Value added :{Bchoice.Text}");

        }

        private void Cchoice_Click(object sender, EventArgs e)
        {
            answers[questionIndex] = Cchoice.Text;
            Debug.WriteLine($"Value added :{Cchoice.Text}");
        }

        private void Dchoice_Click(object sender, EventArgs e)
        {
            answers[questionIndex] = Dchoice.Text;
            Debug.WriteLine($"Value added :{Dchoice.Text}");
        }

        private async void submitbtn_Click(object sender, EventArgs e)
        {
            await context.Procedures.Exam_AnswerAsync(
                Constants.ExID,
                Constants.UserID,
                answers[0],
                answers[1],
                answers[2],
                answers[3],
                answers[4],
                answers[5],
                answers[6],
                answers[7],
                answers[8],
                answers[9]
                );
            await context.Procedures.Exam_CorrectionAsync(Constants.ExID, Constants.UserID);
            this.Hide();
            StudentMainPage studentMain = new();
            studentMain.Show();

            

        }
    }
}
