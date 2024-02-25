namespace Exam_system_App
{
    partial class InstructorMainPage
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            generationInfoLbl = new Label();
            generateBtn = new Button();
            label3 = new Label();
            crsCbox = new ComboBox();
            tfNum = new NumericUpDown();
            mcqNum = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            viewBtn = new Button();
            examGridView = new DataGridView();
            examIdNum = new NumericUpDown();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tfNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mcqNum).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)examGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)examIdNum).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(792, 491);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(generationInfoLbl);
            tabPage1.Controls.Add(generateBtn);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(crsCbox);
            tabPage1.Controls.Add(tfNum);
            tabPage1.Controls.Add(mcqNum);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(784, 463);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Generate Exam";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // generationInfoLbl
            // 
            generationInfoLbl.Location = new Point(111, 348);
            generationInfoLbl.Name = "generationInfoLbl";
            generationInfoLbl.Size = new Size(527, 29);
            generationInfoLbl.TabIndex = 7;
            // 
            // generateBtn
            // 
            generateBtn.Anchor = AnchorStyles.None;
            generateBtn.Location = new Point(251, 279);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(252, 26);
            generateBtn.TabIndex = 6;
            generateBtn.Text = "Generate Exam";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(251, 205);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "True/False";
            // 
            // crsCbox
            // 
            crsCbox.Anchor = AnchorStyles.None;
            crsCbox.FormattingEnabled = true;
            crsCbox.Location = new Point(382, 139);
            crsCbox.Name = "crsCbox";
            crsCbox.Size = new Size(121, 23);
            crsCbox.TabIndex = 4;
            // 
            // tfNum
            // 
            tfNum.Anchor = AnchorStyles.None;
            tfNum.Location = new Point(382, 197);
            tfNum.Name = "tfNum";
            tfNum.Size = new Size(121, 23);
            tfNum.TabIndex = 3;
            // 
            // mcqNum
            // 
            mcqNum.Anchor = AnchorStyles.None;
            mcqNum.Location = new Point(382, 168);
            mcqNum.Name = "mcqNum";
            mcqNum.Size = new Size(121, 23);
            mcqNum.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(251, 176);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "MCQ ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(251, 142);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Course Name";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(viewBtn);
            tabPage2.Controls.Add(examGridView);
            tabPage2.Controls.Add(examIdNum);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(784, 463);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View Exam";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // viewBtn
            // 
            viewBtn.Location = new Point(248, 8);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(75, 23);
            viewBtn.TabIndex = 3;
            viewBtn.Text = "View Exam";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // examGridView
            // 
            examGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            examGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            examGridView.Location = new Point(-4, 37);
            examGridView.Name = "examGridView";
            examGridView.Size = new Size(511, 296);
            examGridView.TabIndex = 2;
            // 
            // examIdNum
            // 
            examIdNum.Location = new Point(81, 6);
            examIdNum.Name = "examIdNum";
            examIdNum.Size = new Size(120, 23);
            examIdNum.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 12);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 0;
            label4.Text = "Exam ID";
            // 
            // InstructorMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 489);
            Controls.Add(tabControl1);
            Name = "InstructorMainPage";
            Text = "InstructorMainPage";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tfNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)mcqNum).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)examGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)examIdNum).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private NumericUpDown mcqNum;
        private Label label2;
        private TabPage tabPage2;
        private Button generateBtn;
        private Label label3;
        private NumericUpDown tfNum;
        private Button viewBtn;
        private DataGridView examGridView;
        private NumericUpDown examIdNum;
        private Label label4;
        private ComboBox crsCbox;
        private Label label1;
        private Label generationInfoLbl;
    }
}