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
    public partial class openAccDeposit : Form
    {
        public openAccDeposit()
        {
            InitializeComponent();
        }

        private void openAccDeposit_Load(object sender, EventArgs e)
        {
            inputAcc.Text = openAcc.accNumber1;
            String accType = openAcc.accType1;

            if (accType == "Normal Savings Account")
            {
                outMsg.Text = "Your Deposit Must be More than RM 50";
            }

            if (accType == "Premium Savings Account")
            {
                outMsg.Text = "Your Deposit Must be More than RM 500";
            }


            if (accType == "Current Account")
            {
                outMsg.Text = "Your Deposit Must be More than RM 1000";
            }
        }

       private bool getDeposit(ref int deposit,ref String error)
        {
            String accType = openAcc.accType1;
            int tempDeposit = 0;
            
            tempDeposit = int.Parse(inputDeposit.Text);

            while (true)
            {

            
            if (accType == "Normal Savings Account")
            {
                if (tempDeposit < 50)
                {
                    error = "Error! Your Deposit Must be More than RM 50";
                    outMsg.Text = error;
                    return true;
                }

                else if (tempDeposit >= 50)
                {
                    deposit = tempDeposit;
                    outMsg.Text = "Your Deposit Have Been Saved";
                    return  false;

                }
            }

            if (accType == "Premium Savings Account")
            {
                if (tempDeposit < 500)
                {
                        error = "Error! Your Deposit Must be More than RM 500";
                        outMsg.Text = error;
                        return true;
                    }

                else if (tempDeposit >= 500)
                {
                    deposit = tempDeposit;
                    outMsg.Text = "Your Deposit Have Been Saved";
                        return false;
                }
            }

            if (accType == "Current Account")
            {
                if (tempDeposit < 1000)
                {
                        error = "Error! Your Deposit Must be More than RM 1000";
                        outMsg.Text = error;
                        return true;
                }

                else if (tempDeposit >= 1000)
                {
                    deposit = tempDeposit;
                    outMsg.Text = "Your Deposit Have Been Saved";
                        return false;
                }
            }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deposit = 0;
            string error = "";

            getDeposit(ref deposit,ref error);

            inputValidation(ref error);


            if (error != "")
            {
                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "UPDATE users SET [accBalance] = @deposit WHERE [accNumber] = @accNumber";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", openAcc.accNumber1);
                cmd.Parameters.AddWithValue("@deposit", deposit);
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

            string query2 = "INSERT INTO transaction_tbl VALUES (@accNumber,@accBalance, @transactionType,@transactionAmount,@serviceCharge,@transactionDate,@transactionStatus,@approvedBy)";


            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query2, conn);
                cmd.Parameters.AddWithValue("@accNumber", openAcc.accNumber1);
                cmd.Parameters.AddWithValue("@accBalance", deposit);
                cmd.Parameters.AddWithValue("@transactionType", "Deposit");
                cmd.Parameters.AddWithValue("@transactionAmount", deposit);
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

            MessageBox.Show("Your Bank Account Have been Created");
            Home Home = new Home();
            Home.Show();
            this.Hide();

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "DELETE FROM users WHERE [accNumber] = @accNumber";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", openAcc.accNumber1);
                DialogResult dr = MessageBox.Show("If you cancel Your Bank Account will be Terminated From Our System?", "Confirm", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Bank Account Have been Terminated");
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }

            finally
            {
                conn.Close();
            }
        }

        private void inputValidation(ref string error)
        {
          String userDeposit = inputDeposit.Text;

            if (userDeposit == "")
            {
                error = "Cannot Leave the Deposit Empty";
                return;
            } 
        }

        private void inputDeposit_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
