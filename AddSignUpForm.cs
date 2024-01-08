using System.Data.SqlClient;

namespace CR_RBD_Ulchenko
{
    public partial class AddSignUpForm : Form
    {
        SqlConnection sc;
        public AddSignUpForm(SqlConnection sqlConnection)
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
                if (CheckDate != null)
                {
                    MessageBox.Show("Время занято");
                    return;
                }

                sqlExpression = $"exec AddSignUpForDriving @Date = '{textBox1.Text}', @InstructorID = 1, @ClassesID = '{ClassesId}', @CadetID = 39";
                sqlCommand = new SqlCommand(sqlExpression, sc);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Запись создана");
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Введены неверные данные");
            }
        }
    }
}
