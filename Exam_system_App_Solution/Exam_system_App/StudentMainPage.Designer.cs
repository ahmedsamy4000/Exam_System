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
            GrdGridView = new DataGridView();
            newww.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GrdGridView).BeginInit();
            SuspendLayout();
            // 
            // newww
            // 
            newww.Controls.Add(tabPage1);
            newww.Controls.Add(tabPage2);
            newww.Location = new Point(1, 3);
            newww.Margin = new Padding(3, 2, 3, 2);
            newww.Name = "newww";
            newww.SelectedIndex = 0;
            newww.Size = new Size(699, 331);
            newww.TabIndex = 0;
            newww.SelectedIndexChanged += TabChanged;
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
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(691, 303);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "New Exam";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.White;
            button1.Location = new Point(160, 190);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(352, 34);
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
            studnamenewexamtxt.Location = new Point(110, 52);
            studnamenewexamtxt.Name = "studnamenewexamtxt";
            studnamenewexamtxt.Size = new Size(77, 28);
            studnamenewexamtxt.TabIndex = 6;
            studnamenewexamtxt.Text = ".............";
            // 
            // studidnewexamtxt
            // 
            studidnewexamtxt.AutoSize = true;
            studidnewexamtxt.Font = new Font("Segoe UI", 15F);
            studidnewexamtxt.ForeColor = Color.White;
            studidnewexamtxt.Location = new Point(64, 17);
            studidnewexamtxt.Name = "studidnewexamtxt";
            studidnewexamtxt.Size = new Size(64, 28);
            studidnewexamtxt.TabIndex = 5;
            studidnewexamtxt.Text = ".............";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 17);
            label3.Name = "label3";
            label3.Size = new Size(38, 28);
            label3.TabIndex = 3;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 52);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // coursescombobox
            // 
            coursescombobox.FormattingEnabled = true;
            coursescombobox.Location = new Point(353, 116);
            coursescombobox.Margin = new Padding(3, 2, 3, 2);
            coursescombobox.Name = "coursescombobox";
            coursescombobox.Size = new Size(160, 23);
            coursescombobox.TabIndex = 1;
            coursescombobox.Text = "Course";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(151, 109);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 0;
            label1.Text = "Choose Course:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(GrdGridView);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(691, 303);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View Grades";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // GrdGridView
            // 
            GrdGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GrdGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GrdGridView.Location = new Point(3, 2);
            GrdGridView.Name = "GrdGridView";
            GrdGridView.Size = new Size(685, 299);
            GrdGridView.TabIndex = 0;
            // 
            // StudentMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(700, 338);
            Controls.Add(newww);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentMainPage";
            Text = "StudentMainPage";
            newww.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GrdGridView).EndInit();
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
        private DataGridView GrdGridView;
    }
}