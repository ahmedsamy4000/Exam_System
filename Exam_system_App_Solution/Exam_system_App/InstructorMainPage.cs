using Exam_system_App.Context;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_system_App
{
    public partial class InstructorMainPage : Form
    {
        DBContext context = new();
        public InstructorMainPage()
        {
            InitializeComponent();
            Load += InstructorMainPage_Load;
        }

        private async void InstructorMainPage_Load(object? sender, EventArgs e)
        {
            var res = await context.Procedures.InstructorChooseCourseAsync(Constants.UserID);
            crsCbox.DataSource = res;
            crsCbox.DisplayMember = "Crs_name";
            crsCbox.ValueMember = "Crs_ID";

        }

        private int mcq;
        private int tf;
        private int examId;
        private string course;
        private int questionSum;


        

        private async void generateBtn_Click(object sender, EventArgs e)
        {

            

           
            //context.Database.SetCommandTimeout(120);
            mcq = (int)this.mcqNum.Value;
            tf = (int)this.tfNum.Value;
            course = this.crsCbox.SelectedValue?.ToString() ?? String.Empty;
            questionSum = mcq + tf;

            var parameters = new[]
            {
                new SqlParameter("@name", course),
                new SqlParameter("@mcq", mcq),
                new SqlParameter("@tf", tf)
            };

            
            if (questionSum == 10 && course != String.Empty)
            {

                //EF CODE GENERATE EXAM SP
                await context.Procedures.Exam_GenerationAsync(course, mcq, tf);

                var ex = context.Exams.Select(e => e.ExamId).OrderByDescending(exID => exID).FirstOrDefault();
                generationInfoLbl.Text = $"exam {ex} generated successfully";
                

            }   
            else
            {
                MessageBox.Show("Questions must be 10!");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            examId = (int)this.examIdNum.Value;
            //SP EXAM_QUESTION_REPORT
            //this.examGridView.BindingContext
        }
    }
}
