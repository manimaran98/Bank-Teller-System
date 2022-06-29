
namespace VP_Project
{
    partial class staffPage
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
            this.apprvBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.staffIdOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Panel";
            // 
            // apprvBtn
            // 
            this.apprvBtn.BackColor = System.Drawing.Color.White;
            this.apprvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apprvBtn.Location = new System.Drawing.Point(193, 201);
            this.apprvBtn.Name = "apprvBtn";
            this.apprvBtn.Size = new System.Drawing.Size(171, 103);
            this.apprvBtn.TabIndex = 1;
            this.apprvBtn.Text = "Approval";
            this.apprvBtn.UseVisualStyleBackColor = false;
            this.apprvBtn.Click += new System.EventHandler(this.apprvBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.White;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(405, 201);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(171, 103);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Staff ID :";
            // 
            // staffIdOut
            // 
            this.staffIdOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffIdOut.Location = new System.Drawing.Point(301, 109);
            this.staffIdOut.Name = "staffIdOut";
            this.staffIdOut.Size = new System.Drawing.Size(393, 33);
            this.staffIdOut.TabIndex = 7;
            this.staffIdOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // staffPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(767, 345);
            this.Controls.Add(this.staffIdOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.apprvBtn);
            this.Controls.Add(this.label1);
            this.Name = "staffPage";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.staffPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apprvBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label staffIdOut;
    }
}