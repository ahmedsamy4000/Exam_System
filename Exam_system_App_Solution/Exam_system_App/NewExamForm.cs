using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_system_App
{
    public partial class NewExamForm : Form
    {

        
        public NewExamForm()
        {
            InitializeComponent();
        }

        private void NewExamForm_Load(object sender, EventArgs e)
        {
            Bchoice.Checked = false;
            Dchoice.Checked = false;
            Bchoice.Hide();
            Dchoice.Hide();

                
            
          



        }
    }
}
