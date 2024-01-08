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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Question question = new(Int32.Parse(comboBox1.Text), sc);
            question.ShowDialog();
        }
    }
}
