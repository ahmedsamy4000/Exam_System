namespace Exam_system_App
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            label1 = new Label();
            choosecombobox = new ComboBox();
            idtxtbox = new TextBox();
            label2 = new Label();
            passwordtxtbox = new TextBox();
            label3 = new Label();
            SignInbtn = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 72);
            label1.Name = "label1";
            label1.Size = new Size(191, 46);
            label1.TabIndex = 0;
            label1.Text = "Sign In as :";
            // 
            // choosecombobox
            // 
            choosecombobox.FormattingEnabled = true;
            choosecombobox.Items.AddRange(new object[] { "Instructor", "Student" });
            choosecombobox.Location = new Point(270, 89);
            choosecombobox.Name = "choosecombobox";
            choosecombobox.Size = new Size(300, 28);
            choosecombobox.TabIndex = 1;
            choosecombobox.Text = "Select Your Identity :";
            // 
            // idtxtbox
            // 
            idtxtbox.Location = new Point(270, 184);
            idtxtbox.Name = "idtxtbox";
            idtxtbox.Size = new Size(300, 27);
            idtxtbox.TabIndex = 2;
            idtxtbox.TextChanged += idtxtbox_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(270, 141);
            label2.Name = "label2";
            label2.Size = new Size(76, 40);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // passwordtxtbox
            // 
            passwordtxtbox.Location = new Point(270, 283);
            passwordtxtbox.Name = "passwordtxtbox";
            passwordtxtbox.PasswordChar = '*';
            passwordtxtbox.Size = new Size(300, 27);
            passwordtxtbox.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(270, 240);
            label3.Name = "label3";
            label3.Size = new Size(141, 40);
            label3.TabIndex = 5;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // SignInbtn
            // 
            SignInbtn.BackColor = Color.Black;
            SignInbtn.FlatStyle = FlatStyle.Flat;
            SignInbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            SignInbtn.ForeColor = SystemColors.ButtonFace;
            SignInbtn.Location = new Point(305, 353);
            SignInbtn.Name = "SignInbtn";
            SignInbtn.Size = new Size(219, 57);
            SignInbtn.TabIndex = 6;
            SignInbtn.Text = "Sign In";
            SignInbtn.UseVisualStyleBackColor = false;
            SignInbtn.Click += SignInbtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(709, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 139);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(832, 450);
            Controls.Add(pictureBox1);
            Controls.Add(SignInbtn);
            Controls.Add(label3);
            Controls.Add(passwordtxtbox);
            Controls.Add(label2);
            Controls.Add(idtxtbox);
            Controls.Add(choosecombobox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "SignInForm";
            Text = "Sign InForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox choosecombobox;
        private TextBox idtxtbox;
        private Label label2;
        private TextBox passwordtxtbox;
        private Label label3;
        private Button SignInbtn;
        private PictureBox pictureBox1;
    }
}