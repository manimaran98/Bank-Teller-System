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
    public partial class deposit : Form
    {
        public deposit()
        {
            InitializeComponent();
        }

        private void getBalance(ref double accBalance)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT [accBalance] FROM users WHERE [accNumber] = @accNumber";

            try
            {
                bool Found = false;
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
                SqlDataReader reader1 = cmd.ExecuteReader();

                if (reader1.Read())
                {

                    accBalance = double.Parse(reader1[0].ToString());
                }

                conn.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        public void getNewbalance(ref double newAccbalance,ref double newDeposit)
        {
            double accBalance = 0;
            getBalance(ref accBalance);
             newDeposit = 0;
            String temp = depositInput.Text;
            newDeposit = double.Parse(temp);
            newAccbalance = newDeposit + accBalance;
        }

        private void depositHist()
        {
            double newAccbalance = 0;
            double newDeposit = 0;
            getNewbalance(ref newAccbalance, ref newDeposit);

            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "INSERT INTO transaction_tbl VALUES (@accNumber,@accBalance, @transactionType,@transactionAmount,@serviceCharge,@transactionDate,@transactionStatus,@approvedBy)";

           
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
                cmd.Parameters.AddWithValue("@accBalance", newAccbalance);
                cmd.Parameters.AddWithValue("@transactionType", "Deposit");
                cmd.Parameters.AddWithValue("@transactionAmount", newDeposit);
                cmd.Parameters.AddWithValue("@serviceCharge", "0.00");
                cmd.Parameters.AddWithValue("@transactionDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@transactionStatus", "Approved");
                cmd.Parameters.AddWithValue("@approvedBy", "TellerID");
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void updateAccBalance(ref String displayBal)
        {
            double newAccbalance = 0;
            double accBalance = 0;
            getNewbalance(ref newAccbalance,ref accBalance);

            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "UPDATE users SET [accBalance] = @deposit WHERE [accNumber] = @accNumber";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
                cmd.Parameters.AddWithValue("@deposit", newAccbalance);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }

            finally
            {
                conn.Close();
            }
            displayBal = newAccbalance.ToString();
            MessageBox.Show("Deposit Accepted");
        }

        private void deposit_Load(object sender, EventArgs e)
        {
            double accBalance = 0;
            getBalance(ref accBalance);
            accountBalDisp.Text = accBalance.ToString();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            transactionPage transaction = new transactionPage();
            transaction.Show();
            this.Hide();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            String temp = depositInput.Text;

            if (temp == "")
            {
                MessageBox.Show("Deposit Input Cannot be empty");
                transactionPage transactionPage = new transactionPage();
                transactionPage.Show();
                this.Hide();
                return;
            }

            depositHist();
            String displayBal="";
            updateAccBalance(ref displayBal);

            accountBalDisp.Text = displayBal;
        }
    }
}
