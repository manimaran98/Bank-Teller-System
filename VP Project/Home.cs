using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void openAccBtn_Click(object sender, EventArgs e)
        {
            openAcc openAcc = new openAcc();
            openAcc.Show();
            this.Hide();
        }

        private void TransBtn_Click(object sender, EventArgs e)
        {
            accLogin accLogin = new accLogin();
            accLogin.Show();
            this.Hide();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            admin admin = new admin();
            admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            staffCheckAccount staffCheckAccount = new staffCheckAccount();
            staffCheckAccount.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            transactionHistMain transactionHistMain = new transactionHistMain();
            transactionHistMain.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            withdrawApprvMain withdrawApprvMain = new withdrawApprvMain();
            withdrawApprvMain.Show();
            this.Hide();
        }
    }
}
