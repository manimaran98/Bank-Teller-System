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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        public static String staffId2;

        private void getInfo(ref String staffUsername,ref String staffPassword1)
        {
            staffUsername = staffIdInput.Text;
            staffPassword1 = passwordInput.Text;
        }

        private void validateAccLogin()
        {
            String staffUsername = "";
            String staffPassword1 = "";
            getInfo(ref staffUsername, ref staffPassword1);

            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT [staffId],[staffPassword] FROM staff_tbl WHERE [staffId] = @staffId AND [staffPassword] = @staffPassword";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@staffId", staffUsername);
                cmd.Parameters.AddWithValue("@staffPassword", staffPassword1);
                staffId2 = staffUsername;
                SqlDataReader reader1 = cmd.ExecuteReader();

                if (reader1.HasRows)
                {
                    staffPage staffPage = new staffPage();
                    staffPage.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Error Login");
                }
                conn.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            transactionPage transactionPage = new transactionPage();
            transactionPage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validateAccLogin();
        }
    }
}
