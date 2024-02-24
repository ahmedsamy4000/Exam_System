using Exam_system_App.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_system_App
{
    public partial class StudentMainPage : Form
    {
        NewExamForm examform;
        DBContext context;
        public StudentMainPage()
        {
            InitializeComponent();
            context = new();

            studidnewexamtxt.Text = Constants.UserID.ToString();
            studnamenewexamtxt.Text = Constants.Username.ToString();
            this.Load += StudentMainPage_Load;
        }

        private async void StudentMainPage_Load(object? sender, EventArgs e)
        {

            int userID = Constants.UserID;
            var courses = await context.Procedures.StudentChooseCourseAsync(userID);
            coursescombobox.DataSource = courses;
            coursescombobox.DisplayMember = "Crs_name";
            coursescombobox.ValueMember = "Crs_ID";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Constants.CrsID = (int)coursescombobox.SelectedValue;
            examform = new NewExamForm();
            examform.Show();
        }

        private async void TabChanged(object sender, EventArgs e)
        {
            TabPage selectedTab = newww.SelectedTab;

            if (selectedTab == tabPage2)
            {
                var res = await context.Procedures.Student_Grade_ReportAsync(Constants.UserID);
                GrdGridView.DataSource = res.ToList();
                GrdGridView.Columns["St_ID"].ReadOnly = true;
                GrdGridView.Columns["Crs_name"].ReadOnly = true;
                GrdGridView.Columns["Final_Grade"].ReadOnly = true;
            }
        }
    }
}
