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
            nxtBtn.Location = new Point(409, 353);
            nxtBtn.Name = "nxtBtn";
            nxtBtn.Size = new Size(273, 29);
            nxtBtn.TabIndex = 0;
            nxtBtn.Text = "Next";
            nxtBtn.UseVisualStyleBackColor = true;
            nxtBtn.Click += nxtBtn_Click;
            // 
            // prevBtn
            // 
            prevBtn.Location = new Point(48, 353);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(273, 29);
            prevBtn.TabIndex = 1;
            prevBtn.Text = "Previous";
            prevBtn.UseVisualStyleBackColor = true;
            prevBtn.Click += prevBtn_Click;
            // 
            // questionLbl
            // 
            questionLbl.BorderStyle = BorderStyle.FixedSingle;
            questionLbl.Location = new Point(11, 9);
            questionLbl.Name = "questionLbl";
            questionLbl.Size = new Size(1042, 81);
            questionLbl.TabIndex = 2;
            questionLbl.Text = "....";
            // 
            // Achoice
            // 
            Achoice.AutoSize = true;
            Achoice.Location = new Point(11, 113);
            Achoice.Name = "Achoice";
            Achoice.Size = new Size(117, 24);
            Achoice.TabIndex = 3;
            Achoice.TabStop = true;
            Achoice.Text = "radioButton1";
            Achoice.UseVisualStyleBackColor = true;
            Achoice.Click += Achoice_Click;
            // 
            // Bchoice
            // 
            Bchoice.AutoSize = true;
            Bchoice.Location = new Point(11, 163);
            Bchoice.Name = "Bchoice";
            Bchoice.Size = new Size(117, 24);
            Bchoice.TabIndex = 4;
            Bchoice.TabStop = true;
            Bchoice.Text = "radioButton2";
            Bchoice.UseVisualStyleBackColor = true;
            Bchoice.Click += Bchoice_Click;
            // 
            // Cchoice
            // 
            Cchoice.AutoSize = true;
            Cchoice.Location = new Point(11, 204);
            Cchoice.Name = "Cchoice";
            Cchoice.Size = new Size(117, 24);
            Cchoice.TabIndex = 5;
            Cchoice.TabStop = true;
            Cchoice.Text = "radioButton3";
            Cchoice.UseVisualStyleBackColor = true;
            Cchoice.Click += Cchoice_Click;
            // 
            // Dchoice
            // 
            Dchoice.AutoSize = true;
            Dchoice.Location = new Point(11, 251);
            Dchoice.Name = "Dchoice";
            Dchoice.Size = new Size(117, 24);
            Dchoice.TabIndex = 6;
            Dchoice.TabStop = true;
            Dchoice.Text = "radioButton4";
            Dchoice.UseVisualStyleBackColor = true;
            Dchoice.Click += Dchoice_Click;
            // 
            // submitbtn
            // 
            submitbtn.Location = new Point(769, 353);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(273, 29);
            submitbtn.TabIndex = 7;
            submitbtn.Text = "Submit";
            submitbtn.UseVisualStyleBackColor = true;
            // 
            // NewExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 451);
            Controls.Add(submitbtn);
            Controls.Add(Dchoice);
            Controls.Add(Cchoice);
            Controls.Add(Bchoice);
            Controls.Add(Achoice);
            Controls.Add(questionLbl);
            Controls.Add(prevBtn);
            Controls.Add(nxtBtn);
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