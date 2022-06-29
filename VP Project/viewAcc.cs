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
    public partial class viewAcc : Form
    {
        public viewAcc()
        {
            InitializeComponent();
        }

        private void getAccinfo()
        {
            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT [name],[icNum],[address],[branchName],[accType],[accNumber],[accBalance] FROM users WHERE [accNumber] = @accNumber";

            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
                SqlDataReader reader1 = cmd.ExecuteReader();

                if (reader1.Read())
                {

                    nameOut.Text = reader1[0].ToString();
                    icNumOut.Text = reader1[1].ToString();
                    addressOut.Text = reader1[2].ToString();
                    branchNameOut.Text = reader1[3].ToString();
                    accTypeOut.Text = reader1[4].ToString();
                    accountNumberOut.Text = reader1[5].ToString();
                   accBalanceOut.Text = reader1[6].ToString();
                }

                conn.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void viewAcc_Load(object sender, EventArgs e)
        {
            getAccinfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transactionPage transactionPage = new transactionPage();
            transactionPage.Show();
            this.Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            String name = nameOut.Text;
            String icNum = icNumOut.Text;
            String address = addressOut.Text;
            String branchName = branchNameOut.Text;
            String accType = accTypeOut.Text;
            String accBalance = accBalanceOut.Text;


            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "UPDATE users SET [name] = @name,[icNum] = @icNum,[address] = @address,[branchName] = @branchName,[accType] = @accType,[accBalance] = @accBalance WHERE [accNumber] = @accNumber";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
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

            MessageBox.Show("Bank Account Data Have Been Updated");
        }
    }
}
