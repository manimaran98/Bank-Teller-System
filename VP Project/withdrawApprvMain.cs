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
    public partial class withdrawApprvMain : Form
    {
        SqlDataAdapter sda;
        DataTable dt;
        public withdrawApprvMain()
        {
            InitializeComponent();
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            String temp = "";

            if (viewBy.Text == "")
            {
                MessageBox.Show("Cannot Leave the Option Empty");
                return;
            }

            String withdrawStatus1 = "";
            string query = "";
            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);

           withdrawStatus1 = viewBy.SelectedItem.ToString();

            if (withdrawStatus1=="All")
            {
                query = string.Format("SELECT [validationId],[staffId],[accNumber],[accBalance],[withdrawAmount],[serviceCharge],[withdrawStatus],[approval] FROM staffValidation_tbl");
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
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

            else if (withdrawStatus1 == "Approved" || withdrawStatus1 == "Declined" || withdrawStatus1 == "Validating")
            {
                query = string.Format("SELECT [validationId],[staffId],[accNumber],[accBalance],[withdrawAmount],[serviceCharge],[withdrawStatus],[approval] FROM staffValidation_tbl WHERE [withdrawStatus] = "+"'"+withdrawStatus1+"'");
                
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@accNumber", accLogin.accNumber1);
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
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void viewBy_KeyPress(object sender, KeyPressEventArgs e)
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
