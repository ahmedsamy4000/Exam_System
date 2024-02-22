namespace Exam_system_App
{
    partial class StudentMainPage
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
            newww = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            studnamenewexamtxt = new Label();
            studidnewexamtxt = new Label();
            label3 = new Label();
            label2 = new Label();
            coursescombobox = new ComboBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            newww.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // newww
            // 
            newww.Controls.Add(tabPage1);
            newww.Controls.Add(tabPage2);
            newww.Location = new Point(1, 4);
            newww.Name = "newww";
            newww.SelectedIndex = 0;
            newww.Size = new Size(799, 441);
            newww.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(64, 64, 64);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(studnamenewexamtxt);
            tabPage1.Controls.Add(studidnewexamtxt);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(coursescombobox);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 408);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "New Exam";
            tabPage1.Click += tabPage1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.White;
            button1.Location = new Point(183, 254);
            button1.Name = "button1";
            button1.Size = new Size(402, 45);
            button1.TabIndex = 7;
            button1.Text = "Start Exam";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // studnamenewexamtxt
            // 
            studnamenewexamtxt.AutoSize = true;
            studnamenewexamtxt.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            studnamenewexamtxt.ForeColor = Color.White;
            studnamenewexamtxt.Location = new Point(126, 69);
            studnamenewexamtxt.Name = "studnamenewexamtxt";
            studnamenewexamtxt.Size = new Size(106, 35);
            studnamenewexamtxt.TabIndex = 6;
            studnamenewexamtxt.Text = ".............";
            // 
            // studidnewexamtxt
            // 
            studidnewexamtxt.AutoSize = true;
            studidnewexamtxt.Font = new Font("Segoe UI", 15F);
            studidnewexamtxt.ForeColor = Color.White;
            studidnewexamtxt.Location = new Point(73, 23);
            studidnewexamtxt.Name = "studidnewexamtxt";
            studidnewexamtxt.Size = new Size(80, 35);
            studidnewexamtxt.TabIndex = 5;
            studidnewexamtxt.Text = ".............";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 23);
            label3.Name = "label3";
            label3.Size = new Size(49, 35);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 69);
            label2.Name = "label2";
            label2.Size = new Size(93, 35);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // coursescombobox
            // 
            coursescombobox.FormattingEnabled = true;
            coursescombobox.Location = new Point(403, 154);
            coursescombobox.Name = "coursescombobox";
            coursescombobox.Size = new Size(182, 28);
            coursescombobox.TabIndex = 1;
            coursescombobox.Text = "Course";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(173, 145);
            label1.Name = "label1";
            label1.Size = new Size(191, 35);
            label1.TabIndex = 0;
            label1.Text = "Choose Course:";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 408);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View Grades";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // StudentMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(800, 450);
            Controls.Add(newww);
            Name = "StudentMainPage";
            Text = "StudentMainPage";
            newww.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl newww;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private ComboBox coursescombobox;
        private Label studidnewexamtxt;
        private Label label3;
        private Label label2;
        private Label studnamenewexamtxt;
        private Button button1;
    }
}