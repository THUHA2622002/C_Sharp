using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppEos.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppEos
{
    public partial class Form3 : Form
    {
        private List<CheckBox> selectedCheckBoxesList;
        public string CorrectQuestionsListString { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadData();




        }

        private void LoadData()
        {
            dgQuestion.DataSource = examnew.ListQuestion;
            dgQuestion.Columns["QuestionId"].Visible = false; // Ẩn cột QuestionId
            dgQuestion.Columns["ExamCode"].Visible = false; // Ẩn cột ExamCode
            dgQuestion.Columns["AnswerDesc"].Visible = false; // Ẩn cột AnswerDesc
            // Ẩn cột ListAnswer
            dgQuestion.Columns["Checked"].Visible = false; // Ẩn cột Checked
            dgQuestion.Columns["Correct"].Visible = false; // Ẩn cột Correct
            dgQuestion.Columns["CurrentPoint"].Visible = false; // Ẩn cột CurrentPoint
            dgQuestion.Columns["InProgress"].Visible = false; // Ẩn cột InProgress
            dgQuestion.Columns["ExamCodeNavigation"].Visible = false;
            dgQuestion.Columns["Answers"].Visible = false;

            // Đặt tiêu đề cho cột QuestionDesc
            dgQuestion.Columns["QuestionDesc"].HeaderText = "Question Description";

            // Đặt tự động thay đổi kích thước cột
            dgQuestion.Columns["QuestionDesc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }
        private void dgQuestion_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy câu hỏi hiện tại từ DataBoundItem của dòng
                Question question = (Question)dgQuestion.Rows[e.RowIndex].DataBoundItem;

                // Kiểm tra cột ListAnswer
                if (e.ColumnIndex == dgQuestion.Columns["ListAnswer"].Index)
                {
                    // Lấy danh sách câu trả lời từ câu hỏi hiện tại
                    List<Answer> listAnswer = question.ListAnswer;

                    // Kết hợp tất cả các câu trả lời thành một chuỗi, cách nhau bằng dấu phẩy
                    string answerDetails = string.Join(", ", listAnswer.Select(answer => answer.Answers));

                    // Gán giá trị vào ô cột ListAnswer
                    e.Value = answerDetails;
                }


            }
        }



        public Form3(string text1, string text2, string text4, string text5, double studentMark, double totalcorrectquesiton, string question, string text3, string text6)
        {
            InitializeComponent();
            txtExamCode.Text = text1;
            txtStudent.Text = text2;
            txtQMark.Text = text4;
            txtTotalMark.Text = text5;
            txtMark.Text = studentMark.ToString();
            txtSum.Text = totalcorrectquesiton.ToString();





        }
        public Exam examnew = new Exam();
        public Form3(string text1, string text2, string text4, string text5, double studentMark, double totalcorrectquesiton, string question, string text3, string text6, Exam exam)
        {
            InitializeComponent();
            txtExamCode.Text = text1;
            txtStudent.Text = text2;
            txtQMark.Text = text4;
            txtTotalMark.Text = text5;
            txtMark.Text = studentMark.ToString();
            txtSum.Text = totalcorrectquesiton.ToString();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Results", typeof(string));
            string[] questions = question.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            // Giới hạn chỉ hiển thị tối đa 6 dòng
            int maxRowCount = Math.Min(5, questions.Length);

            for (int i = 0; i < maxRowCount; i++)
            {
                dataTable.Rows.Add(questions[i]);
            }

            // Gán DataTable làm nguồn dữ liệu cho DataGridView
            dataGridView1.DataSource = dataTable;

            // Thiết lập WrapMode để các dòng trong cột "Results" được xuống dòng
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            if (dataGridView1.Rows.Count > maxRowCount)
            {
                DataGridViewRow lastRow = dataGridView1.Rows[dataGridView1.Rows.Count - 1];
                if (!lastRow.IsNewRow)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                }
            }
            examnew = exam;
        }
        private void SetLineSpacing(RichTextBox richTextBox, int lineHeightInPixels)
        {
            richTextBox.SelectionStart = 0;
            richTextBox.SelectionLength = richTextBox.Text.Length;

            richTextBox.SelectionFont = new Font(richTextBox.Font.FontFamily, richTextBox.Font.Size);

            richTextBox.SelectionCharOffset = lineHeightInPixels;

            // Bỏ chọn đoạn văn bản
            richTextBox.SelectionLength = 0;
        }



        private void txtTimer_Click(object sender, EventArgs e)
        {

        }

        private void txtMark_Click(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            List<Question> questions = new List<Question>();

        }

        private void txtDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAnswer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgQuestion_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            dgAnswer.DataSource = examnew.ListQuestion[e.RowIndex].ListAnswer;
            dgAnswer.Columns["QuestionId"].Visible = false;
            dgAnswer.Columns["ExamCode"].Visible = false;
            //dgAnswer.Columns["AnswerDesc"].Visible = false;
            dgAnswer.Columns["Checked"].Visible = false;
            dgAnswer.Columns["Question"].Visible = false;
            dgAnswer.Columns["Stt"].Visible = false;


            dgAnswer.Columns["ExamCodeNavigation"].Visible = false;
            // Đặt tiêu đề cho cột Correct
            dgAnswer.Columns["Correct"].HeaderText = "Correct";

        }

        private void dgQuestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
