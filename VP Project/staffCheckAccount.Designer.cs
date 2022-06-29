
namespace VP_Project
{
    partial class staffCheckAccount
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
            this.accNumInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.uptBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dispAccBal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dispAccType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dispBranch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dispAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dispIc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dispName = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxDura = new System.Windows.Forms.ComboBox();
            this.comboBoxTrans = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.totalWithdrawOut = new System.Windows.Forms.Label();
            this.totalDepositOut = new System.Windows.Forms.Label();
            this.clearBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(590, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Details";
            // 
            // accNumInput
            // 
            this.accNumInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accNumInput.Location = new System.Drawing.Point(456, 81);
            this.accNumInput.Name = "accNumInput";
            this.accNumInput.Size = new System.Drawing.Size(303, 38);
            this.accNumInput.TabIndex = 1;
            this.accNumInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accNumInput_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Number :";
            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.Color.White;
            this.submitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitBtn.Location = new System.Drawing.Point(788, 81);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(104, 38);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // uptBtn
            // 
            this.uptBtn.BackColor = System.Drawing.Color.White;
            this.uptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uptBtn.Location = new System.Drawing.Point(908, 81);
            this.uptBtn.Name = "uptBtn";
            this.uptBtn.Size = new System.Drawing.Size(104, 38);
            this.uptBtn.TabIndex = 4;
            this.uptBtn.Text = "Update";
            this.uptBtn.UseVisualStyleBackColor = false;
            this.uptBtn.Click += new System.EventHandler(this.uptBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.White;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(1027, 81);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(104, 38);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dispAccBal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dispAccType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dispBranch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dispAddress);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dispIc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dispName);
            this.panel1.Location = new System.Drawing.Point(17, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 371);
            this.panel1.TabIndex = 6;
            // 
            // dispAccBal
            // 
            this.dispAccBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispAccBal.Location = new System.Drawing.Point(192, 324);
            this.dispAccBal.Name = "dispAccBal";
            this.dispAccBal.Size = new System.Drawing.Size(213, 29);
            this.dispAccBal.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "Account Balance :";
            // 
            // dispAccType
            // 
            this.dispAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispAccType.Location = new System.Drawing.Point(192, 282);
            this.dispAccType.Name = "dispAccType";
            this.dispAccType.Size = new System.Drawing.Size(213, 29);
            this.dispAccType.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Account Type :";
            // 
            // dispBranch
            // 
            this.dispBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispBranch.Location = new System.Drawing.Point(192, 242);
            this.dispBranch.Name = "dispBranch";
            this.dispBranch.Size = new System.Drawing.Size(213, 29);
            this.dispBranch.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Branch Name :";
            // 
            // dispAddress
            // 
            this.dispAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispAddress.Location = new System.Drawing.Point(192, 97);
            this.dispAddress.Name = "dispAddress";
            this.dispAddress.Size = new System.Drawing.Size(213, 127);
            this.dispAddress.TabIndex = 8;
            this.dispAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address :";
            // 
            // dispIc
            // 
            this.dispIc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispIc.Location = new System.Drawing.Point(192, 54);
            this.dispIc.Name = "dispIc";
            this.dispIc.Size = new System.Drawing.Size(213, 29);
            this.dispIc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "IC Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name :";
            // 
            // dispName
            // 
            this.dispName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispName.Location = new System.Drawing.Point(192, 19);
            this.dispName.Name = "dispName";
            this.dispName.Size = new System.Drawing.Size(213, 29);
            this.dispName.TabIndex = 3;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(1146, 81);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(104, 38);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(469, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(907, 371);
            this.dataGridView1.TabIndex = 8;
            // 
            // comboBoxDura
            // 
            this.comboBoxDura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDura.FormattingEnabled = true;
            this.comboBoxDura.Items.AddRange(new object[] {
            "1  Month",
            "2  Month",
            "3  Month",
            "4  Month",
            "5  Month",
            "6  Month",
            "7  Month",
            "8  Month",
            "9  Month",
            "10 Month",
            "11 Month",
            "12 Month"});
            this.comboBoxDura.Location = new System.Drawing.Point(1179, 148);
            this.comboBoxDura.Name = "comboBoxDura";
            this.comboBoxDura.Size = new System.Drawing.Size(198, 39);
            this.comboBoxDura.TabIndex = 9;
            this.comboBoxDura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxDura_KeyPress);
            // 
            // comboBoxTrans
            // 
            this.comboBoxTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTrans.FormattingEnabled = true;
            this.comboBoxTrans.Items.AddRange(new object[] {
            "All",
            "Deposit",
            "Withdraw"});
            this.comboBoxTrans.Location = new System.Drawing.Point(749, 148);
            this.comboBoxTrans.Name = "comboBoxTrans";
            this.comboBoxTrans.Size = new System.Drawing.Size(198, 39);
            this.comboBoxTrans.TabIndex = 10;
            this.comboBoxTrans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxTrans_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(452, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 31);
            this.label9.TabIndex = 11;
            this.label9.Text = "Type of Transaction :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1031, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 31);
            this.label10.TabIndex = 12;
            this.label10.Text = "Duration :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(443, 582);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 31);
            this.label11.TabIndex = 13;
            this.label11.Text = "Total Withdrawal :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(926, 582);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(205, 31);
            this.label12.TabIndex = 14;
            this.label12.Text = "Total Deposit :";
            // 
            // totalWithdrawOut
            // 
            this.totalWithdrawOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalWithdrawOut.Location = new System.Drawing.Point(698, 582);
            this.totalWithdrawOut.Name = "totalWithdrawOut";
            this.totalWithdrawOut.Size = new System.Drawing.Size(232, 31);
            this.totalWithdrawOut.TabIndex = 15;
            // 
            // totalDepositOut
            // 
            this.totalDepositOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalDepositOut.Location = new System.Drawing.Point(1128, 582);
            this.totalDepositOut.Name = "totalDepositOut";
            this.totalDepositOut.Size = new System.Drawing.Size(239, 31);
            this.totalDepositOut.TabIndex = 16;
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(1263, 81);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(104, 38);
            this.clearBtn.TabIndex = 17;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // staffCheckAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1388, 622);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.totalDepositOut);
            this.Controls.Add(this.totalWithdrawOut);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxTrans);
            this.Controls.Add(this.comboBoxDura);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.uptBtn);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accNumInput);
            this.Controls.Add(this.label1);
            this.Name = "staffCheckAccount";
            this.Text = "Account Details";
            this.Load += new System.EventHandler(this.staffCheckAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accNumInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button uptBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dispBranch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox dispAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dispIc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dispName;
        private System.Windows.Forms.TextBox dispAccBal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dispAccType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxDura;
        private System.Windows.Forms.ComboBox comboBoxTrans;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label totalWithdrawOut;
        private System.Windows.Forms.Label totalDepositOut;
        private System.Windows.Forms.Button clearBtn;
    }
}