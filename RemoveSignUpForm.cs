using System.Data.SqlClient;

namespace CR_RBD_Ulchenko
{
    public partial class RemoveSignUpForm : Form
    {
        SqlConnection sc;
        public RemoveSignUpForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            sc = sqlConnection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sqlExpression = $"select ID from Classes where format(cast(Classes.ClassTime as datetime2),'HH:mm') = '{comboBox1.Text}'";
                var sqlCommand = new SqlCommand(sqlExpression, sc);
                var ClassesId = sqlCommand.ExecuteScalar();

                sqlExpression = $"select ID from Schedule where  format(Schedule.Date,'yyyy-MM-dd') = '{textBox1.Text}' and ClassesID='{ClassesId}'";
                sqlCommand = new SqlCommand(sqlExpression, sc);
                var CheckDate = sqlCommand.ExecuteScalar();
                if (CheckDate == null)
                {
                    MessageBox.Show("Такой записи не существует");
                    return;
                }

                sqlExpression = $"delete from SignUpForDriving where ScheduleID='{CheckDate}'";
                sqlCommand = new SqlCommand(sqlExpression, sc);
                sqlCommand.ExecuteNonQuery();

                sqlExpression = $"delete from Schedule where ID='{CheckDate}'";
                sqlCommand = new SqlCommand(sqlExpression, sc);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись удалена");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }
    }
}
