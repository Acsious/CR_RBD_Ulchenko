using System.Data.SqlClient;

namespace CR_RBD_Ulchenko
{
    public partial class SolveTicketsForm : Form
    {
        SqlConnection sc;
        public SolveTicketsForm(SqlConnection sqlConnection)
        {
            InitializeComponent();
            sc = sqlConnection;
        }

        private void Ticket1Button_Click(object sender, EventArgs e)
        {
            Ticket ticket = new(1, sc);
            ticket.ShowDialog();
        }

        private void Ticket2Button_Click(object sender, EventArgs e)
        {
            Ticket ticket = new(2, sc);
            ticket.ShowDialog();
        }

        private void Ticket3Button_Click(object sender, EventArgs e)
        {
            Ticket ticket = new(3, sc);
            ticket.ShowDialog();
        }

        private void Ticket4Button_Click(object sender, EventArgs e)
        {
            Ticket ticket = new(4, sc);
            ticket.ShowDialog();
        }
    }
}
