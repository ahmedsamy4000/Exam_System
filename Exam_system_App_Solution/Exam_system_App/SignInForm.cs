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
    public partial class SignInForm : Form
    {
        StudentMainPage studPage;
        public SignInForm()
        {
            InitializeComponent();

        }

        private void SignInbtn_Click(object sender, EventArgs e)
        {
            int id;
            string password = passwordtxtbox.Text;
            string identity;
            bool isSignedIn = false;
            if (choosecombobox.SelectedItem == null)
            {
                identity = String.Empty;
            }
            else
            {
                identity = choosecombobox.SelectedItem.ToString();
            }
            if (int.TryParse(idtxtbox.Text, out id) && password != String.Empty && identity != String.Empty)
            {



            }

            else
            {
                MessageBox.Show("incorrect Fields");
            }

            if (!isSignedIn)
            {
                this.Hide();
                if (identity == "Instructor")
                {
                    //open ins form
                }
                else
                {
                    this.Hide();
                    studPage = new StudentMainPage();
                    Constants.studentID = id;
                    studPage.Show();
                    //open stud form
                }

            }
            else
            {

            }







        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void idtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
