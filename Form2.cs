using WinFormsAppEos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Timers.Timer;



namespace WinFormsAppEos
{
    public partial class Form2 : Form
    {
        private double StudentMark = 0;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string examcode, string username)
        {
            InitializeComponent();
            txtStudent.Text = username;
            txtExamCode.Text = examcode;

        }



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            btnExit.Enabled = checkBox2.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnExit1.Enabled = checkBox1.Checked;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        public Exam exam = new Exam();
        DataProvider dp = new DataProvider();
        int curPoint = 0;
        private void LoadData()
        {
            exam.ListQuestion = new List<Question>();
            using (AssPrn211Context context = new AssPrn211Context())
            {
                var data = (from e in context.Exams
                            where e.ExamCode.Equals(txtExamCode.Text)
                            select new
                            {
                                ExamCode = e.ExamCode,
                                Duration = e.Duration.ToString() + " Minutes",
                                Examsubject = e.ExamSubject,
                                TotalQues = e.TotalQues,
                            }).ToList();
                txtExamCode.DataBindings.Clear();
                txtExamCode.DataBindings.Add("Text", data, "ExamCode");
                txtTotalMark.DataBindings.Clear();
                txtTotalMark.DataBindings.Add("Text", data, "TotalQues");
                txtDuration.DataBindings.Clear();
                txtDuration.DataBindings.Add("Text", data, "Duration");
                int TotalQues = data.FirstOrDefault()?.TotalQues ?? 0;
                if (TotalQues != 0)
                {
                    txtQMark.Text = (10 / TotalQues).ToString();
                }
                else
                {
                    txtQMark.Text = "Invalid TotalQues";
                }

            }
            SetTimer(int.Parse(txtDuration.Text.Split(' ')[0]), 0);
            StartTimer();
            txtTotalQuestion.Text = "There are " + txtTotalMark.Text + " questions, and your progress of answering is";

            string strSQL = "select top " + txtTotalMark.Text + " * from Question " +
                "where ExamCode = '" + txtExamCode.Text + "' " +
                "order by NEWID()";
            using (IDataReader dr = dp.executeQuery2(strSQL))
            {
                while (dr.Read())

                {
                    Question question = new Question()
                    {
                        QuestionId = dr.GetInt32(0),
                        ExamCode = dr.GetString(1),
                        QuestionDesc = dr.GetString(2),
                        AnswerDesc = dr.GetString(3),
                        Checked = true,
                        Correct = false,
                        InProgress = false,
                        CurrentPoint = curPoint
                    };
                    exam.ListQuestion.Add(question);
                }
            }
            foreach (Question question in exam.ListQuestion)
            {
                question.ListAnswer = new List<Answer>();
                strSQL = "select * from Answer " +
                    "where QuestionID = " + question.QuestionId + " and " +
                    "ExamCode = '" + question.ExamCode + "'";
                using (IDataReader dr2 = dp.executeQuery2(strSQL))
                {
                    while (dr2.Read())
                    {
                        Answer answer = new Answer()
                        {
                            QuestionId = dr2.GetInt32(0),
                            ExamCode = dr2.GetString(1),
                            Stt = dr2.GetInt32(2),
                            Answers = dr2.GetString(3),
                            Correct = dr2.GetBoolean(4),
                            Checked = false
                        };
                        question.ListAnswer.Add(answer);
                    }
                }
            }
            numSize.Value = (decimal)txtQuesDesc.Font.Size;
            PopulateFontFamilies();
            LoadCheckoutAnswer();
        }

        private void PopulateFontFamilies()
        {
            string currentFontFamily = txtQuesDesc.Font.FontFamily.Name;

            cboFont.Items.Clear();
            FontFamily[] fontFamilies = FontFamily.Families;

            foreach (FontFamily fontFamily in fontFamilies)
            {
                cboFont.Items.Add(fontFamily.Name);
            }
            cboFont.SelectedItem = currentFontFamily;
        }

        private int index = 0;

        private int numOfCorrectAnswer = 0;
        private int numOfCheckAnswer = 0;
        //private List<CheckBox> selectedCheckBoxes = new List<CheckBox>();
       
