namespace WinFormsAppEos
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label9 = new Label();
            cboFont = new ComboBox();
            label8 = new Label();
            numSize = new NumericUpDown();
            label5 = new Label();
            checkBox2 = new CheckBox();
            btnExit = new Button();
            txtTotalQuestion = new Label();
            progressBar = new ProgressBar();
            txtExamCode = new Label();
            txtDuration = new Label();
            txtQMark = new Label();
            txtTotalMark = new Label();
            label7 = new Label();
            panel = new Panel();
            btnBack = new Button();
            btnNext = new Button();
            txtAnsDesc = new TextBox();
            txtQuesDesc = new TextBox();
            checkBox1 = new CheckBox();
            btnExit1 = new Button();
            txtTimer = new Label();
            txtStudent = new Label();
            ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(55, 26);
            label1.Name = "label1";
            label1.Size = new Size(113, 28);
            label1.TabIndex = 5;
            label1.Text = "Exam Code:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, 72);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 6;
            label2.Text = "Duration:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(270, 26);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 7;
            label3.Text = "Q Mark:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(235, 72);
            label4.Name = "label4";
            label4.Size = new Size(116, 28);
            label4.TabIndex = 8;
            label4.Text = "Total Marks:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(524, 40);
            label6.Name = "label6";
            label6.Size = new Size(84, 28);
            label6.TabIndex = 10;
            label6.Text = "Student:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(190, 112);
            label9.Name = "label9";
            label9.Size = new Size(56, 28);
            label9.TabIndex = 29;
            label9.Text = "Font:";
            // 
            // cboFont
            // 
            cboFont.FormattingEnabled = true;
            cboFont.Location = new Point(270, 116);
            cboFont.Margin = new Padding(3, 4, 3, 4);
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(135, 28);
            cboFont.TabIndex = 30;
            cboFont.SelectedIndexChanged += cboFont_SelectedIndexChanged_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(423, 116);
            label8.Name = "label8";
            label8.Size = new Size(51, 28);
            label8.TabIndex = 31;
            label8.Text = "Size:";
            // 
            // numSize
            // 
            numSize.Location = new Point(480, 117);
            numSize.Margin = new Padding(3, 4, 3, 4);
            numSize.Name = "numSize";
            numSize.Size = new Size(70, 27);
            numSize.TabIndex = 32;
            numSize.ValueChanged += numSize_ValueChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(793, 72);
            label5.Name = "label5";
            label5.Size = new Size(90, 28);
            label5.TabIndex = 33;
            label5.Text = "TimeLeft:";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(486, 13);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(193, 24);
            checkBox2.TabIndex = 34;
            checkBox2.Text = "I want to finish the exam";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged_1;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 255, 192);
            btnExit.Enabled = false;
            btnExit.Location = new Point(685, 6);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(86, 31);
            btnExit.TabIndex = 35;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // txtTotalQuestion
            // 
            txtTotalQuestion.AutoSize = true;
            txtTotalQuestion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalQuestion.ForeColor = Color.FromArgb(0, 0, 192);
            txtTotalQuestion.Location = new Point(30, 152);
            txtTotalQuestion.Name = "txtTotalQuestion";
            txtTotalQuestion.Size = new Size(532, 28);
            txtTotalQuestion.TabIndex = 36;
            txtTotalQuestion.Text = "There are    questions, and your progress of answering is";
            txtTotalQuestion.Click += txtTotalQuestion_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(574, 144);
            progressBar.Margin = new Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(577, 39);
            progressBar.TabIndex = 37;
            progressBar.Click += progressBar_Click;
            // 
            // txtExamCode
            // 
            txtExamCode.AutoSize = true;
            txtExamCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtExamCode.ForeColor = Color.Red;
            txtExamCode.Location = new Point(174, 26);
            txtExamCode.Name = "txtExamCode";
            txtExamCode.Size = new Size(49, 28);
            txtExamCode.TabIndex = 38;
            txtExamCode.Text = "Text";
            // 
            // txtDuration
            // 
            txtDuration.AutoSize = true;
            txtDuration.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtDuration.ForeColor = Color.FromArgb(0, 0, 192);
            txtDuration.Location = new Point(174, 72);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(49, 28);
            txtDuration.TabIndex = 39;
            txtDuration.Text = "Text";
            // 
            // txtQMark
            // 
            txtQMark.AutoSize = true;
            txtQMark.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtQMark.ForeColor = Color.FromArgb(0, 0, 192);
            txtQMark.Location = new Point(368, 26);
            txtQMark.Name = "txtQMark";
            txtQMark.Size = new Size(49, 28);
            txtQMark.TabIndex = 40;
            txtQMark.Text = "Text";
            txtQMark.Click += txtQMark_Click;
            // 
            // txtTotalMark
            // 
            txtTotalMark.AutoSize = true;
            txtTotalMark.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalMark.ForeColor = Color.FromArgb(0, 0, 192);
            txtTotalMark.Location = new Point(368, 72);
            txtTotalMark.Name = "txtTotalMark";
            txtTotalMark.Size = new Size(49, 28);
            txtTotalMark.TabIndex = 41;
            txtTotalMark.Text = "Text";
            txtTotalMark.Click += txtTotalMark_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(0, 0, 192);
            label7.Location = new Point(36, 180);
            label7.Name = "label7";
            label7.Size = new Size(79, 28);
            label7.TabIndex = 42;
            label7.Text = "Answer";
            // 
            // panel
            // 
            panel.Location = new Point(23, 212);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.Name = "panel";
            panel.Size = new Size(111, 220);
            panel.TabIndex = 43;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 450);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(63, 31);
            btnBack.TabIndex = 44;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click_1;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(87, 450);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(63, 31);
            btnNext.TabIndex = 45;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtAnsDesc
            // 
            txtAnsDesc.BackColor = Color.White;
            txtAnsDesc.Location = new Point(286, 191);
            txtAnsDesc.Margin = new Padding(3, 4, 3, 4);
            txtAnsDesc.Multiline = true;
            txtAnsDesc.Name = "txtAnsDesc";
            txtAnsDesc.ReadOnly = true;
            txtAnsDesc.Size = new Size(725, 33);
            txtAnsDesc.TabIndex = 46;
            // 
            // txtQuesDesc
            // 
            txtQuesDesc.BackColor = Color.White;
            txtQuesDesc.Location = new Point(286, 229);
            txtQuesDesc.Margin = new Padding(3, 4, 3, 4);
            txtQuesDesc.Multiline = true;
            txtQuesDesc.Name = "txtQuesDesc";
            txtQuesDesc.ReadOnly = true;
            txtQuesDesc.Size = new Size(725, 252);
            txtQuesDesc.TabIndex = 47;
            txtQuesDesc.TextChanged += txtQuesDesc_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(30, 507);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(193, 24);
            checkBox1.TabIndex = 48;
            checkBox1.Text = "I want to finish the exam";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged_1;
            // 
            // btnExit1
            // 
            btnExit1.BackColor = Color.FromArgb(255, 255, 192);
            btnExit1.Enabled = false;
            btnExit1.Location = new Point(224, 503);
            btnExit1.Margin = new Padding(3, 4, 3, 4);
            btnExit1.Name = "btnExit1";
            btnExit1.Size = new Size(86, 31);
            btnExit1.TabIndex = 49;
            btnExit1.Text = "Exit";
            btnExit1.UseVisualStyleBackColor = false;
            btnExit1.Click += btnExit1_Click;
            // 
            // txtTimer
            // 
            txtTimer.AutoSize = true;
            txtTimer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTimer.ForeColor = Color.FromArgb(0, 0, 192);
            txtTimer.Location = new Point(916, 72);
            txtTimer.Name = "txtTimer";
            txtTimer.Size = new Size(49, 28);
            txtTimer.TabIndex = 50;
            txtTimer.Text = "Text";
            // 
            // txtStudent
            // 
            txtStudent.AutoSize = true;
            txtStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudent.ForeColor = Color.FromArgb(0, 0, 192);
            txtStudent.Location = new Point(630, 41);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(49, 28);
            txtStudent.TabIndex = 51;
            txtStudent.Text = "Text";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 544);
            Controls.Add(txtStudent);
            Controls.Add(txtTimer);
            Controls.Add(btnExit1);
            Controls.Add(checkBox1);
            Controls.Add(txtQuesDesc);
            Controls.Add(txtAnsDesc);
            Controls.Add(btnNext);
            Controls.Add(btnBack);
            Controls.Add(panel);
            Controls.Add(label7);
            Controls.Add(txtTotalMark);
            Controls.Add(txtQMark);
            Controls.Add(txtDuration);
            Controls.Add(txtExamCode);
            Controls.Add(progressBar);
            Controls.Add(txtTotalQuestion);
            Controls.Add(btnExit);
            Controls.Add(checkBox2);
            Controls.Add(label5);
            Controls.Add(numSize);
            Controls.Add(label8);
            Controls.Add(cboFont);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label9;
        private ComboBox cboFont;
        private Label label8;
        private NumericUpDown numSize;
        private Label label5;
        private CheckBox checkBox2;
        private Button btnExit;
        private Label txtTotalQuestion;
        private ProgressBar progressBar;
        private Label txtExamCode;
        private Label txtDuration;
        private System.Windows.Forms.Timer Timer;
        private Label txtQMark;
        private Label txtTotalMark;
        private Label label7;
        private Panel panel;
        private Button btnBack;
        private Button btnNext;
        private TextBox txtAnsDesc;
        private TextBox txtQuesDesc;
        private CheckBox checkBox1;
        private Button btnExit1;
        private Label txtTimer;
        private Label txtStudent;
    }
}