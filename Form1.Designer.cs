namespace WinFormsAppEos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtExamCode = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            textBox3 = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(113, 23);
            label1.Name = "label1";
            label1.Size = new Size(535, 28);
            label1.TabIndex = 1;
            label1.Text = "You can't take the exam if EOS run under the virtual machine";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 78);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 2;
            label2.Text = "Exam Code:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(44, 131);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 4;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 193);
            label4.Name = "label4";
            label4.Size = new Size(95, 25);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(63, 253);
            label5.Name = "label5";
            label5.Size = new Size(82, 25);
            label5.TabIndex = 8;
            label5.Text = "Domain:";
            // 
            // txtExamCode
            // 
            txtExamCode.Location = new Point(188, 76);
            txtExamCode.Margin = new Padding(3, 4, 3, 4);
            txtExamCode.Name = "txtExamCode";
            txtExamCode.Size = new Size(338, 27);
            txtExamCode.TabIndex = 9;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(188, 132);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(338, 27);
            txtUsername.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 194);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(338, 27);
            txtPassword.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(188, 254);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(338, 27);
            textBox3.TabIndex = 12;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(113, 324);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 31);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(335, 324);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(34, 295);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(textBox3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtExamCode);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtExamCode;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox textBox3;
        private Button btnLogin;
        private Button btnExit;
        private Label label6;
    }
}