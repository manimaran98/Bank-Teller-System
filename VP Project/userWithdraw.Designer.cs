
namespace VP_Project
{
    partial class userWithdraw
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
            this.submitBtn = new System.Windows.Forms.Button();
            this.accountBalDisp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backBtn = new System.Windows.Forms.Button();
            this.withdrawalInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.msgOutput = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewWithdrawTimes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.White;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(493, 498);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(126, 71);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // accountBalDisp
            // 
            this.accountBalDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountBalDisp.Location = new System.Drawing.Point(280, 42);
            this.accountBalDisp.Name = "accountBalDisp";
            this.accountBalDisp.Size = new System.Drawing.Size(280, 31);
            this.accountBalDisp.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Account Balance :";
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(330, 498);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(126, 71);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // withdrawalInput
            // 
            this.withdrawalInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withdrawalInput.Location = new System.Drawing.Point(324, 433);
            this.withdrawalInput.Name = "withdrawalInput";
            this.withdrawalInput.Size = new System.Drawing.Size(295, 38);
            this.withdrawalInput.TabIndex = 9;
            this.withdrawalInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.withdrawalInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Withdrawal Amount :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Withdrawal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Message :";
            // 
            // msgOutput
            // 
            this.msgOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgOutput.Location = new System.Drawing.Point(272, 197);
            this.msgOutput.Name = "msgOutput";
            this.msgOutput.Size = new System.Drawing.Size(288, 87);
            this.msgOutput.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.viewWithdrawTimes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.msgOutput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.accountBalDisp);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(26, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 296);
            this.panel1.TabIndex = 17;
            // 
            // viewWithdrawTimes
            // 
            this.viewWithdrawTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewWithdrawTimes.Location = new System.Drawing.Point(280, 123);
            this.viewWithdrawTimes.Name = "viewWithdrawTimes";
            this.viewWithdrawTimes.Size = new System.Drawing.Size(148, 31);
            this.viewWithdrawTimes.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(93, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 100);
            this.label5.TabIndex = 17;
            this.label5.Text = "Number of Withdrawal :";
            // 
            // userWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(656, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.withdrawalInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "userWithdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.userWithdraw_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label accountBalDisp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox withdrawalInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label msgOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label viewWithdrawTimes;
    }
}