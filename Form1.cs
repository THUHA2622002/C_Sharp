using Microsoft.Data.SqlClient;
using WinFormsAppEos.Models;
using System.Data;
using System.Runtime.Intrinsics.Arm;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppEos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataProvider dp = new DataProvider();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    string ifwrong = "";
                    String strSQL = "select * from Student " +
                        "where Username =@acc " +
                        "and Password =@pass";
                    SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@acc",txtUsername.Text),
                    new SqlParameter("@pass",txtPassword.Text),
                    };

                    int count = 0;
                    using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
                    {
                        if (dr.Read())
                        {
                            count++;
                        }
                        else
                        {
                            ifwrong = "Username or password wrong!";
                        }

                    }

                    strSQL = "select * from Exam where ExamCode COLLATE Latin1_General_CS_AS = @exa";
                    parameters = new SqlParameter[] {
                        new SqlParameter("@exa", txtExamCode.Text)
                    };
                    using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
                    {
                        if (dr.Read())
                        {
                            count++;
                        }
                        else
                        {
                            ifwrong = "Invalidated ExamCode!";
                        }
                    }
                    if (count == 2)
                    {
                        String name = GetNameByAccount(txtUsername.Text);
                        String examcode = GetExamCode(txtExamCode.Text);

                        //MessageBox.Show("Login");
                        Form2 f = new Form2(txtExamCode.Text, txtUsername.Text);
                        f.ShowDialog();
                        this.Hide();

                    }
                    else
                    {
                        label6.Text = ifwrong;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login false: " + ex.Message);
                }
            }

        }

        private string GetExamCode(string text)
        {
            String strSQL = "select* from Exam " +
                        "where ExamCode=@Exam ";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@Exam",txtExamCode.Text)
                };
            using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
            {
                if (dr.Read())
                {
                    return dr.GetString(0);
                }
            }
            return "";
        }

        private string GetNameByAccount(string text)
        {
            String strSQL = "select* from Student " +
                        "where Username=@acc ";
            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@acc",txtUsername.Text)
                };
            using (IDataReader dr = dp.executeQuery2(strSQL, parameters))
            {
                if (dr.Read())
                {
                    return dr.GetString(0);
                }
            }
            return "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = "FU.EDU.VN";
            textBox3.Enabled = false;
            textBox3.BackColor = this.BackColor;
            textBox3.BorderStyle = BorderStyle.None;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Alert", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();// day chi la mot lenh thoat
            }
        }
    }
}
