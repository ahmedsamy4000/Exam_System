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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            Achoice = new RadioButton();
            Bchoice = new RadioButton();
            Cchoice = new RadioButton();
            Dchoice = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(573, 353);
            button1.Name = "button1";
            button1.Size = new Size(273, 29);
            button1.TabIndex = 0;
            button1.Text = "Next";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(163, 353);
            button2.Name = "button2";
            button2.Size = new Size(273, 29);
            button2.TabIndex = 1;
            button2.Text = "Previous";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1042, 81);
            label1.TabIndex = 2;
            label1.Text = "....";
            // 
            // Achoice
            // 
            Achoice.AutoSize = true;
            Achoice.Location = new Point(12, 113);
            Achoice.Name = "Achoice";
            Achoice.Size = new Size(117, 24);
            Achoice.TabIndex = 3;
            Achoice.TabStop = true;
            Achoice.Text = "radioButton1";
            Achoice.UseVisualStyleBackColor = true;
            // 
            // Bchoice
            // 
            Bchoice.AutoSize = true;
            Bchoice.Location = new Point(12, 162);
            Bchoice.Name = "Bchoice";
            Bchoice.Size = new Size(117, 24);
            Bchoice.TabIndex = 4;
            Bchoice.TabStop = true;
            Bchoice.Text = "radioButton2";
            Bchoice.UseVisualStyleBackColor = true;
            // 
            // Cchoice
            // 
            Cchoice.AutoSize = true;
            Cchoice.Location = new Point(12, 204);
            Cchoice.Name = "Cchoice";
            Cchoice.Size = new Size(117, 24);
            Cchoice.TabIndex = 5;
            Cchoice.TabStop = true;
            Cchoice.Text = "radioButton3";
            Cchoice.UseVisualStyleBackColor = true;
            // 
            // Dchoice
            // 
            Dchoice.AutoSize = true;
            Dchoice.Location = new Point(12, 251);
            Dchoice.Name = "Dchoice";
            Dchoice.Size = new Size(117, 24);
            Dchoice.TabIndex = 6;
            Dchoice.TabStop = true;
            Dchoice.Text = "radioButton4";
            Dchoice.UseVisualStyleBackColor = true;
            // 
            // NewExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 450);
            Controls.Add(Dchoice);
            Controls.Add(Cchoice);
            Controls.Add(Bchoice);
            Controls.Add(Achoice);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "NewExamForm";
            Text = "NewExamForm";
            Load += NewExamForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private RadioButton Achoice;
        private RadioButton Bchoice;
        private RadioButton Cchoice;
        private RadioButton Dchoice;
    }
}