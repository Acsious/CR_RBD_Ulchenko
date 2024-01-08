using System.Data.SqlClient;

namespace CR_RBD_Ulchenko
{
    public partial class Question : Form
    {
        SqlConnection sc;
        int qn;
        public Question(int questionNumber, SqlConnection sqlConnection)
        {
            InitializeComponent();
            sc = sqlConnection;
            qn = questionNumber;

            var sqlExpression = $"select*from Question where QuestionNumber='{qn}'";
            var sqlCommand = new SqlCommand(sqlExpression, sc);
            using var QuestionReader = sqlCommand.ExecuteReader();
            if (QuestionReader.HasRows)
            {
                while (QuestionReader.Read())
                {
                    try
                    {
                        label1.Text = QuestionReader.GetString(QuestionReader.GetOrdinal("Formulation"));
                        radioButton1.Text = QuestionReader.GetString(QuestionReader.GetOrdinal("CorrectAnswer"));
                        radioButton2.Text = QuestionReader.GetString(QuestionReader.GetOrdinal("FirstIncorrectAnswer"));
                        radioButton3.Text = QuestionReader.GetString(QuestionReader.GetOrdinal("SecondIncorrectAnswer"));
                        radioButton4.Text = QuestionReader.GetString(QuestionReader.GetOrdinal("ThirdIncorrectAnswer"));

                    }
                    catch
                    {
                        label1.Text = QuestionReader.GetString(QuestionReader.GetOrdinal("Formulation"));
                        radioButton1.Text = QuestionReader.GetString(QuestionReader.GetOrdinal("CorrectAnswer"));
                        radioButton2.Text = QuestionReader.GetString(QuestionReader.GetOrdinal("FirstIncorrectAnswer"));
                        radioButton3.Text = QuestionReader.GetString(QuestionReader.GetOrdinal("SecondIncorrectAnswer"));
                        radioButton4.Hide();
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sqlExpression = $"select ID from Question where QuestionNumber='{qn}'";
            var sqlCommand = new SqlCommand(sqlExpression, sc);
            var QuestionId = sqlCommand.ExecuteScalar();

            sqlExpression = $"select*from PerformanceOnQuestions where UserID=39 and QuestionID='{QuestionId}'";
            sqlCommand = new SqlCommand(sqlExpression, sc);
            var resul = sqlCommand.ExecuteNonQuery();
            if (resul != 0)
            {
                if (radioButton1.Checked)
                {
                    sqlExpression = $"update PerformanceOnQuestions set CorrectAnswer=1 where UserID=39 and QuestionID='{QuestionId}'";
                    sqlCommand = new SqlCommand(sqlExpression, sc);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    sqlExpression = $"update PerformanceOnQuestions set CorrectAnswer=0 where UserID=39 and QuestionID='{QuestionId}'";
                    sqlCommand = new SqlCommand(sqlExpression, sc);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            else
            {
                if (radioButton1.Checked)
                {
                    sqlExpression = $"insert PerformanceOnQuestions(CorrectAnswer,UserID,QuestionID)" +
                    $" values (1,39,'{QuestionId}')";
                    sqlCommand = new SqlCommand(sqlExpression, sc);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    sqlExpression = $"insert PerformanceOnQuestions(CorrectAnswer,UserID,QuestionID)" +
                    $" values (0,39,'{QuestionId}')";
                    sqlCommand = new SqlCommand(sqlExpression, sc);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            this.Hide();
        }
    }
}
