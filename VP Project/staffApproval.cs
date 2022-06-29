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
    public partial class staffApproval : Form
    {
        SqlDataAdapter sda;
        DataTable dt;
        public staffApproval()
        {
            InitializeComponent();
        }

        private void fillBtn_Click(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = string.Format("SELECT [validationId],[accNumber],[accBalance],[withdrawAmount],[serviceCharge],[withdrawStatus] FROM staffValidation_tbl WHERE withdrawStatus = 'Validating' AND staffId = " + "'"+admin.staffId2+"'");

            try
            {
                conn.Open();
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (dispAccBal.Text == "" || dispWithdraw.Text == "" || dispService.Text == "" || approvalComboBox.Text == ""|| valID.Text=="")
            {
                MessageBox.Show("Cannot Leave The Fill Empty");
                return;
            }

            String withdrawStatus = approvalComboBox.SelectedItem.ToString();
            String accNumber = dispAccNum.Text;
            String validationId = valID.Text;
            double accBalance = double.Parse(dispAccBal.Text);
            double withdrawAmount = double.Parse(dispWithdraw.Text);
            double serviceCharge = double.Parse(dispService.Text);
            double newAccBalance = accBalance - withdrawAmount - serviceCharge;

            if (withdrawStatus == "Approved")
            {

                string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                string query = "UPDATE staffValidation_tbl SET [withdrawStatus] = @withdrawStatus, [accBalance] = @accBalance WHERE [accNumber] = @accNumber AND validationId = @validationId";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@withdrawStatus", withdrawStatus);
                    cmd.Parameters.AddWithValue("@accNumber", accNumber);
                    cmd.Parameters.AddWithValue("@validationId", validationId);
                    cmd.Parameters.AddWithValue("@accBalance", newAccBalance);
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
                    cmd.Parameters.AddWithValue("@accNumber", accNumber);
                    cmd.Parameters.AddWithValue("@accBalance", newAccBalance);
                    cmd.Parameters.AddWithValue("@transactionType", "Withdraw");
                    cmd.Parameters.AddWithValue("@transactionAmount", withdrawAmount);
                    cmd.Parameters.AddWithValue("@serviceCharge", serviceCharge);
                    cmd.Parameters.AddWithValue("@transactionDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@transactionStatus", withdrawStatus);
                    cmd.Parameters.AddWithValue("@approvedBy", admin.staffId2);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }

                catch (SqlException exc)
                {
                    MessageBox.Show(exc.Message);
                }

                string query3 = "UPDATE users SET [accBalance] = @deposit WHERE [accNumber] = @accNumber";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query3, conn);
                    cmd.Parameters.AddWithValue("@accNumber", accNumber);
                    cmd.Parameters.AddWithValue("@deposit", newAccBalance);
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


                MessageBox.Show("Transaction Approved");
            }

            else if (withdrawStatus == "Declined")
            {
                string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                string query = "UPDATE staffValidation_tbl SET [withdrawStatus] = @withdrawStatus, [accBalance] = @accBalance WHERE [accNumber] = @accNumber AND validationId = @validationId";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@withdrawStatus", withdrawStatus);
                    cmd.Parameters.AddWithValue("@accNumber", accNumber);
                    cmd.Parameters.AddWithValue("@validationId", validationId);
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

                MessageBox.Show("Transaction Declined");
            }

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dispAccNum.Text = dataGridView1.Rows[e.RowIndex].Cells["accNumber"].Value.ToString();
            valID.Text = dataGridView1.Rows[e.RowIndex].Cells["validationId"].Value.ToString();
            dispAccBal.Text = dataGridView1.Rows[e.RowIndex].Cells["accBalance"].Value.ToString();
            dispWithdraw.Text = dataGridView1.Rows[e.RowIndex].Cells["withdrawAmount"].Value.ToString();
            dispService.Text = dataGridView1.Rows[e.RowIndex].Cells["serviceCharge"].Value.ToString();
            approvalComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells["withdrawStatus"].Value.ToString();
            return;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            staffPage staffPage = new staffPage();
            staffPage.Show();
            this.Hide();
        }

    }
}
