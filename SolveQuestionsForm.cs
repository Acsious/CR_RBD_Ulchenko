using System.Data;
using System.Data.SqlClient;

namespace CR_RBD_Ulchenko
{
    public partial class SolveQuestionsForm : Form
    {
        SqlConnection sc;
        public SolveQuestionsForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            sc = sqlConnection;
            SqlDataAdapter adapter = new("select*from NumCorectAnswersOnQuestionsPerTheme", sc);
            DataSet ds = new();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Question question = new(Int32.Parse(comboBox1.Text), sc);
            question.ShowDialog();
            SqlDataAdapter adapter = new("select*from NumCorectAnswersOnQuestionsPerTheme", sc);
            DataSet ds = new();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