        private void LoadCheckoutAnswer()
        {
            numOfCheckAnswer = exam.ListQuestion[index].CurrentPoint;
            numOfCorrectAnswer = 0;
            panel.Controls.Clear();
            int count = 0;
            txtAnsDesc.Text = exam.ListQuestion[index].AnswerDesc;
            txtQuesDesc.Text = exam.ListQuestion[index].QuestionDesc + "\n";
            foreach (Answer answer in exam.ListQuestion[index].ListAnswer)
            {
                txtQuesDesc.Text += answer.Answers + "\n";
                if (answer.Correct == true)
                {
                    numOfCorrectAnswer++;
                }
                CheckBox checkbox = new CheckBox();
                checkbox.Name = "chk_" + count;
                checkbox.Top = count * 25;
                int panelWidth = panel.Width;
                int checkboxWidth = checkbox.Height;
                int left = (panelWidth - checkboxWidth) / 2;
                checkbox.Left = left;
                checkbox.Checked = answer.Checked;
                checkbox.CheckedChanged += Checkbox_CheckedChanged;
                panel.Controls.Add(checkbox);
                count++;
            }

            txtQuesDesc.Text = txtQuesDesc.Text.Replace("\n", Environment.NewLine);

        }

        private void Checkbox_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            int indexofAnswer = int.Parse(checkbox.Name.Split('_')[1]);
            exam.ListQuestion[index].ListAnswer[indexofAnswer].Checked = checkbox.Checked;
            if (exam.ListQuestion[index].ListAnswer[indexofAnswer].Correct == true && checkbox.Checked == true)
            {
                numOfCheckAnswer++;
            }
            else
            {
                if (exam.ListQuestion[index].ListAnswer[indexofAnswer].Correct == true && checkbox.Checked == false)
                {
                    numOfCheckAnswer--;
                }
            }
            if (exam.ListQuestion[index].ListAnswer[indexofAnswer].Correct == false && checkbox.Checked == true)
            {
                numOfCheckAnswer--;
            }
            else
            {
                if (exam.ListQuestion[index].ListAnswer[indexofAnswer].Correct == false && checkbox.Checked == false)
                {
                    numOfCheckAnswer++;
                }
            }
            exam.ListQuestion[index].Checked = false;
        }

        private System.Windows.Forms.Timer countdownTimer;
        private int remainingMinutes = 0;
        private int remainingSeconds = 0;

        private void SetTimer(int minutes, int seconds)
        {
            remainingMinutes = minutes;
            remainingSeconds = seconds;
        }

        private void StartTimer()
        {
            countdownTimer = new System.Windows.Forms.Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();
        }
        String questionDetail;
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
            }
            else
            {
                if (remainingMinutes > 0)
                {
                    remainingMinutes--;
                    remainingSeconds = 59;
                }
                else
                {

                    MessageBox.Show("Exam finished!");
                    if (exam.ListQuestion[index].Checked == false)
                    {
                        if (numOfCheckAnswer == numOfCorrectAnswer)
                        {
                            exam.ListQuestion[index].Correct = true;

                        }
                        else
                        {
                            exam.ListQuestion[index].Correct = false;
                        }
                        exam.ListQuestion[index].Checked = true;
                    }
                    curPoint = numOfCheckAnswer;
                    exam.ListQuestion[index].CurrentPoint = curPoint;
                    UpdateTimeLabel();
                    int totalcorrectquesiton = 0;


                    foreach (Question q in exam.ListQuestion)
                    {
                        if (q.Correct == true)
                        {
                            totalcorrectquesiton++;
                            correctQuestionsList.Add(q.Correct + " ");

                        }
                        else
                        {
                            correctQuestionsList.Add(q.Correct + " ");

                        }
                    }
                    String correctQuestionsListString = string.Join(Environment.NewLine, correctQuestionsList);

                    StudentMark = totalcorrectquesiton / double.Parse(txtTotalMark.Text) * 10;

                    Form3 eos = new Form3(txtExamCode.Text, txtStudent.Text, txtQMark.Text, txtTotalMark.Text, StudentMark, totalcorrectquesiton, correctQuestionsListString, txtTimer.Text, txtDuration.Text);
                    Form3 eosn = new Form3(txtExamCode.Text, txtStudent.Text, txtQMark.Text, txtTotalMark.Text, StudentMark, totalcorrectquesiton, correctQuestionsListString, txtTimer.Text, txtDuration.Text, exam); 
                    eosn.CorrectQuestionsListString = correctQuestionsListString;
                    eos.Show();
                    this.Hide();
                }


                UpdateTimeLabel();
            }
        }

        private void UpdateTimeLabel()
        {
            TimeSpan timeSpan = new TimeSpan(0, remainingMinutes, remainingSeconds);

            // Định dạng thời gian dưới dạng giờ:phút:giây
            string formattedTime = $"{timeSpan.Hours:D2}:{timeSpan.Minutes:D2}:{timeSpan.Seconds:D2}";

            // Hiển thị thời gian trong TextBox
            txtTimer.Text = formattedTime;
        }
        private int totalAnswered = 0;

        private void UpdateProgressBar(int answeredQuestions, int totalQuestions)
        {
            int progressPercentage = (int)((double)answeredQuestions / totalQuestions * 100);
            progressBar.Value = progressPercentage;
        }

        private void numSize_ValueChanged(object sender, EventArgs e)
        {
            float fontSize = (float)numSize.Value;
            Font currentFont = txtQuesDesc.Font;
            Font newFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style);
            txtQuesDesc.Font = newFont;
        }

        private void cboFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFontFamily = cboFont.SelectedItem.ToString();

            FontFamily fontFamily = new FontFamily(selectedFontFamily);
            Font newFont = new Font(fontFamily, txtQuesDesc.Font.Size, txtQuesDesc.Font.Style);

            txtQuesDesc.Font = newFont;
        }


        private void btnBack_Click_1(object sender, EventArgs e)
        {
            if (exam.ListQuestion[index].Checked == false)
            {
                if (totalAnswered < 0)
                {
                    totalAnswered = 0;
                }
                if (numOfCheckAnswer == numOfCorrectAnswer)
                {

                    exam.ListQuestion[index].Correct = true;
                }
                else
                {
                    exam.ListQuestion[index].Correct = false;
                }


                int totalCheckedAnswer = 0;
                foreach (Answer answer in exam.ListQuestion[index].ListAnswer)
                {
                    if (answer.Checked == true)
                    {
                        totalCheckedAnswer++;
                    }
                }
                if (totalCheckedAnswer != 0)
                {
                    exam.ListQuestion[index].InProgress = true;
                }
                else
                {
                    exam.ListQuestion[index].InProgress = false;
                }
                exam.ListQuestion[index].Checked = true;
            }
            curPoint = numOfCheckAnswer;
            exam.ListQuestion[index].CurrentPoint = curPoint;
            index--;
            if (index < 0)
            {
                index = Int32.Parse(txtTotalMark.Text) - 1;
            }
            LoadCheckoutAnswer();
            foreach (Question question in exam.ListQuestion)
            {
                if (question.InProgress == true)
                {
                    totalAnswered++;
                }
            }
            UpdateProgressBar(totalAnswered, int.Parse(txtTotalMark.Text));
            totalAnswered = 0;
        }
        private void btnNext_Click_1(object sender, EventArgs e)
        {


            if (exam.ListQuestion[index].Checked == false)
            {
                if (totalAnswered < 0)
                {
                    totalAnswered = 0;
                }
                if (numOfCheckAnswer == numOfCorrectAnswer)
                {

                    exam.ListQuestion[index].Correct = true;
                }
                else
                {
                    exam.ListQuestion[index].Correct = false;
                }
                int totalCheckedAnswer = 0;
                foreach (Answer answer in exam.ListQuestion[index].ListAnswer)
                {
                    if (answer.Checked == true)
                    {
                        totalCheckedAnswer++;
                    }
                }
                if (totalCheckedAnswer != 0)
                {
                    exam.ListQuestion[index].InProgress = true;
                }
                else
                {
                    exam.ListQuestion[index].InProgress = false;
                }
                exam.ListQuestion[index].Checked = true;
            }
            curPoint = numOfCheckAnswer;
            exam.ListQuestion[index].CurrentPoint = curPoint;

            index++;

            if (index == Int32.Parse(txtTotalMark.Text))
            {
                index = 0;
            }
            LoadCheckoutAnswer();
            foreach (Question question in exam.ListQuestion)
            {
                if (question.InProgress == true)
                {
                    totalAnswered++;
                }
            }
            UpdateProgressBar(totalAnswered, int.Parse(txtTotalMark.Text));
            totalAnswered = 0;
        }

        private void cboFont_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedFontFamily = cboFont.SelectedItem.ToString();

            FontFamily fontFamily = new FontFamily(selectedFontFamily);
            Font newFont = new Font(fontFamily, txtQuesDesc.Font.Size, txtQuesDesc.Font.Style);

            txtQuesDesc.Font = newFont;
        }
        List<string> correctQuestionsList = new List<string>();
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (exam.ListQuestion[index].Checked == false)
            {
                if (numOfCheckAnswer == numOfCorrectAnswer)
                {

                    exam.ListQuestion[index].Correct = true;
                }
                else
                {
                    exam.ListQuestion[index].Correct = false;
                }
                exam.ListQuestion[index].Checked = true;
            }
            curPoint = numOfCheckAnswer;
            exam.ListQuestion[index].CurrentPoint = curPoint;
            countdownTimer.Stop();
            UpdateTimeLabel();
            exam.ListQuestion[index].Checked = true;
            int totalcorrectquesiton = 0;
            foreach (Question q in exam.ListQuestion)
            {
                if (q.Correct == true)
                {
                    totalcorrectquesiton++;
                    correctQuestionsList.Add(q.Correct + " ");

                }
                else
                {
                    correctQuestionsList.Add(q.Correct + " ");

                }
            }
            String correctQuestionsListString = string.Join(Environment.NewLine, correctQuestionsList);

            StudentMark = totalcorrectquesiton / double.Parse(txtTotalMark.Text) * 10;

            Form3 eos = new Form3(txtExamCode.Text, txtStudent.Text, txtQMark.Text, txtTotalMark.Text, StudentMark, totalcorrectquesiton, correctQuestionsListString, txtTimer.Text, txtDuration.Text);
            Form3 eosn = new Form3(txtExamCode.Text, txtStudent.Text, txtQMark.Text, txtTotalMark.Text, StudentMark, totalcorrectquesiton, correctQuestionsListString, txtTimer.Text, txtDuration.Text, exam);
            eosn.CorrectQuestionsListString = correctQuestionsListString;
            eos.Show();
            this.Hide();


        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        private void txtTotalQuestion_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            btnExit.Enabled = checkBox2.Checked;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            btnExit1.Enabled = checkBox1.Checked;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (exam.ListQuestion[index].Checked == false)
            {
                if (totalAnswered < 0)
                {
                    totalAnswered = 0;
                }
                if (numOfCheckAnswer == numOfCorrectAnswer)
                {

                    exam.ListQuestion[index].Correct = true;
                }
                else
                {
                    exam.ListQuestion[index].Correct = false;
                }
                int totalCheckedAnswer = 0;
                foreach (Answer answer in exam.ListQuestion[index].ListAnswer)
                {
                    if (answer.Checked == true)
                    {
                        totalCheckedAnswer++;
                    }
                }
                if (totalCheckedAnswer != 0)
                {
                    exam.ListQuestion[index].InProgress = true;
                }
                else
                {
                    exam.ListQuestion[index].InProgress = false;
                }
                exam.ListQuestion[index].Checked = true;
            }
            curPoint = numOfCheckAnswer;
            exam.ListQuestion[index].CurrentPoint = curPoint;

            index++;

            if (index == Int32.Parse(txtTotalMark.Text))
            {
                index = 0;
            }
            LoadCheckoutAnswer();
            foreach (Question question in exam.ListQuestion)
            {
                if (question.InProgress == true)
                {
                    totalAnswered++;
                }
            }
            UpdateProgressBar(totalAnswered, int.Parse(txtTotalMark.Text));
            totalAnswered = 0;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát khỏi bài kiểm tra?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Nếu người dùng không muốn thoát, hủy việc đóng Form
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            if (exam.ListQuestion[index].Checked == false)
            {
                if (numOfCheckAnswer == numOfCorrectAnswer)
                {

                    exam.ListQuestion[index].Correct = true;
                }
                else
                {
                    exam.ListQuestion[index].Correct = false;
                }
                exam.ListQuestion[index].Checked = true;
            }
            curPoint = numOfCheckAnswer;
            exam.ListQuestion[index].CurrentPoint = curPoint;
            countdownTimer.Stop();
            UpdateTimeLabel();

            int totalcorrectquesiton = 0;
            foreach (Question q in exam.ListQuestion)
                    {
                        if (q.Correct == true)
                        {
                            totalcorrectquesiton++;
                            correctQuestionsList.Add(q.Correct + " ");

                        }
                        else
                        {
                            correctQuestionsList.Add(q.Correct + " ");

                        }
                    }
            String correctQuestionsListString = string.Join(Environment.NewLine, correctQuestionsList);

            StudentMark = totalcorrectquesiton / double.Parse(txtTotalMark.Text) * 10;

            //Form3 eos = new Form3(txtExamCode.Text, txtStudent.Text, txtQMark.Text, txtTotalMark.Text, StudentMark, totalcorrectquesiton, correctQuestionsListString, txtTimer.Text, txtDuration.Text);
            Form3 eosn = new Form3(txtExamCode.Text, txtStudent.Text, txtQMark.Text, txtTotalMark.Text, StudentMark, totalcorrectquesiton, correctQuestionsListString, txtTimer.Text, txtDuration.Text, exam);
            eosn.CorrectQuestionsListString = correctQuestionsListString;
            eosn.Show();
            this.Hide();

        }

        private void numSize_ValueChanged_1(object sender, EventArgs e)
        {
            float fontSize = (float)numSize.Value;
            Font currentFont = txtQuesDesc.Font;
            Font newFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style);
            txtQuesDesc.Font = newFont;
        }

        private void txtTotalMark_Click(object sender, EventArgs e)
        {

        }

        private void txtQMark_Click(object sender, EventArgs e)
        {

        }

        private void txtQuesDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

