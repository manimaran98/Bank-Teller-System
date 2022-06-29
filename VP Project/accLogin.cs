using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class accLogin : Form
    {
        public accLogin()
        {
            InitializeComponent();
        }

        public static String name, icNum, address, branchname, accType, accNumber1, accBalance;

        private void inputAccNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void getAccLogin(ref String accNumber)
        {
           accNumber = inputAccNumber.Text;
        }

        private void validateAccLogin(ref String accNumber,ref String error)
        {
            accNumber = "";
            getAccLogin(ref accNumber);

            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT [name],[icNum],[address],[branchname],[accType],[accNumber],[accBalance] FROM users WHERE [accNumber] = @accNumber";

            if (accNumber == "")
            {
                error = "You Cannot Leave the Fill Empty";
                msgOutput.Text = error;
                return;
            }

            try
            {
                bool Found = false;
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", accNumber);
                SqlDataReader reader1 = cmd.ExecuteReader();

                while (reader1.Read())
                {
                        name = reader1[0].ToString();
                        icNum = reader1[1].ToString();
                        address = reader1[2].ToString();
                        branchname = reader1[3].ToString();
                        accType = reader1[4].ToString();
                        accNumber1 = reader1[5].ToString();
                        accBalance = reader1[6].ToString();
                        Found = true;
                }

                if (!Found)
                {
                    error = "Account Number Not Found";
                    msgOutput.Text = error;
                    conn.Close();
                    return;
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String accNumber = "";
            String error = "";
            validateAccLogin(ref accNumber,ref error);

            if (error != "")
            {
                return;
            }

            MessageBox.Show("Welcome Back " + name);
            transactionPage transaction = new transactionPage();
            transaction.Show();
            this.Hide();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }
    }
}
