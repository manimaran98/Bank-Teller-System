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
    public partial class staffPage : Form
    {
        public staffPage()
        {
            InitializeComponent();
        }

        private void apprvBtn_Click(object sender, EventArgs e)
        {
            staffApproval staffApproval = new staffApproval();
            staffApproval.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            transactionPage transactionPage = new transactionPage();
            transactionPage.Show();
            this.Hide();
            MessageBox.Show("Transaction Status Have Been Updated");
        }

        private void staffPage_Load(object sender, EventArgs e)
        {
           staffIdOut.Text = admin.staffId2;
        }
    }
}
