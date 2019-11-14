namespace LA4_Carreon
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.GroupBoxForm2 = new System.Windows.Forms.GroupBox();
            this.LogOut = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.Balance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBoxForm2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxForm2
            // 
            this.GroupBoxForm2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxForm2.Controls.Add(this.LogOut);
            this.GroupBoxForm2.Controls.Add(this.Deposit);
            this.GroupBoxForm2.Controls.Add(this.Withdraw);
            this.GroupBoxForm2.Controls.Add(this.Balance);
            this.GroupBoxForm2.Controls.Add(this.label2);
            this.GroupBoxForm2.Controls.Add(this.label1);
            this.GroupBoxForm2.Font = new System.Drawing.Font("Constantia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxForm2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.GroupBoxForm2.Location = new System.Drawing.Point(39, 24);
            this.GroupBoxForm2.Name = "GroupBoxForm2";
            this.GroupBoxForm2.Size = new System.Drawing.Size(412, 258);
            this.GroupBoxForm2.TabIndex = 0;
            this.GroupBoxForm2.TabStop = false;
            this.GroupBoxForm2.Text = "Pasay City";
            // 
            // LogOut
            // 
            this.LogOut.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOut.Location = new System.Drawing.Point(144, 218);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(123, 23);
            this.LogOut.TabIndex = 5;
            this.LogOut.Text = "Log Out";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Deposit
            // 
            this.Deposit.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit.Location = new System.Drawing.Point(144, 189);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(123, 23);
            this.Deposit.TabIndex = 4;
            this.Deposit.Text = "Deposit Cash";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw.Location = new System.Drawing.Point(144, 160);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(123, 23);
            this.Withdraw.TabIndex = 3;
            this.Withdraw.Text = "Withdraw Cash";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // Balance
            // 
            this.Balance.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balance.Location = new System.Drawing.Point(144, 131);
            this.Balance.Name = "Balance";
            this.Balance.Size = new System.Drawing.Size(123, 23);
            this.Balance.TabIndex = 2;
            this.Balance.Text = "Check Balance";
            this.Balance.UseVisualStyleBackColor = true;
            this.Balance.Click += new System.EventHandler(this.Balance_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(88, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Back";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(485, 294);
            this.Controls.Add(this.GroupBoxForm2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adamson University";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.GroupBoxForm2.ResumeLayout(false);
            this.GroupBoxForm2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxForm2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Button Balance;
        private System.Windows.Forms.Button LogOut;
    }
}