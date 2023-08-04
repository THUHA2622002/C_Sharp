namespace WinFormsAppEos
{
    partial class Form3
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
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            txtExamCode = new Label();
            txtStudent = new Label();
            txtQMark = new Label();
            label2 = new Label();
            txtTimer = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMark = new Label();
            txtTotalMark = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label7 = new Label();
            txtSum = new Label();
            dgQuestion = new DataGridView();
            dgAnswer = new DataGridView();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgQuestion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgAnswer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 47);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 3;
            label3.Text = "Exam Code:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(358, 48);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 4;
            label1.Text = "Student: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(623, 88);
            label4.Name = "label4";
            label4.Size = new Size(136, 28);
            label4.TabIndex = 5;
            label4.Text = "Your score is:";
            // 
            // txtExamCode
            // 
            txtExamCode.AutoSize = true;
            txtExamCode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtExamCode.ForeColor = Color.FromArgb(0, 0, 192);
            txtExamCode.Location = new Point(154, 40);
            txtExamCode.Name = "txtExamCode";
            txtExamCode.Size = new Size(49, 28);
            txtExamCode.TabIndex = 18;
            txtExamCode.Text = "Text";
            // 
            // txtStudent
            // 
            txtStudent.AutoSize = true;
            txtStudent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtStudent.ForeColor = Color.FromArgb(0, 0, 192);
            txtStudent.Location = new Point(421, 41);
            txtStudent.Name = "txtStudent";
            txtStudent.Size = new Size(49, 28);
            txtStudent.TabIndex = 19;
            txtStudent.Text = "Text";
            // 
            // txtQMark
            // 
            txtQMark.AutoSize = true;
            txtQMark.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtQMark.ForeColor = Color.FromArgb(0, 0, 192);
            txtQMark.Location = new Point(154, 88);
            txtQMark.Name = "txtQMark";
            txtQMark.Size = new Size(49, 28);
            txtQMark.TabIndex = 20;
            txtQMark.Text = "Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 281);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 21;
            // 
            // txtTimer
            // 
            txtTimer.AutoSize = true;
            txtTimer.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtTimer.ForeColor = Color.FromArgb(0, 0, 192);
            txtTimer.Location = new Point(277, 259);
            txtTimer.Name = "txtTimer";
            txtTimer.Size = new Size(0, 81);
            txtTimer.TabIndex = 22;
            txtTimer.Click += txtTimer_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(88, 96);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 23;
            label5.Text = "Q Mark:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 96);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 24;
            label6.Text = "Total Question:";
            // 
            // txtMark
            // 
            txtMark.AutoSize = true;
            txtMark.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtMark.ForeColor = Color.Red;
            txtMark.Location = new Point(774, 88);
            txtMark.Name = "txtMark";
            txtMark.Size = new Size(49, 28);
            txtMark.TabIndex = 25;
            txtMark.Text = "Text";
            txtMark.Click += txtMark_Click;
            // 
            // txtTotalMark
            // 
            txtTotalMark.AutoSize = true;
            txtTotalMark.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotalMark.ForeColor = Color.FromArgb(0, 0, 192);
            txtTotalMark.Location = new Point(442, 89);
            txtTotalMark.Name = "txtTotalMark";
            txtTotalMark.Size = new Size(49, 28);
            txtTotalMark.TabIndex = 26;
            txtTotalMark.Text = "Text";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(538, 40);
            label7.Name = "label7";
            label7.Size = new Size(221, 28);
            label7.TabIndex = 27;
            label7.Text = "Sum question Correct:";
            // 
            // txtSum
            // 
            txtSum.AutoSize = true;
            txtSum.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtSum.ForeColor = Color.FromArgb(0, 0, 192);
            txtSum.Location = new Point(774, 40);
            txtSum.Name = "txtSum";
            txtSum.Size = new Size(49, 28);
            txtSum.TabIndex = 28;
            txtSum.Text = "Text";
            // 
            // dgQuestion
            // 
            dgQuestion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgQuestion.Location = new Point(41, 182);
            dgQuestion.Name = "dgQuestion";
            dgQuestion.RowHeadersWidth = 51;
            dgQuestion.RowTemplate.Height = 29;
            dgQuestion.Size = new Size(429, 177);
            dgQuestion.TabIndex = 29;
            dgQuestion.CellClick += dgQuestion_CellClick;
            dgQuestion.CellContentClick += dgQuestion_CellContentClick;
            // 
            // dgAnswer
            // 
            dgAnswer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgAnswer.Location = new Point(502, 182);
            dgAnswer.Name = "dgAnswer";
            dgAnswer.RowHeadersWidth = 51;
            dgAnswer.RowTemplate.Height = 29;
            dgAnswer.Size = new Size(321, 177);
            dgAnswer.TabIndex = 30;
            dgAnswer.CellContentClick += dgAnswer_CellContentClick;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(409, 182);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(100, 193);
            dataGridView1.TabIndex = 31;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(976, 450);
            Controls.Add(dataGridView1);
            Controls.Add(dgAnswer);
            Controls.Add(dgQuestion);
            Controls.Add(txtSum);
            Controls.Add(label7);
            Controls.Add(txtTotalMark);
            Controls.Add(txtMark);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtTimer);
            Controls.Add(label2);
            Controls.Add(txtQMark);
            Controls.Add(txtStudent);
            Controls.Add(txtExamCode);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dgQuestion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgAnswer).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label4;
        private Label txtExamCode;
        private Label txtStudent;
        private Label txtQMark;
        private Label label2;
        private Label txtTimer;
        private Label label5;
        private Label label6;
        private Label txtMark;
        private Label txtTotalMark;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label7;
        private Label txtSum;
        private DataGridView dgQuestion;
        private DataGridView dgAnswer;
        private DataGridView dataGridView1;
    }
}