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
    public partial class userWithdraw : Form
    {
        public userWithdraw()
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

        private void countWithdraw(ref int count)
        {
            
            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT COUNT(accNumber) FROM transaction_tbl  WHERE accNumber = @accNumber AND transactionType = @transactionType AND MONTH(transactionDate) = @transactionDate GROUP BY MONTH(transactionDate)";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
                cmd.Parameters.AddWithValue("@transactionType", "Withdraw");
                cmd.Parameters.AddWithValue("@transactionDate", DateTime.Now.Month);
                SqlDataReader reader1 = cmd.ExecuteReader();

                if (reader1.Read())
                {
                    count = (int)reader1[0];
                }
                

                conn.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void getServiceCharge(ref double serviceCharge)
        {
            int count = 0;
            countWithdraw(ref count);
            count++;

            if (count <= 3)
            {
                serviceCharge = 0.00;
            }
            else if (count > 3)
            {
                serviceCharge = 1.50;
            }
        }

        private void withdrawValidation(ref String withdrawStatus,ref double balance)
        {
            double accBalance = 0;
            getBalance(ref accBalance);
            double serviceCharge = 0;
            getServiceCharge(ref serviceCharge);

            if (withdrawalInput.Text == "")
            {
                MessageBox.Show("Withdraw Cannot be Empty");
                return;
            }

            double withdrawAmount = double.Parse(withdrawalInput.Text);
            balance = accBalance - withdrawAmount - serviceCharge;

            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);

            if (balance < 20)
            {
                msgOutput.Text = "Your Account balance Cannot be Less Than 20";
                MessageBox.Show("Your Account balance Cannot be Less Than 20");
                return;
            }

            if (withdrawAmount < 0)
            {
                msgOutput.Text = " Your Withdrawal Amount Cannot be Less Than 0";
                MessageBox.Show(" Your Withdrawal Amount Cannot be Less Than 0");
                return;
            }


            if (withdrawAmount < 500)
            {
                DialogResult dialogResult = MessageBox.Show("Are You Approving this Transaction", "Teller Approval", MessageBoxButtons.YesNo);
               
                if (dialogResult == DialogResult.Yes)
                {
                    withdrawStatus = "Approved";
                    string query = "INSERT INTO staffValidation_tbl VALUES (@staffId,@accNumber,@accBalance,@withdrawAmount,@serviceCharge,@withdrawStatus,@approval)";
                   
                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@staffId", "TellerID");
                        cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
                        cmd.Parameters.AddWithValue("@accBalance", balance);
                        cmd.Parameters.AddWithValue("@withdrawAmount", withdrawAmount);
                        cmd.Parameters.AddWithValue("@serviceCharge", serviceCharge);
                        cmd.Parameters.AddWithValue("@withdrawStatus", withdrawStatus);
                        cmd.Parameters.AddWithValue("@approval", "Teller");
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    catch (SqlException exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                    MessageBox.Show("Your withdraw is Approved");
                }
                else if (dialogResult == DialogResult.No)
                {
                    withdrawStatus = "Declined";
                    MessageBox.Show("Transaction Rejected ");
                    string query = "INSERT INTO staffValidation_tbl VALUES (@staffId,@accNumber,@accBalance,@withdrawAmount,@serviceCharge,@withdrawStatus,@approval)";

                    try
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@staffId", "TellerID");
                        cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
                        cmd.Parameters.AddWithValue("@accBalance", balance);
                        cmd.Parameters.AddWithValue("@withdrawAmount", withdrawAmount);
                        cmd.Parameters.AddWithValue("@serviceCharge", serviceCharge);
                        cmd.Parameters.AddWithValue("@withdrawStatus", withdrawStatus);
                        cmd.Parameters.AddWithValue("@approval", "Teller");
                        cmd.ExecuteNonQuery();
                        conn.Close();
                    }

                    catch (SqlException exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    return;
                }
                
            }

            if (withdrawAmount > 500 && withdrawAmount <= 5000)
            {
                MessageBox.Show("Neeed Approval From Bank Supervisor");
                withdrawStatus = "Validating";
                string query = "INSERT INTO staffValidation_tbl VALUES (@staffId,@accNumber,@accBalance,@withdrawAmount,@serviceCharge,@withdrawStatus,@approval)";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@staffId", "SupervisorID");
                    cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
                    cmd.Parameters.AddWithValue("@accBalance", accBalance);
                    cmd.Parameters.AddWithValue("@withdrawAmount", withdrawAmount);
                    cmd.Parameters.AddWithValue("@serviceCharge", serviceCharge);
                    cmd.Parameters.AddWithValue("@withdrawStatus", withdrawStatus);
                    cmd.Parameters.AddWithValue("@approval", "Supervisor");
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                catch (SqlException exc)
                {
                    MessageBox.Show(exc.Message);
                }

                admin admin = new admin();
                admin.Show();
                this.Close();

            }

            else if (withdrawAmount > 5000)
            {
                MessageBox.Show("Neeed Approval From Bank Assistant Manager");
                withdrawStatus = "Validating";
                string query = "INSERT INTO staffValidation_tbl VALUES (@staffId,@accNumber,@accBalance,@withdrawAmount,@serviceCharge,@withdrawStatus,@approval)";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@staffId", "AssistantManagerID");
                    cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
                    cmd.Parameters.AddWithValue("@accBalance", accBalance);
                    cmd.Parameters.AddWithValue("@withdrawAmount", withdrawAmount);
                    cmd.Parameters.AddWithValue("@serviceCharge", serviceCharge);
                    cmd.Parameters.AddWithValue("@withdrawStatus", withdrawStatus);
                    cmd.Parameters.AddWithValue("@approval", "Assistant Manager");
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                catch (SqlException exc)
                {
                    MessageBox.Show(exc.Message);
                }

                this.Hide();
                admin admin = new admin();
                admin.Show();
                
            }

            if(withdrawStatus == "Approved")
            {
                string query2 = "INSERT INTO transaction_tbl VALUES (@accNumber,@accBalance, @transactionType,@transactionAmount,@serviceCharge,@transactionDate,@transactionStatus,@approvedBy)";

                try
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query2, conn);
                    cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
                    cmd.Parameters.AddWithValue("@accBalance", balance);
                    cmd.Parameters.AddWithValue("@transactionType", "Withdraw");
                    cmd.Parameters.AddWithValue("@transactionAmount", withdrawAmount);
                    cmd.Parameters.AddWithValue("@serviceCharge", serviceCharge);
                    cmd.Parameters.AddWithValue("@transactionDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@transactionStatus", withdrawStatus);
                    cmd.Parameters.AddWithValue("@approvedBy", "TellerID");
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                catch (SqlException exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }

        }

        private void updateAccBalance()
        {
            String withdrawStatus = "";
            double balance = 0;
            withdrawValidation(ref withdrawStatus, ref balance);


            if (balance < 20)
            {
                MessageBox.Show("Insufficient Balance");
                return;
            }

            accountBalDisp.Text = balance.ToString();

            if (withdrawStatus == "Approved")
            {
                string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                string query = "UPDATE users SET [accBalance] = @deposit WHERE [accNumber] = @accNumber";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
                    cmd.Parameters.AddWithValue("@deposit", balance);
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
            }
        }

        private void userWithdraw_Load(object sender, EventArgs e)
        {
            double accBalance = 0;
            int count = 0;
            getBalance(ref accBalance);
            countWithdraw(ref count);
            accountBalDisp.Text = accBalance.ToString();
            viewWithdrawTimes.Text = count.ToString();

            if (count >= 3)
            {
                msgOutput.Text = "Service Charge of 1.50 will be applied on withdrawal";
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            String temp = "";
            temp = withdrawalInput.Text;

            if (temp =="")
            {
                msgOutput.Text = "Cannot leave the Withdraw Amount Empty";
                return;
            }
            updateAccBalance();
            int count = 0;
            countWithdraw(ref count);
            viewWithdrawTimes.Text = count.ToString();

            if (count >= 3)
            {
                msgOutput.Text = "Service Charge of 1.50 will be applied on withdrawal";
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            transactionPage transactionPage = new transactionPage();
            transactionPage.Show();
            this.Hide();
        }

        private void withdrawalInput_KeyPress(object sender, KeyPressEventArgs e)
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
