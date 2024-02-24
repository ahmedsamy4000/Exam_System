namespace Exam_system_App
{
    partial class NewExamForm
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
            nxtBtn = new Button();
            prevBtn = new Button();
            questionLbl = new Label();
            Achoice = new RadioButton();
            Bchoice = new RadioButton();
            Cchoice = new RadioButton();
            Dchoice = new RadioButton();
            submitbtn = new Button();
            SuspendLayout();
            // 
            // nxtBtn
            // 
            nxtBtn.Location = new Point(358, 265);
            nxtBtn.Margin = new Padding(3, 2, 3, 2);
            nxtBtn.Name = "nxtBtn";
            nxtBtn.Size = new Size(239, 22);
            nxtBtn.TabIndex = 0;
            nxtBtn.Text = "Next";
            nxtBtn.UseVisualStyleBackColor = true;
            nxtBtn.Click += nxtBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.Location = new Point(42, 265);
            prevBtn.Margin = new Padding(3, 2, 3, 2);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(239, 22);
            prevBtn.TabIndex = 1;
            prevBtn.Text = "Previous";
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // questionLbl
            // 
            questionLbl.BorderStyle = BorderStyle.FixedSingle;
            questionLbl.Location = new Point(10, 7);
            questionLbl.Name = "questionLbl";
            questionLbl.Size = new Size(912, 61);
            questionLbl.TabIndex = 2;
            questionLbl.Text = "....";
            // 
            // Achoice
            // 
            Achoice.AutoSize = true;
            Achoice.Location = new Point(10, 85);
            Achoice.Margin = new Padding(3, 2, 3, 2);
            Achoice.Name = "Achoice";
            Achoice.Size = new Size(94, 19);
            Achoice.TabIndex = 3;
            Achoice.TabStop = true;
            Achoice.Text = "radioButton1";
            Achoice.UseVisualStyleBackColor = true;
            Achoice.Click += Achoice_Click;
            // 
            // Bchoice
            // 
            Bchoice.AutoSize = true;
            Bchoice.Location = new Point(10, 122);
            Bchoice.Margin = new Padding(3, 2, 3, 2);
            Bchoice.Name = "Bchoice";
            Bchoice.Size = new Size(94, 19);
            Bchoice.TabIndex = 4;
            Bchoice.TabStop = true;
            Bchoice.Text = "radioButton2";
            Bchoice.UseVisualStyleBackColor = true;
            Bchoice.Click += Bchoice_Click;
            // 
            // Cchoice
            // 
            Cchoice.AutoSize = true;
            Cchoice.Location = new Point(10, 153);
            Cchoice.Margin = new Padding(3, 2, 3, 2);
            Cchoice.Name = "Cchoice";
            Cchoice.Size = new Size(94, 19);
            Cchoice.TabIndex = 5;
            Cchoice.TabStop = true;
            Cchoice.Text = "radioButton3";
            Cchoice.UseVisualStyleBackColor = true;
            Cchoice.Click += Cchoice_Click;
            // 
            // Dchoice
            // 
            Dchoice.AutoSize = true;
            Dchoice.Location = new Point(10, 188);
            Dchoice.Margin = new Padding(3, 2, 3, 2);
            Dchoice.Name = "Dchoice";
            Dchoice.Size = new Size(94, 19);
            Dchoice.TabIndex = 6;
            Dchoice.TabStop = true;
            Dchoice.Text = "radioButton4";
            Dchoice.UseVisualStyleBackColor = true;
            Dchoice.Click += Dchoice_Click;
            // 
            // submitbtn
            // 
            submitbtn.Location = new Point(673, 265);
            submitbtn.Margin = new Padding(3, 2, 3, 2);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(239, 22);
            submitbtn.TabIndex = 7;
            submitbtn.Text = "Submit";
            submitbtn.UseVisualStyleBackColor = true;
            submitbtn.Click += submitbtn_Click;
            // 
            // NewExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 338);
            Controls.Add(submitbtn);
            Controls.Add(Dchoice);
            Controls.Add(Cchoice);
            Controls.Add(Bchoice);
            Controls.Add(Achoice);
            Controls.Add(questionLbl);
            Controls.Add(prevBtn);
            Controls.Add(nxtBtn);
            Margin = new Padding(3, 2, 3, 2);
            Name = "NewExamForm";
            Text = "NewExamForm";
            Load += NewExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button nxtBtn;
        private Button prevBtn;
        private Label questionLbl;
        private RadioButton Achoice;
        private RadioButton Bchoice;
        private RadioButton Cchoice;
        private RadioButton Dchoice;
        private Button submitbtn;
    }
}