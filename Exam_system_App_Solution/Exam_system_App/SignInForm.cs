using Exam_system_App.Context;
using Exam_system_App.Entities;
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
        InstructorMainPage insPage;
        DBContext context;
        public SignInForm()
        {
            InitializeComponent();
            context = new DBContext();
        }

        private async void SignInbtn_Click(object sender, EventArgs e)
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

                //check password and id in table[identity]
                //isSignedIn
                if(identity == "Student")
                {
                    var res = await context.Procedures.studentLoginAsync(id, password);
                    if (res.Count == 0)
                        isSignedIn = false;
                    else
                    {
                        isSignedIn = true;
                        Constants.Username = res[0].ST_Fname + " " + res[0].ST_Lname;
                        Constants.UserID = id;
                    }
                }

                else if (identity == "Instructor")
                {
                    var res = await context.Procedures.instructorLoginAsync(id, password);
                    if (res.Count == 0)
                        isSignedIn = false;
                    else
                    {
                        isSignedIn = true;
                        Constants.Username = res[0].Ins_Name;
                        Constants.UserID = id;

                    }
                }
            }

            else
            {
                MessageBox.Show("incorrect Fields");
            }

            if (isSignedIn)
            {
                if (identity == "Instructor")
                {
                    this.Hide();
                    insPage = new InstructorMainPage();
                    insPage.Show();
                }
                else
                {
                    this.Hide();
                    studPage = new StudentMainPage();
                    
                    studPage.Show();
                    //open stud form
                }
            }
            else
            {
                MessageBox.Show("invalid Login data");
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
