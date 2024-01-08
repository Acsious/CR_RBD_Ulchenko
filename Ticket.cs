using System.Data.SqlClient;

namespace CR_RBD_Ulchenko;

public partial class Ticket : Form
{
    SqlConnection sc;
    int tn;
    public Ticket(int TicketNumber, SqlConnection sqlConnection)
    {
        InitializeComponent();
        sc = sqlConnection;
        tn = TicketNumber;

        var sqlExpression = $"select*from Ticket where TicketNumber='{tn}'";
        var sqlCommand = new SqlCommand(sqlExpression, sc);
        var listich = new List<int>();
        using var ticketReader = sqlCommand.ExecuteReader();
        if (ticketReader.HasRows)
        {
            while (ticketReader.Read())
            {
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question1")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question2")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question3")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question4")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question5")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question6")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question7")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question8")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question9")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question10")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question11")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question12")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question13")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question14")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question15")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question16")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question17")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question18")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question19")));
                listich.Add(ticketReader.GetInt32(ticketReader.GetOrdinal($"Question20")));
            }
        }
        ticketReader.Close();

        #region questions

        #region Question 1
        var sqlExp = $"select*from Question where ID='{listich[0]}'";
        var sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader1 = sqlCom.ExecuteReader();
        if (questionReader1.HasRows)
        {
            while (questionReader1.Read())
            {
                try
                {
                    label1.Text = questionReader1.GetString(questionReader1.GetOrdinal("Formulation"));
                    radioButton1.Text = questionReader1.GetString(questionReader1.GetOrdinal("CorrectAnswer"));
                    radioButton2.Text = questionReader1.GetString(questionReader1.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton3.Text = questionReader1.GetString(questionReader1.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton4.Text = questionReader1.GetString(questionReader1.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label1.Text = questionReader1.GetString(questionReader1.GetOrdinal("Formulation"));
                    radioButton1.Text = questionReader1.GetString(questionReader1.GetOrdinal("CorrectAnswer"));
                    radioButton2.Text = questionReader1.GetString(questionReader1.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton3.Text = questionReader1.GetString(questionReader1.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton4.Hide();
                }
            }
        }
        questionReader1.Close();
        #endregion

        #region question 2
        sqlExp = $"select*from Question where ID='{listich[1]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader2 = sqlCom.ExecuteReader();
        if (questionReader2.HasRows)
        {
            while (questionReader2.Read())
            {
                try
                {
                    label2.Text = questionReader2.GetString(questionReader2.GetOrdinal("Formulation"));
                    radioButton8.Text = questionReader2.GetString(questionReader2.GetOrdinal("CorrectAnswer"));
                    radioButton7.Text = questionReader2.GetString(questionReader2.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton6.Text = questionReader2.GetString(questionReader2.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton5.Text = questionReader2.GetString(questionReader2.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label2.Text = questionReader2.GetString(questionReader2.GetOrdinal("Formulation"));
                    radioButton8.Text = questionReader2.GetString(questionReader2.GetOrdinal("CorrectAnswer"));
                    radioButton7.Text = questionReader2.GetString(questionReader2.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton6.Text = questionReader2.GetString(questionReader2.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton5.Hide();
                }
            }
        }
        questionReader2.Close();
        #endregion

        #region question 3 
        sqlExp = $"select*from Question where ID='{listich[2]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader3 = sqlCom.ExecuteReader();
        if (questionReader3.HasRows)
        {
            while (questionReader3.Read())
            {
                try
                {
                    label3.Text = questionReader3.GetString(questionReader3.GetOrdinal("Formulation"));
                    radioButton12.Text = questionReader3.GetString(questionReader3.GetOrdinal("CorrectAnswer"));
                    radioButton11.Text = questionReader3.GetString(questionReader3.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton10.Text = questionReader3.GetString(questionReader3.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton9.Text = questionReader3.GetString(questionReader3.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label3.Text = questionReader3.GetString(questionReader3.GetOrdinal("Formulation"));
                    radioButton12.Text = questionReader3.GetString(questionReader3.GetOrdinal("CorrectAnswer"));
                    radioButton11.Text = questionReader3.GetString(questionReader3.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton10.Text = questionReader3.GetString(questionReader3.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton9.Hide();
                }
            }
        }
        questionReader3.Close();
        #endregion

        #region question 4 
        sqlExp = $"select*from Question where ID='{listich[3]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader4 = sqlCom.ExecuteReader();
        if (questionReader4.HasRows)
        {
            while (questionReader4.Read())
            {
                try
                {
                    label4.Text = questionReader4.GetString(questionReader4.GetOrdinal("Formulation"));
                    radioButton16.Text = questionReader4.GetString(questionReader4.GetOrdinal("CorrectAnswer"));
                    radioButton15.Text = questionReader4.GetString(questionReader4.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton14.Text = questionReader4.GetString(questionReader4.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton13.Text = questionReader4.GetString(questionReader4.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label4.Text = questionReader4.GetString(questionReader4.GetOrdinal("Formulation"));
                    radioButton16.Text = questionReader4.GetString(questionReader4.GetOrdinal("CorrectAnswer"));
                    radioButton15.Text = questionReader4.GetString(questionReader4.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton14.Text = questionReader4.GetString(questionReader4.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton13.Hide();
                }
            }
        }
        questionReader4.Close();
        #endregion

        #region question 5 
        sqlExp = $"select*from Question where ID='{listich[4]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader5 = sqlCom.ExecuteReader();
        if (questionReader5.HasRows)
        {
            while (questionReader5.Read())
            {
                try
                {
                    label5.Text = questionReader5.GetString(questionReader5.GetOrdinal("Formulation"));
                    radioButton20.Text = questionReader5.GetString(questionReader5.GetOrdinal("CorrectAnswer"));
                    radioButton19.Text = questionReader5.GetString(questionReader5.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton18.Text = questionReader5.GetString(questionReader5.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton17.Text = questionReader5.GetString(questionReader5.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label5.Text = questionReader5.GetString(questionReader5.GetOrdinal("Formulation"));
                    radioButton20.Text = questionReader5.GetString(questionReader5.GetOrdinal("CorrectAnswer"));
                    radioButton19.Text = questionReader5.GetString(questionReader5.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton18.Text = questionReader5.GetString(questionReader5.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton17.Hide();
                }
            }
        }
        questionReader5.Close();
        #endregion

        #region question 6 
        sqlExp = $"select*from Question where ID='{listich[5]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader6 = sqlCom.ExecuteReader();
        if (questionReader6.HasRows)
        {
            while (questionReader6.Read())
            {
                try
                {
                    label6.Text = questionReader6.GetString(questionReader6.GetOrdinal("Formulation"));
                    radioButton24.Text = questionReader6.GetString(questionReader6.GetOrdinal("CorrectAnswer"));
                    radioButton23.Text = questionReader6.GetString(questionReader6.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton22.Text = questionReader6.GetString(questionReader6.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton21.Text = questionReader6.GetString(questionReader6.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label6.Text = questionReader6.GetString(questionReader6.GetOrdinal("Formulation"));
                    radioButton24.Text = questionReader6.GetString(questionReader6.GetOrdinal("CorrectAnswer"));
                    radioButton23.Text = questionReader6.GetString(questionReader6.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton22.Text = questionReader6.GetString(questionReader6.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton21.Hide();
                }
            }
        }
        questionReader6.Close();
        #endregion

        #region question 7 
        sqlExp = $"select*from Question where ID='{listich[6]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader7 = sqlCom.ExecuteReader();
        if (questionReader7.HasRows)
        {
            while (questionReader7.Read())
            {
                try
                {
                    label7.Text = questionReader7.GetString(questionReader7.GetOrdinal("Formulation"));
                    radioButton28.Text = questionReader7.GetString(questionReader7.GetOrdinal("CorrectAnswer"));
                    radioButton27.Text = questionReader7.GetString(questionReader7.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton26.Text = questionReader7.GetString(questionReader7.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton25.Text = questionReader7.GetString(questionReader7.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label7.Text = questionReader7.GetString(questionReader7.GetOrdinal("Formulation"));
                    radioButton28.Text = questionReader7.GetString(questionReader7.GetOrdinal("CorrectAnswer"));
                    radioButton27.Text = questionReader7.GetString(questionReader7.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton26.Text = questionReader7.GetString(questionReader7.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton25.Hide();
                }
            }
        }
        questionReader7.Close();
        #endregion

        #region question 8 
        sqlExp = $"select*from Question where ID='{listich[7]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader8 = sqlCom.ExecuteReader();
        if (questionReader8.HasRows)
        {
            while (questionReader8.Read())
            {
                try
                {
                    label8.Text = questionReader8.GetString(questionReader8.GetOrdinal("Formulation"));
                    radioButton32.Text = questionReader8.GetString(questionReader8.GetOrdinal("CorrectAnswer"));
                    radioButton31.Text = questionReader8.GetString(questionReader8.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton30.Text = questionReader8.GetString(questionReader8.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton29.Text = questionReader8.GetString(questionReader8.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label8.Text = questionReader8.GetString(questionReader8.GetOrdinal("Formulation"));
                    radioButton32.Text = questionReader8.GetString(questionReader8.GetOrdinal("CorrectAnswer"));
                    radioButton31.Text = questionReader8.GetString(questionReader8.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton30.Text = questionReader8.GetString(questionReader8.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton29.Hide();
                }
            }
        }
        questionReader8.Close();
        #endregion

        #region question 9 
        sqlExp = $"select*from Question where ID='{listich[8]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader9 = sqlCom.ExecuteReader();
        if (questionReader9.HasRows)
        {
            while (questionReader9.Read())
            {
                try
                {
                    label9.Text = questionReader9.GetString(questionReader9.GetOrdinal("Formulation"));
                    radioButton36.Text = questionReader9.GetString(questionReader9.GetOrdinal("CorrectAnswer"));
                    radioButton35.Text = questionReader9.GetString(questionReader9.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton34.Text = questionReader9.GetString(questionReader9.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton33.Text = questionReader9.GetString(questionReader9.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label9.Text = questionReader9.GetString(questionReader9.GetOrdinal("Formulation"));
                    radioButton36.Text = questionReader9.GetString(questionReader9.GetOrdinal("CorrectAnswer"));
                    radioButton35.Text = questionReader9.GetString(questionReader9.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton34.Text = questionReader9.GetString(questionReader9.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton33.Hide();
                }
            }
        }
        questionReader9.Close();
        #endregion

        #region question 10 
        sqlExp = $"select*from Question where ID='{listich[9]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader10 = sqlCom.ExecuteReader();
        if (questionReader10.HasRows)
        {
            while (questionReader10.Read())
            {
                try
                {
                    label10.Text = questionReader10.GetString(questionReader10.GetOrdinal("Formulation"));
                    radioButton40.Text = questionReader10.GetString(questionReader10.GetOrdinal("CorrectAnswer"));
                    radioButton39.Text = questionReader10.GetString(questionReader10.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton38.Text = questionReader10.GetString(questionReader10.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton37.Text = questionReader10.GetString(questionReader10.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label10.Text = questionReader10.GetString(questionReader10.GetOrdinal("Formulation"));
                    radioButton40.Text = questionReader10.GetString(questionReader10.GetOrdinal("CorrectAnswer"));
                    radioButton39.Text = questionReader10.GetString(questionReader10.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton38.Text = questionReader10.GetString(questionReader10.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton37.Hide();
                }
            }
        }
        questionReader10.Close();
        #endregion

        #region question 11 
        sqlExp = $"select*from Question where ID='{listich[10]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader11 = sqlCom.ExecuteReader();
        if (questionReader11.HasRows)
        {
            while (questionReader11.Read())
            {
                try
                {
                    label11.Text = questionReader11.GetString(questionReader11.GetOrdinal("Formulation"));
                    radioButton44.Text = questionReader11.GetString(questionReader11.GetOrdinal("CorrectAnswer"));
                    radioButton43.Text = questionReader11.GetString(questionReader11.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton42.Text = questionReader11.GetString(questionReader11.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton41.Text = questionReader11.GetString(questionReader11.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label11.Text = questionReader11.GetString(questionReader11.GetOrdinal("Formulation"));
                    radioButton44.Text = questionReader11.GetString(questionReader11.GetOrdinal("CorrectAnswer"));
                    radioButton43.Text = questionReader11.GetString(questionReader11.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton42.Text = questionReader11.GetString(questionReader11.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton41.Hide();
                }
            }
        }
        questionReader11.Close();
        #endregion

        #region question 12 
        sqlExp = $"select*from Question where ID='{listich[11]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader12 = sqlCom.ExecuteReader();
        if (questionReader12.HasRows)
        {
            while (questionReader12.Read())
            {
                try
                {
                    label12.Text = questionReader12.GetString(questionReader12.GetOrdinal("Formulation"));
                    radioButton48.Text = questionReader12.GetString(questionReader12.GetOrdinal("CorrectAnswer"));
                    radioButton47.Text = questionReader12.GetString(questionReader12.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton46.Text = questionReader12.GetString(questionReader12.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton45.Text = questionReader12.GetString(questionReader12.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label12.Text = questionReader12.GetString(questionReader12.GetOrdinal("Formulation"));
                    radioButton48.Text = questionReader12.GetString(questionReader12.GetOrdinal("CorrectAnswer"));
                    radioButton47.Text = questionReader12.GetString(questionReader12.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton46.Text = questionReader12.GetString(questionReader12.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton45.Hide();
                }
            }
        }
        questionReader12.Close();
        #endregion

        #region question 13 
        sqlExp = $"select*from Question where ID='{listich[12]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader13 = sqlCom.ExecuteReader();
        if (questionReader13.HasRows)
        {
            while (questionReader13.Read())
            {
                try
                {
                    label13.Text = questionReader13.GetString(questionReader13.GetOrdinal("Formulation"));
                    radioButton52.Text = questionReader13.GetString(questionReader13.GetOrdinal("CorrectAnswer"));
                    radioButton51.Text = questionReader13.GetString(questionReader13.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton50.Text = questionReader13.GetString(questionReader13.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton49.Text = questionReader13.GetString(questionReader13.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label13.Text = questionReader13.GetString(questionReader13.GetOrdinal("Formulation"));
                    radioButton52.Text = questionReader13.GetString(questionReader13.GetOrdinal("CorrectAnswer"));
                    radioButton51.Text = questionReader13.GetString(questionReader13.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton50.Text = questionReader13.GetString(questionReader13.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton49.Hide();
                }
            }
        }
        questionReader13.Close();
        #endregion

        #region question 14 
        sqlExp = $"select*from Question where ID='{listich[13]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader14 = sqlCom.ExecuteReader();
        if (questionReader14.HasRows)
        {
            while (questionReader14.Read())
            {
                try
                {
                    label14.Text = questionReader14.GetString(questionReader14.GetOrdinal("Formulation"));
                    radioButton56.Text = questionReader14.GetString(questionReader14.GetOrdinal("CorrectAnswer"));
                    radioButton55.Text = questionReader14.GetString(questionReader14.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton54.Text = questionReader14.GetString(questionReader14.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton53.Text = questionReader14.GetString(questionReader14.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label14.Text = questionReader14.GetString(questionReader14.GetOrdinal("Formulation"));
                    radioButton56.Text = questionReader14.GetString(questionReader14.GetOrdinal("CorrectAnswer"));
                    radioButton55.Text = questionReader14.GetString(questionReader14.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton54.Text = questionReader14.GetString(questionReader14.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton53.Hide();
                }
            }
        }
        questionReader14.Close();
        #endregion

        #region question 15  
        sqlExp = $"select*from Question where ID='{listich[14]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader15 = sqlCom.ExecuteReader();
        if (questionReader15.HasRows)
        {
            while (questionReader15.Read())
            {
                try
                {
                    label15.Text = questionReader15.GetString(questionReader15.GetOrdinal("Formulation"));
                    radioButton60.Text = questionReader15.GetString(questionReader15.GetOrdinal("CorrectAnswer"));
                    radioButton59.Text = questionReader15.GetString(questionReader15.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton58.Text = questionReader15.GetString(questionReader15.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton57.Text = questionReader15.GetString(questionReader15.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label15.Text = questionReader15.GetString(questionReader15.GetOrdinal("Formulation"));
                    radioButton60.Text = questionReader15.GetString(questionReader15.GetOrdinal("CorrectAnswer"));
                    radioButton59.Text = questionReader15.GetString(questionReader15.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton58.Text = questionReader15.GetString(questionReader15.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton57.Hide();
                }
            }
        }
        questionReader15.Close();
        #endregion

        #region question 16  
        sqlExp = $"select*from Question where ID='{listich[15]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader16 = sqlCom.ExecuteReader();
        if (questionReader16.HasRows)
        {
            while (questionReader16.Read())
            {
                try
                {
                    label16.Text = questionReader16.GetString(questionReader16.GetOrdinal("Formulation"));
                    radioButton64.Text = questionReader16.GetString(questionReader16.GetOrdinal("CorrectAnswer"));
                    radioButton63.Text = questionReader16.GetString(questionReader16.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton62.Text = questionReader16.GetString(questionReader16.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton61.Text = questionReader16.GetString(questionReader16.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label16.Text = questionReader16.GetString(questionReader16.GetOrdinal("Formulation"));
                    radioButton64.Text = questionReader16.GetString(questionReader16.GetOrdinal("CorrectAnswer"));
                    radioButton63.Text = questionReader16.GetString(questionReader16.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton62.Text = questionReader16.GetString(questionReader16.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton61.Hide();
                }
            }
        }
        questionReader16.Close();
        #endregion

        #region question 17 
        sqlExp = $"select*from Question where ID='{listich[16]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader17 = sqlCom.ExecuteReader();
        if (questionReader17.HasRows)
        {
            while (questionReader17.Read())
            {
                try
                {
                    label17.Text = questionReader17.GetString(questionReader17.GetOrdinal("Formulation"));
                    radioButton68.Text = questionReader17.GetString(questionReader17.GetOrdinal("CorrectAnswer"));
                    radioButton67.Text = questionReader17.GetString(questionReader17.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton66.Text = questionReader17.GetString(questionReader17.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton65.Text = questionReader17.GetString(questionReader17.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label17.Text = questionReader17.GetString(questionReader17.GetOrdinal("Formulation"));
                    radioButton68.Text = questionReader17.GetString(questionReader17.GetOrdinal("CorrectAnswer"));
                    radioButton67.Text = questionReader17.GetString(questionReader17.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton66.Text = questionReader17.GetString(questionReader17.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton65.Hide();
                }
            }
        }
        questionReader17.Close();
        #endregion

        #region question 18 
        sqlExp = $"select*from Question where ID='{listich[17]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader18 = sqlCom.ExecuteReader();
        if (questionReader18.HasRows)
        {
            while (questionReader18.Read())
            {
                try
                {
                    label18.Text = questionReader18.GetString(questionReader18.GetOrdinal("Formulation"));
                    radioButton72.Text = questionReader18.GetString(questionReader18.GetOrdinal("CorrectAnswer"));
                    radioButton71.Text = questionReader18.GetString(questionReader18.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton70.Text = questionReader18.GetString(questionReader18.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton69.Text = questionReader18.GetString(questionReader18.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label18.Text = questionReader18.GetString(questionReader18.GetOrdinal("Formulation"));
                    radioButton72.Text = questionReader18.GetString(questionReader18.GetOrdinal("CorrectAnswer"));
                    radioButton71.Text = questionReader18.GetString(questionReader18.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton70.Text = questionReader18.GetString(questionReader18.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton69.Hide();
                }
            }
        }
        questionReader18.Close();
        #endregion

        #region question 19 
        sqlExp = $"select*from Question where ID='{listich[18]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader19 = sqlCom.ExecuteReader();
        if (questionReader19.HasRows)
        {
            while (questionReader19.Read())
            {
                try
                {
                    label19.Text = questionReader19.GetString(questionReader19.GetOrdinal("Formulation"));
                    radioButton76.Text = questionReader19.GetString(questionReader19.GetOrdinal("CorrectAnswer"));
                    radioButton75.Text = questionReader19.GetString(questionReader19.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton74.Text = questionReader19.GetString(questionReader19.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton73.Text = questionReader19.GetString(questionReader19.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label19.Text = questionReader19.GetString(questionReader19.GetOrdinal("Formulation"));
                    radioButton76.Text = questionReader19.GetString(questionReader19.GetOrdinal("CorrectAnswer"));
                    radioButton75.Text = questionReader19.GetString(questionReader19.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton74.Text = questionReader19.GetString(questionReader19.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton73.Hide();
                }
            }
        }
        questionReader19.Close();
        #endregion

        #region question 20  
        sqlExp = $"select*from Question where ID='{listich[19]}'";
        sqlCom = new SqlCommand(sqlExp, sc);
        using var questionReader20 = sqlCom.ExecuteReader();
        if (questionReader20.HasRows)
        {
            while (questionReader20.Read())
            {
                try
                {
                    label20.Text = questionReader20.GetString(questionReader20.GetOrdinal("Formulation"));
                    radioButton80.Text = questionReader20.GetString(questionReader20.GetOrdinal("CorrectAnswer"));
                    radioButton79.Text = questionReader20.GetString(questionReader20.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton78.Text = questionReader20.GetString(questionReader20.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton77.Text = questionReader20.GetString(questionReader20.GetOrdinal("ThirdIncorrectAnswer"));

                }
                catch
                {
                    label20.Text = questionReader20.GetString(questionReader20.GetOrdinal("Formulation"));
                    radioButton80.Text = questionReader20.GetString(questionReader20.GetOrdinal("CorrectAnswer"));
                    radioButton79.Text = questionReader20.GetString(questionReader20.GetOrdinal("FirstIncorrectAnswer"));
                    radioButton78.Text = questionReader20.GetString(questionReader20.GetOrdinal("SecondIncorrectAnswer"));
                    radioButton77.Hide();
                }
            }
        }
        questionReader20.Close();
        #endregion
        #endregion
    }

    //TODO
    private void AnswerButton_Click(object sender, EventArgs e)
    {
        int correctAnswers = 0;
        var sqlExpression = $"select ID from Ticket where TicketNumber='{tn}'";
        var sqlCommand = new SqlCommand(sqlExpression, sc);
        var ticketId = sqlCommand.ExecuteScalar();

        if (radioButton1.Checked) { correctAnswers++; }
        if (radioButton8.Checked) { correctAnswers++; }
        if (radioButton12.Checked) { correctAnswers++; }
        if (radioButton16.Checked) { correctAnswers++; }
        if (radioButton20.Checked) { correctAnswers++; }
        if (radioButton24.Checked) { correctAnswers++; }
        if (radioButton28.Checked) { correctAnswers++; }
        if (radioButton32.Checked) { correctAnswers++; }
        if (radioButton36.Checked) { correctAnswers++; }
        if (radioButton40.Checked) { correctAnswers++; }
        if (radioButton44.Checked) { correctAnswers++; }
        if (radioButton48.Checked) { correctAnswers++; }
        if (radioButton52.Checked) { correctAnswers++; }
        if (radioButton56.Checked) { correctAnswers++; }
        if (radioButton60.Checked) { correctAnswers++; }
        if (radioButton64.Checked) { correctAnswers++; }
        if (radioButton68.Checked) { correctAnswers++; }
        if (radioButton72.Checked) { correctAnswers++; }
        if (radioButton76.Checked) { correctAnswers++; }
        if (radioButton80.Checked) { correctAnswers++; }

        sqlExpression = $"select ID from PerformanceOnTickets where UserID=39 and TicketID='{ticketId}'";
        sqlCommand = new SqlCommand(sqlExpression, sc);
        var res2 = sqlCommand.ExecuteScalar();
        if (res2!=null)
        {
            if (correctAnswers > 18)
            {
                sqlExpression = $"update PerformanceOnTickets set CorrectAnswer=1 where UserID=39 and TicketID='{ticketId}'";
                sqlCommand = new SqlCommand(sqlExpression, sc);
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                sqlExpression = $"update PerformanceOnTickets set CorrectAnswer=0 where UserID=39 and TicketID='{ticketId}'";
                sqlCommand = new SqlCommand(sqlExpression, sc);
                sqlCommand.ExecuteNonQuery();
            }
        }
        else
        {
            if (correctAnswers >= 18)
            {
                sqlExpression = $"insert PerformanceOnTickets(CorrectAnswer,UserID,TicketID, SolveDate)" +
                $" values (1,39,'{ticketId}','2024-09-01')";
                sqlCommand = new SqlCommand(sqlExpression, sc);
                sqlCommand.ExecuteNonQuery();
            }
            else
            {
                sqlExpression = $"insert PerformanceOnTickets(CorrectAnswer,UserID,TicketID, SolveDate)" +
                $" values (0,39,'{ticketId}','2024-09-01')";
                sqlCommand = new SqlCommand(sqlExpression, sc);
                sqlCommand.ExecuteNonQuery();
            }
        }
        this.Hide();
    }
}
