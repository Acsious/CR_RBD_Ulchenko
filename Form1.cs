namespace CR_RBD_Ulchenko
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new();

        public Form1()
        {
            InitializeComponent();
            dataBase.OpenConnection();
        }

        private void ChangeUserInfoButton_Click(object sender, EventArgs e)
        {
            ChangeUserInfoForm changeUserInfoForm = new(dataBase.GetConnection());
            changeUserInfoForm.ShowDialog();
        }

        private void SolveTickets_Click(object sender, EventArgs e)
        {
            SolveTicketsForm solveTicketsForm = new(dataBase.GetConnection());
            solveTicketsForm.ShowDialog();
        }

        private void MakeSignUpButton_Click(object sender, EventArgs e)
        {
            AddSignUpForm addSignUpForm = new(dataBase.GetConnection());
            addSignUpForm.ShowDialog();
        }
    }
}