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
    public partial class transactionHistMain : Form
    {
        SqlDataAdapter sda;
        DataTable dt;

        public transactionHistMain()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            String temp = "";

            if (searchType.Text == "")
            {
                MessageBox.Show("Cannot Leave the Transaction Type Empty");
                return;
            }

            String searchType1 = "";
            String date1;
            String date2;
            string query = "";
            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            searchType1 = searchType.SelectedItem.ToString();
            DateTime temp1 = dateTimePicker1.Value.Date;
            DateTime temp2 = dateTimePicker2.Value.Date;

            date1 = temp1.ToString("MM/dd/yyyy");
            date2 = temp2.ToString("MM/dd/yyyy");


            if (searchType1 == "All")
            {
                query = string.Format("SELECT*FROM transaction_tbl WHERE [transactionDate] BETWEEN " + "'" + date1 + "' AND " + "'" + date2 + "'");

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
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
                String query2 = "SELECT SUM (transactionAmount) FROM transaction_tbl WHERE [transactionType] = 'Deposit' AND [transactionDate] BETWEEN " + "'" + date1 + "' AND " + "'" + date2 + "'";

                try
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query2, conn);
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

                String sumWith1 = "";
                String query4 = "SELECT SUM (transactionAmount) FROM transaction_tbl WHERE [transactionType] = 'Withdraw' AND [transactionDate] BETWEEN " + "'" + date1 + "' AND " + "'" + date2 + "'";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query4, conn);
                    SqlDataReader reader1 = cmd.ExecuteReader();

                    if (reader1.Read())
                    {

                        sumWith1 = reader1[0].ToString();
                    }

                    conn.Close();
                }
                catch (SqlException exc)
                {
                    MessageBox.Show(exc.Message);
                }

                totalWithdrawOut.Text = sumWith1.ToString();
            }

            if (searchType1 == "Deposit")
            {
                query = string.Format("SELECT [transactionId],[accNumber],[accBalance],[transactionType],[transactionAmount],[transactionDate] FROM transaction_tbl WHERE [transactionType] = " + "'" + searchType1 + "'" + " AND [transactionDate] BETWEEN " + "'" + date1 + "' AND " + "'" + date2 + "'");

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
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
                string query2 = "SELECT SUM (transactionAmount) FROM transaction_tbl WHERE [transactionType] = 'Deposit' AND [transactionDate] BETWEEN " + "'" + date1 + "' AND " + "'" + date2 + "'";

                try
                {

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query2, conn);
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
            }

            if (searchType1 == "Withdraw")
            {
                query = string.Format("SELECT [transactionId],[accNumber],[accBalance],[transactionType],[transactionAmount],[transactionDate],[transactionStatus],[approvedBy] FROM transaction_tbl WHERE [transactionType] = " + "'" + searchType1 + "'" + " AND [transactionDate] BETWEEN " + "'" + date1 + "' AND " + "'" + date2 + "'");

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
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
            }

            String sumWith = "";

            string query3 = "SELECT SUM (transactionAmount) FROM transaction_tbl WHERE [transactionType] = 'Withdraw' AND [transactionDate] BETWEEN " + "'" + date1 + "' AND " + "'" + date2 + "'";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query3, conn);
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

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void searchType_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
