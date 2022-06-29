
namespace VP_Project
{
    partial class openAccDeposit
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
            this.inputAcc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outMsg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inputDeposit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open Account Deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Number :";
            // 
            // inputAcc
            // 
            this.inputAcc.BackColor = System.Drawing.Color.White;
            this.inputAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inputAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAcc.Location = new System.Drawing.Point(277, 103);
            this.inputAcc.Name = "inputAcc";
            this.inputAcc.Size = new System.Drawing.Size(392, 65);
            this.inputAcc.TabIndex = 2;
            this.inputAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "Message :";
            // 
            // outMsg
            // 
            this.outMsg.BackColor = System.Drawing.Color.White;
            this.outMsg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.outMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outMsg.Location = new System.Drawing.Point(277, 254);
            this.outMsg.Name = "outMsg";
            this.outMsg.Size = new System.Drawing.Size(392, 65);
            this.outMsg.TabIndex = 4;
            this.outMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 33);
            this.label6.TabIndex = 5;
            this.label6.Text = "Input Deposit:";
            // 
            // inputDeposit
            // 
            this.inputDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputDeposit.Location = new System.Drawing.Point(283, 187);
            this.inputDeposit.Name = "inputDeposit";
            this.inputDeposit.Size = new System.Drawing.Size(386, 38);
            this.inputDeposit.TabIndex = 6;
            this.inputDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputDeposit_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(427, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(565, 387);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(118, 51);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // openAccDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inputDeposit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "openAccDeposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.openAccDeposit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label inputAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outMsg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputDeposit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancel;
    }
}