using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Numerics;
using Microsoft.VisualBasic;

namespace VP_Project
{
    public partial class openAcc : Form
    {
        public openAcc()
        {
            InitializeComponent();
        }
        public static String accType1;
        public static String accNumber1;

        private void getPersonalInformation(ref String name,ref String ic, ref String address, ref String accType, ref String branchName)
        {
            
            name = inputName.Text;
            ic = inputIc.Text;
            address = inputAddress.Text;
            accType = inputAccType.Text;
            branchName = inputBranch.Text;
        }

        private void getInfo(ref String accType,ref String branchNumber)
        {
            String input1 = inputAccType.Text;

            if (input1 == "Normal Savings Account")
            {
                accType = "01";
            }

            if (input1 == "Premium Savings Account")
            {
                accType = "02";
            }

            if (input1 == "Current Account")
            {
                accType = "03";
            }

            String input2 = inputBranch.Text;

            if (input2 == "1st Branch")
            {
                branchNumber = "001";
            }

            if (input2 == "2nd Branch")
            {
                branchNumber = "002";
            }

            if (input2 == "3rd Branch")
            {
                branchNumber = "003";
            }

            if (input2 == "4th Branch")
            {
                branchNumber = "004";
            }

        }

        private void generateRunNum(ref String runningNumber)
        {
            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT  MAX(CAST(SUBSTRING(accNumber, 6, 7) AS INT)) FROM users WHERE [branchName] = @branchName";

            String accType, branchNumber = "";
            accType = branchNumber;
            int maxRunningNumber=0;
            int tempNumber = 0;
            getInfo(ref accType,ref branchNumber);

            try
            {
                bool Found = false;
                conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@branchName",inputBranch.SelectedItem.ToString());
            SqlDataReader reader1 = cmd.ExecuteReader();

            if (reader1.Read())
            {

                    String temp = reader1[0].ToString();
                if (temp == "")
                {
                    tempNumber = 1;
                }

                else
                {
                    maxRunningNumber = int.Parse(temp);
                    tempNumber = maxRunningNumber + 1;
                    
                }    
            }

            runningNumber = tempNumber.ToString().PadLeft(7, '0');

                conn.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void genSecretNum(ref String secNum)
        {
            String accType, branchNumber = "";
            accType = branchNumber;
            getInfo(ref accType, ref branchNumber);

            String runningNumber = "";
            generateRunNum(ref runningNumber);
            

            string accType1 = accType.ToString().PadLeft(2, '0');
            string branchNumber1 = branchNumber.ToString().PadLeft(3, '0');

            String tempNum = accType1 + branchNumber1 + runningNumber;
            int len = tempNum.Length;

            double sum = 0;
            int temp = 0;
            double x = 0;
            int tempValue = 0;


            for (int i = 0; i < len; i++)
            {
                    String totalString = tempNum.Substring(i, 1);
                    tempValue = int.Parse(totalString) + 3;
                    sum = Math.Pow(tempValue, tempValue);


                x = x + sum;
                temp++;
               
            }

            BigInteger y = (BigInteger)(x*x);
            String num = y.ToString();
             secNum = num.Substring(num.Length - 3);


        }

        private void genAccNumber(ref String accNumber)
        {
            String accType, branchNumber;
            accType = branchNumber = "";
            getInfo(ref accType, ref branchNumber);

            String runningNumber;
            runningNumber = "";
            generateRunNum(ref runningNumber);

            String secNum;
            secNum = "";
            genSecretNum(ref secNum);

            accNumber = accType + branchNumber + runningNumber + secNum;
        }

        private void openAccBtn2_Click(object sender, EventArgs e)
        {
            string error = "";
            inputValidation(ref error);

            if (error != "")
            {
                return;
            }

            else
            {

                String accNumber = "";
                genAccNumber(ref accNumber);

                String name, ic, address, accType, branchName;
                name = ic = address = accType = branchName = "";
                getPersonalInformation(ref name, ref ic, ref address, ref accType, ref branchName);

                string message = accNumber;
                MessageBox.Show("Your Account Number is " + message);

                int minDeposit = 0;

                string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
                SqlConnection conn = new SqlConnection(connString);
                string query = "INSERT INTO users VALUES (@name, @icNum, @address, @branchName, @accType, @accNumber, @accBalance)";

                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@icNum", ic);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@branchName", branchName);
                    cmd.Parameters.AddWithValue("@accType", accType);
                    cmd.Parameters.AddWithValue("@accNumber", accNumber);
                    cmd.Parameters.AddWithValue("@accBalance", minDeposit);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Bank Account Have Been Created for Confirmation Please Deposit");
                    conn.Close();
                }

                catch (SqlException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                accType1 = accType;
                accNumber1 = accNumber;
                this.Hide();
                openAccDeposit openAccDeposit = new openAccDeposit();
                openAccDeposit.Show();

            }
        }

        private void inputIc_KeyPress(object sender, KeyPressEventArgs e)
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

        private void inputValidation(ref string error)
        {
            String userName = inputName.Text;
            String userAddress = inputAddress.Text;
            String userIc = inputIc.Text;
            String userBranch = inputBranch.Text;
            String userAccType = inputAccType.Text;

            if (userName=="")
            {
                error  = "You Cannot Leave the Fill Empty";
                outputMsg.Text = error;
                return;
            }

            if (userAddress == "")
            {
                error = "You Cannot Leave the Fill Empty";
                outputMsg.Text = error;
                return;
            }

            if (userIc == "")
            {
                error = "You Cannot Leave the Fill Empty";
                outputMsg.Text = error;
                return;
            }

            if (userIc.Length < 12 || userIc.Length >12)
            {
                error = "Invalid IC Number Please Try Again";
                outputMsg.Text = error;
                return;
            }

            if (userBranch == "")
            {
                error = "You Cannot Leave the Fill Empty";
                outputMsg.Text = error;
                return;
            }

            if (userAccType == "")
            {
                error = "You Cannot Leave the Fill Empty";
                outputMsg.Text = error;
                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["dbMoneyBank"].ConnectionString;
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT icNum FROM users WHERE [icNum] = @icNum";

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@icNum", userIc);
                SqlDataReader reader1 = cmd.ExecuteReader();

                if (reader1.HasRows)
                {
                    error = "IC Number Already Existed";
                    outputMsg.Text = error;
                    return;
                }

                conn.Close();
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputName.Text = "";
            inputAddress.Text = "";
            inputIc.Text = "";
            inputBranch.Text = "";
            inputAccType.Text = "";
        }

        private void inputBranch_KeyPress(object sender, KeyPressEventArgs e)
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

        private void inputAccType_KeyPress(object sender, KeyPressEventArgs e)
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

        private void back_Click(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }
    }
}
