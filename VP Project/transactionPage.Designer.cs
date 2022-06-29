
namespace VP_Project
{
    partial class transactionPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameOut = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.accNumberOut = new System.Windows.Forms.Label();
            this.depositBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.transHistBtn = new System.Windows.Forms.Button();
            this.viewAccInfoBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.accBalanceDisp = new System.Windows.Forms.Label();
            this.withdrawApprvBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome Back";
            // 
            // userNameOut
            // 
            this.userNameOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameOut.Location = new System.Drawing.Point(324, 32);
            this.userNameOut.Name = "userNameOut";
            this.userNameOut.Size = new System.Drawing.Size(296, 31);
            this.userNameOut.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account Number :";
            // 
            // accNumberOut
            // 
            this.accNumberOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNumberOut.Location = new System.Drawing.Point(318, 99);
            this.accNumberOut.Name = "accNumberOut";
            this.accNumberOut.Size = new System.Drawing.Size(302, 31);
            this.accNumberOut.TabIndex = 4;
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.Color.White;
            this.depositBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depositBtn.Location = new System.Drawing.Point(421, 296);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(310, 56);
            this.depositBtn.TabIndex = 5;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Click += new System.EventHandler(this.depositBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.Color.White;
            this.withdrawBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawBtn.Location = new System.Drawing.Point(93, 296);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(310, 56);
            this.withdrawBtn.TabIndex = 6;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Click += new System.EventHandler(this.withdrawBtn_Click);
            // 
            // transHistBtn
            // 
            this.transHistBtn.BackColor = System.Drawing.Color.White;
            this.transHistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transHistBtn.Location = new System.Drawing.Point(421, 377);
            this.transHistBtn.Name = "transHistBtn";
            this.transHistBtn.Size = new System.Drawing.Size(310, 56);
            this.transHistBtn.TabIndex = 7;
            this.transHistBtn.Text = "Transaction History";
            this.transHistBtn.UseVisualStyleBackColor = false;
            this.transHistBtn.Click += new System.EventHandler(this.transHistBtn_Click);
            // 
            // viewAccInfoBtn
            // 
            this.viewAccInfoBtn.BackColor = System.Drawing.Color.White;
            this.viewAccInfoBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAccInfoBtn.Location = new System.Drawing.Point(93, 447);
            this.viewAccInfoBtn.Name = "viewAccInfoBtn";
            this.viewAccInfoBtn.Size = new System.Drawing.Size(310, 56);
            this.viewAccInfoBtn.TabIndex = 8;
            this.viewAccInfoBtn.Text = "View Account Information";
            this.viewAccInfoBtn.UseVisualStyleBackColor = false;
            this.viewAccInfoBtn.Click += new System.EventHandler(this.viewAccInfoBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.White;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(417, 518);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(310, 56);
            this.exitBtn.TabIndex = 9;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Account Balance :";
            // 
            // accBalanceDisp
            // 
            this.accBalanceDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accBalanceDisp.Location = new System.Drawing.Point(318, 158);
            this.accBalanceDisp.Name = "accBalanceDisp";
            this.accBalanceDisp.Size = new System.Drawing.Size(302, 31);
            this.accBalanceDisp.TabIndex = 11;
            // 
            // withdrawApprvBtn
            // 
            this.withdrawApprvBtn.BackColor = System.Drawing.Color.White;
            this.withdrawApprvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawApprvBtn.Location = new System.Drawing.Point(93, 377);
            this.withdrawApprvBtn.Name = "withdrawApprvBtn";
            this.withdrawApprvBtn.Size = new System.Drawing.Size(310, 56);
            this.withdrawApprvBtn.TabIndex = 12;
            this.withdrawApprvBtn.Text = "Withdrawal Approval";
            this.withdrawApprvBtn.UseVisualStyleBackColor = false;
            this.withdrawApprvBtn.Click += new System.EventHandler(this.withdrawApprvBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.accBalanceDisp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.accNumberOut);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.userNameOut);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(93, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 218);
            this.panel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(93, 518);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(310, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(417, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(310, 54);
            this.button2.TabIndex = 15;
            this.button2.Text = "Staff Login";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // transactionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.withdrawApprvBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.viewAccInfoBtn);
            this.Controls.Add(this.transHistBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.label1);
            this.Name = "transactionPage";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.transaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userNameOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label accNumberOut;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button transHistBtn;
        private System.Windows.Forms.Button viewAccInfoBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label accBalanceDisp;
        private System.Windows.Forms.Button withdrawApprvBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}