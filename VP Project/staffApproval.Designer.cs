
namespace VP_Project
{
    partial class staffApproval
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
            this.components = new System.ComponentModel.Container();
            this.Staff = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dispAccNum = new System.Windows.Forms.TextBox();
            this.dispAccBal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dispWithdraw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dispService = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.approvalComboBox = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.fillBtn = new System.Windows.Forms.Button();
            this.valID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Staff
            // 
            this.Staff.AutoSize = true;
            this.Staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Staff.Location = new System.Drawing.Point(428, 21);
            this.Staff.Name = "Staff";
            this.Staff.Size = new System.Drawing.Size(211, 33);
            this.Staff.TabIndex = 0;
            this.Staff.Text = "Staff Approval";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(622, 537);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Client Account Number";
            // 
            // dispAccNum
            // 
            this.dispAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispAccNum.Location = new System.Drawing.Point(21, 101);
            this.dispAccNum.Name = "dispAccNum";
            this.dispAccNum.Size = new System.Drawing.Size(202, 29);
            this.dispAccNum.TabIndex = 3;
            // 
            // dispAccBal
            // 
            this.dispAccBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispAccBal.Location = new System.Drawing.Point(21, 171);
            this.dispAccBal.Name = "dispAccBal";
            this.dispAccBal.Size = new System.Drawing.Size(202, 29);
            this.dispAccBal.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Validation ID";
            // 
            // dispWithdraw
            // 
            this.dispWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispWithdraw.Location = new System.Drawing.Point(21, 323);
            this.dispWithdraw.Name = "dispWithdraw";
            this.dispWithdraw.Size = new System.Drawing.Size(202, 29);
            this.dispWithdraw.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Withdraw Amount";
            // 
            // dispService
            // 
            this.dispService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dispService.Location = new System.Drawing.Point(21, 401);
            this.dispService.Name = "dispService";
            this.dispService.Size = new System.Drawing.Size(202, 29);
            this.dispService.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Service Charge";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Withdraw Status";
            // 
            // approvalComboBox
            // 
            this.approvalComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approvalComboBox.FormattingEnabled = true;
            this.approvalComboBox.Items.AddRange(new object[] {
            "Validating",
            "Approved",
            "Declined"});
            this.approvalComboBox.Location = new System.Drawing.Point(21, 488);
            this.approvalComboBox.Name = "approvalComboBox";
            this.approvalComboBox.Size = new System.Drawing.Size(202, 32);
            this.approvalComboBox.TabIndex = 11;
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.White;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Location = new System.Drawing.Point(21, 537);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(98, 45);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.White;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(791, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 56);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // fillBtn
            // 
            this.fillBtn.BackColor = System.Drawing.Color.White;
            this.fillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBtn.Location = new System.Drawing.Point(125, 537);
            this.fillBtn.Name = "fillBtn";
            this.fillBtn.Size = new System.Drawing.Size(98, 45);
            this.fillBtn.TabIndex = 15;
            this.fillBtn.Text = "Fill";
            this.fillBtn.UseVisualStyleBackColor = false;
            this.fillBtn.Click += new System.EventHandler(this.fillBtn_Click);
            // 
            // valID
            // 
            this.valID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valID.Location = new System.Drawing.Point(21, 249);
            this.valID.Name = "valID";
            this.valID.Size = new System.Drawing.Size(202, 29);
            this.valID.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Accounnt Balance";
            // 
            // staffApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(878, 623);
            this.Controls.Add(this.valID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fillBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.approvalComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dispService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dispWithdraw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dispAccBal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dispAccNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Staff);
            this.Name = "staffApproval";
            this.Text = "Staff Approval";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Staff;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dispAccNum;
        private System.Windows.Forms.TextBox dispAccBal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dispWithdraw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dispService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox approvalComboBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button fillBtn;
        private System.Windows.Forms.TextBox valID;
        private System.Windows.Forms.Label label6;
    }
}