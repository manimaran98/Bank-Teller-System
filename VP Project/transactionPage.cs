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
    public partial class transactionPage : Form
    {
        public transactionPage()
        {
            InitializeComponent();
        }
        
       public static double accBalance;
        private void getAccBalance()
        {
            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT accBalance FROM users WHERE [accNumber] = @accNumber";

            try
            {
                bool Found = false;
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber",accLogin.accNumber1);
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

        private void getName(ref String accName)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT name FROM users WHERE [accNumber] = @accNumber";

            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
                SqlDataReader reader1 = cmd.ExecuteReader();

                if (reader1.Read())
                {

                    accName = reader1[0].ToString();
                }

                conn.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

            private void transaction_Load(object sender, EventArgs e)
        {
            String accName = "";
            getName(ref accName);
            userNameOut.Text = accName;
            accNumberOut.Text= accLogin.accNumber1;
            getAccBalance();
            accBalanceDisp.Text = accBalance.ToString();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            userWithdraw withdraw = new userWithdraw();
            withdraw.Show();
            this.Hide();
        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            deposit deposit = new deposit();
            deposit.Show();
            this.Hide();
        }

        private void viewAccInfoBtn_Click(object sender, EventArgs e)
        {
            viewAcc viewAcc = new viewAcc();
            viewAcc.Show();
            this.Hide();
        }

        private void transHistBtn_Click(object sender, EventArgs e)
        {
            transactionHist transactionHist = new transactionHist();
            transactionHist.Show();
            this.Hide();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void withdrawApprvBtn_Click(object sender, EventArgs e)
        {
            withdrawApprv withdrawApprv = new withdrawApprv();
            withdrawApprv.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            transactionPage transactionPage = new transactionPage();
            transactionPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            this.Hide();
        }
    }
}
