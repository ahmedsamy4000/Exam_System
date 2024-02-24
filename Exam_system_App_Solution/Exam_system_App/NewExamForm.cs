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
    public partial class NewExamForm : Form
    {

        DBContext context;
        public NewExamForm()
        {
            InitializeComponent();
            context = new();
        }

        private async void NewExamForm_Load(object sender, EventArgs e)
        {
            Bchoice.Checked = false;
            Dchoice.Checked = false;
            Bchoice.Hide();
            Dchoice.Hide();


            var exam = await context.Procedures.Exam_SelectAsync(Constants.CrsID);
            foreach (var item in exam)
            {
                Debug.WriteLine($"idddddddddd:{item.Exam_ID}");
            }








        }
    }
}
