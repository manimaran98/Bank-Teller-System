
namespace VP_Project
{
    partial class openAcc
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputIc = new System.Windows.Forms.TextBox();
            this.inputAddress = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputAccType = new System.Windows.Forms.ComboBox();
            this.inputBranch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.openAccBtn2 = new System.Windows.Forms.Button();
            this.outputMsg = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(213, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opening Bank Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(345, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NRIC Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address:";
            // 
            // inputName
            // 
            this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputName.Location = new System.Drawing.Point(132, 90);
            this.inputName.Margin = new System.Windows.Forms.Padding(2);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(195, 24);
            this.inputName.TabIndex = 4;
            // 
            // inputIc
            // 
            this.inputIc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputIc.Location = new System.Drawing.Point(473, 90);
            this.inputIc.Margin = new System.Windows.Forms.Padding(2);
            this.inputIc.Name = "inputIc";
            this.inputIc.Size = new System.Drawing.Size(195, 24);
            this.inputIc.TabIndex = 5;
            this.inputIc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputIc_KeyPress);
            // 
            // inputAddress
            // 
            this.inputAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAddress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inputAddress.Location = new System.Drawing.Point(132, 152);
            this.inputAddress.Margin = new System.Windows.Forms.Padding(2);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(195, 97);
            this.inputAddress.TabIndex = 6;
            this.inputAddress.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Account Type :";
            // 
            // inputAccType
            // 
            this.inputAccType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputAccType.FormattingEnabled = true;
            this.inputAccType.Items.AddRange(new object[] {
            "Normal Savings Account",
            "Premium Savings Account",
            "Current Account"});
            this.inputAccType.Location = new System.Drawing.Point(473, 205);
            this.inputAccType.Margin = new System.Windows.Forms.Padding(2);
            this.inputAccType.Name = "inputAccType";
            this.inputAccType.Size = new System.Drawing.Size(195, 25);
            this.inputAccType.TabIndex = 8;
            this.inputAccType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputAccType_KeyPress);
            // 
            // inputBranch
            // 
            this.inputBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBranch.FormattingEnabled = true;
            this.inputBranch.Items.AddRange(new object[] {
            "1st Branch",
            "2nd Branch",
            "3rd Branch",
            "4th Branch"});
            this.inputBranch.Location = new System.Drawing.Point(473, 148);
            this.inputBranch.Margin = new System.Windows.Forms.Padding(2);
            this.inputBranch.Name = "inputBranch";
            this.inputBranch.Size = new System.Drawing.Size(195, 25);
            this.inputBranch.TabIndex = 10;
            this.inputBranch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputBranch_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(345, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Branch :";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(452, 344);
            this.clear.Margin = new System.Windows.Forms.Padding(2);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(103, 39);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // openAccBtn2
            // 
            this.openAccBtn2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.openAccBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAccBtn2.Location = new System.Drawing.Point(565, 344);
            this.openAccBtn2.Margin = new System.Windows.Forms.Padding(2);
            this.openAccBtn2.Name = "openAccBtn2";
            this.openAccBtn2.Size = new System.Drawing.Size(103, 39);
            this.openAccBtn2.TabIndex = 12;
            this.openAccBtn2.Text = "Open Account";
            this.openAccBtn2.UseVisualStyleBackColor = false;
            this.openAccBtn2.Click += new System.EventHandler(this.openAccBtn2_Click);
            // 
            // outputMsg
            // 
            this.outputMsg.BackColor = System.Drawing.Color.White;
            this.outputMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMsg.Location = new System.Drawing.Point(132, 263);
            this.outputMsg.Name = "outputMsg";
            this.outputMsg.Size = new System.Drawing.Size(536, 65);
            this.outputMsg.TabIndex = 13;
            this.outputMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 284);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Message:";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.WhiteSmoke;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(335, 344);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(103, 39);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // openAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(676, 402);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.outputMsg);
            this.Controls.Add(this.openAccBtn2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.inputBranch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputAccType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputAddress);
            this.Controls.Add(this.inputIc);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "openAcc";
            this.Text = "Open Bank Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputIc;
        private System.Windows.Forms.RichTextBox inputAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox inputAccType;
        private System.Windows.Forms.ComboBox inputBranch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button openAccBtn2;
        private System.Windows.Forms.Label outputMsg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button back;
    }
}