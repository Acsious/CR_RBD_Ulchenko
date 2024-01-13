using System.Data.SqlClient;

namespace CR_RBD_Ulchenko
{
    public partial class ChangeUserInfoForm : Form
    {
        SqlConnection sc;
        public ChangeUserInfoForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            sc = sqlConnection;
        }

        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "" || PasswordTextBox.Text == "" || SecondNameTextBox.Text == "" || FirstNameTextBox.Text == "")
            {
                MessageBox.Show("Неверно введены данные");
                return;
            }
            var sqlExpression = $"update [User] set Login = '{LoginTextBox.Text}'," +
                $"Password = '{PasswordTextBox.Text}'," +
                $"SecondName = '{SecondNameTextBox.Text}'," +
                $"FirstName = '{FirstNameTextBox.Text}'," +
                $"MiddleName = '{MiddleNameTextBox.Text}' where id=39";
            var sqlCommand = new SqlCommand(sqlExpression, sc);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Данные изменены");
        }
    }
}
