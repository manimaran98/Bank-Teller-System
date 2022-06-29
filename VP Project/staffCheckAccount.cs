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
    public partial class staffCheckAccount : Form
    {
        public staffCheckAccount()
        {
            InitializeComponent();
        }

        public static String accNumber = "";
        public static String accName="";
        public static String IcNum = "";
        public static String address = "";
        public static String branachName = "";
        public static String accType = "";
        public static double accBalance = 0;
        SqlDataAdapter sda;
        DataTable dt;

        private void getAccNumber()
        {
            accNumber = accNumInput.Text;
        }

        private void getTransactionInfo()
        {
            getAccNumber();
            String searchType1 = "";
            int date1;
            string query = "";
            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            searchType1 = comboBoxTrans.SelectedItem.ToString();
            String temp1 = comboBoxDura.SelectedItem.ToString();
            date1 = int.Parse(temp1.Substring(0,2));

            if (searchType1 == "All")
            {
                query = string.Format("SELECT*FROM transaction_tbl WHERE [accNumber]=" + accNumber + " AND transactionDate >= DATEADD(M, "+(-date1)+", GETDATE())");
                                                                                                                             

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accNumber", accNumber);
                    sda = new SqlDataAdapter(query, conn);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }

                String sumDepo = "";
                string query2 = "SELECT SUM (transactionAmount) FROM transaction_tbl WHERE [accNumber] = @accNumber AND [transactionType] = 'Deposit' AND transactionDate >= DATEADD(M, " + (-date1) + ", GETDATE())";

                try
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query2, conn);
                    cmd.Parameters.AddWithValue("@accNumber", accNumber);
                    cmd.Parameters.AddWithValue("@transactionType", "Deposit");
                    SqlDataReader reader1 = cmd.ExecuteReader();

                    if (reader1.Read())
                    {

                        sumDepo = reader1[0].ToString();
                    }

                    conn.Close();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show(exc.Message);
                }

                totalDepositOut.Text = sumDepo.ToString();

                String sumWith = "";
                string query3 = "SELECT SUM (transactionAmount) FROM transaction_tbl WHERE [accNumber] = @accNumber AND [transactionType] = 'Withdraw' AND transactionDate >= DATEADD(M, " + (-date1) + ", GETDATE())";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query3, conn);
                    cmd.Parameters.AddWithValue("@accNumber", accNumber);
                    SqlDataReader reader1 = cmd.ExecuteReader();

                    if (reader1.Read())
                    {

                        sumWith = reader1[0].ToString();
                    }

                    conn.Close();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show(exc.Message);
                }

                totalWithdrawOut.Text = sumWith.ToString();
            }

            if (searchType1 == "Deposit")
            {
                query = string.Format("SELECT [transactionId],[accNumber],[accBalance],[transactionType],[transactionAmount],[transactionDate] FROM transaction_tbl WHERE [accNumber]=" + accNumber +" AND transactionDate >= DATEADD(M, " + (-date1) + ", GETDATE()) AND transactionType = "+"'"+searchType1+"'"+"");

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accNumber", accNumber);
                    sda = new SqlDataAdapter(query, conn);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }
                String sumDepo = "";
                string query2 = "SELECT SUM (transactionAmount) FROM transaction_tbl WHERE [accNumber] = @accNumber AND [transactionType] = 'Deposit' AND transactionDate >= DATEADD(M, " + (-date1) + ", GETDATE())";

                try
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query2, conn);
                    cmd.Parameters.AddWithValue("@accNumber", accNumber);
                    cmd.Parameters.AddWithValue("@transactionType", "Deposit");
                    SqlDataReader reader1 = cmd.ExecuteReader();

                    if (reader1.Read())
                    {

                        sumDepo = reader1[0].ToString();
                    }

                    conn.Close();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show(exc.Message);
                }

                totalDepositOut.Text = sumDepo.ToString();
                totalWithdrawOut.Text = "";
            }

            if (searchType1 == "Withdraw")
            {
                query = string.Format("SELECT [transactionId],[accNumber],[accBalance],[transactionType],[transactionAmount],[transactionDate],[transactionStatus],[approvedBy] FROM transaction_tbl WHERE [accNumber]=" + accNumber + " AND transactionDate >= DATEADD(M, " + (-date1) + ", GETDATE()) AND transactionType = " + "'" + searchType1 + "'" + "");

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accNumber", accNumber);
                    sda = new SqlDataAdapter(query, conn);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();
                }
                catch (Exception exx)
                {
                    MessageBox.Show(exx.Message);
                }

                String sumWith = "";
                string query3 = "SELECT SUM (transactionAmount) FROM transaction_tbl WHERE [accNumber] = @accNumber AND [transactionType] = 'Withdraw' AND transactionDate >= DATEADD(M, " + (-date1) + ", GETDATE())";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query3, conn);
                    cmd.Parameters.AddWithValue("@accNumber", accNumber);
                    SqlDataReader reader1 = cmd.ExecuteReader();

                    if (reader1.Read())
                    {

                        sumWith = reader1[0].ToString();
                    }

                    conn.Close();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show(exc.Message);
                }

                totalWithdrawOut.Text = sumWith.ToString();
                totalDepositOut.Text = "";
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (accNumInput.Text==""|| comboBoxTrans.Text=="" || comboBoxDura.Text=="")
            {
                MessageBox.Show("Cannot Leave the Fill and Option Empty");

                return;
            }

            getAccNumber();

            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT [name],[icNum],[address],[branchName],[accType],[accBalance] FROM users WHERE [accNumber] = @accNumber";
            String error= "";
            try
            {
                bool Found = false;
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", accNumber);
                SqlDataReader reader1 = cmd.ExecuteReader();

                if (reader1.Read())
                {

                    dispName.Text = reader1[0].ToString();
                    dispIc.Text = reader1[1].ToString();
                    dispAddress.Text = reader1[2].ToString();
                    dispBranch.Text = reader1[3].ToString();
                    dispAccType.Text = reader1[4].ToString();
                    dispAccBal.Text = reader1[5].ToString();
                    Found = true;
                }

                if (!Found)
                {
                    error = "Account Number Not Found";
                    MessageBox.Show(error);
                    conn.Close();
                    return;
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }

            getTransactionInfo();
        }

        private void uptBtn_Click(object sender, EventArgs e)
        {
            if (accNumInput.Text == ""|| dispName.Text==""|| dispIc.Text==""|| dispAddress.Text==""|| dispBranch.Text==""|| dispAccType.Text==""|| dispAccBal.Text=="")
            {
                MessageBox.Show("Cannot Leave the Fill and Option Empty");

                return;
            }

            String name = dispName.Text;
            String icNum = dispIc.Text;
            String address = dispAddress.Text;
            String branchName = dispBranch.Text;
            String accType = dispAccType.Text;
            String accBalance = dispAccBal.Text;


            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "UPDATE users SET [name] = @name,[icNum] = @icNum,[address] = @address,[branchName] = @branchName,[accType] = @accType,[accBalance] = @accBalance WHERE [accNumber] = @accNumber";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", accNumber);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@icNum", icNum);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@branchName", branchName);
                cmd.Parameters.AddWithValue("@accType", accType);
                cmd.Parameters.AddWithValue("@accBalance", accBalance);
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

            MessageBox.Show("Bank Account Have Been Updated");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (accNumInput.Text == "")
            {
                MessageBox.Show("Cannot Leave the Fill and Option Empty");

                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "DELETE FROM users WHERE [accNumber] = @accNumber; DELETE FROM transaction_tbl WHERE [accNumber] = @accNumber; DELETE FROM staffValidation_tbl WHERE [accNumber] = @accNumber ;";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", accNumber);
                DialogResult dr = MessageBox.Show("Are You sure you want to delete this Account?", "Confirm", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("This Bank Account Have been Terminated");
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

            MessageBox.Show("Bank Account Have Been Deleted From the System");
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void staffCheckAccount_Load(object sender, EventArgs e)
        {
            
        }

        private void accNumInput_KeyPress(object sender, KeyPressEventArgs e)
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

        private void comboBoxTrans_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetterOrDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void comboBoxDura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetterOrDigit(e.KeyChar)))
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            accNumInput.Text = "";
            dispName.Text = "";
           dispIc.Text = "";
            dispAddress.Text = "";
            dispBranch.Text = "";
            dispAccType.Text = "";
            dispAccBal.Text = "";
            dataGridView1.DataSource = "";
            totalDepositOut.Text = "";
            totalWithdrawOut.Text = "";
            comboBoxTrans.Text = "";
            comboBoxDura.Text = "";

        }
    }
}
