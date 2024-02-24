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
        public InstructorMainPage()
        {
            InitializeComponent();
        }

        private int mcq;
        private int tf;
        private int examId;
        private string course;
        private int questionSum;



        private void tabPage1_Click(object sender, EventArgs e)
        {
            //Context => Bind to course dropdown list from course table
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            mcq = (int)this.mcqNum.Value;
            tf = (int)this.tfNum.Value;
            course = this.crsCbox.SelectedItem?.ToString() ?? String.Empty;
            questionSum = mcq + tf;

            if (questionSum == 10 && course != String.Empty)
            {
                //EF CODE GENERATE EXAM SP
                MessageBox.Show("y");

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
