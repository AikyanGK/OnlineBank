namespace LA4_Carreon
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Done = new System.Windows.Forms.Button();
            this.Withdraw = new System.Windows.Forms.Button();
            this.EnterAmount = new System.Windows.Forms.TextBox();
            this.WithdrawLabel = new System.Windows.Forms.Label();
            this.BalanceW = new System.Windows.Forms.Label();
            this.WithdrawAmountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Done);
            this.groupBox1.Controls.Add(this.Withdraw);
            this.groupBox1.Controls.Add(this.EnterAmount);
            this.groupBox1.Controls.Add(this.WithdrawLabel);
            this.groupBox1.Controls.Add(this.BalanceW);
            this.groupBox1.Controls.Add(this.WithdrawAmountLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pasay City";
            // 
            // Done
            // 
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(153, 161);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 11;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw.Location = new System.Drawing.Point(153, 132);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(75, 23);
            this.Withdraw.TabIndex = 10;
            this.Withdraw.Text = "Withdraw";
            this.Withdraw.UseVisualStyleBackColor = true;
            this.Withdraw.Click += new System.EventHandler(this.Withdraw_Click);
            // 
            // EnterAmount
            // 
            this.EnterAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterAmount.Location = new System.Drawing.Point(153, 106);
            this.EnterAmount.Multiline = true;
            this.EnterAmount.Name = "EnterAmount";
            this.EnterAmount.Size = new System.Drawing.Size(100, 20);
            this.EnterAmount.TabIndex = 9;
            this.EnterAmount.TextChanged += new System.EventHandler(this.EnterAmount_TextChanged);
            // 
            // WithdrawLabel
            // 
            this.WithdrawLabel.AutoSize = true;
            this.WithdrawLabel.BackColor = System.Drawing.SystemColors.Control;
            this.WithdrawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawLabel.Location = new System.Drawing.Point(120, 45);
            this.WithdrawLabel.Name = "WithdrawLabel";
            this.WithdrawLabel.Size = new System.Drawing.Size(88, 24);
            this.WithdrawLabel.TabIndex = 5;
            this.WithdrawLabel.Text = "Withdraw";
            // 
            // BalanceW
            // 
            this.BalanceW.AutoSize = true;
            this.BalanceW.BackColor = System.Drawing.Color.White;
            this.BalanceW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceW.Location = new System.Drawing.Point(153, 80);
            this.BalanceW.Name = "BalanceW";
            this.BalanceW.Size = new System.Drawing.Size(45, 16);
            this.BalanceW.TabIndex = 4;
            this.BalanceW.Text = "label1";
            this.BalanceW.Click += new System.EventHandler(this.BalanceW_Click_1);
            // 
            // WithdrawAmountLabel
            // 
            this.WithdrawAmountLabel.AutoSize = true;
            this.WithdrawAmountLabel.BackColor = System.Drawing.Color.White;
            this.WithdrawAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WithdrawAmountLabel.Location = new System.Drawing.Point(60, 110);
            this.WithdrawAmountLabel.Name = "WithdrawAmountLabel";
            this.WithdrawAmountLabel.Size = new System.Drawing.Size(87, 16);
            this.WithdrawAmountLabel.TabIndex = 2;
            this.WithdrawAmountLabel.Text = "Enter Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(358, 239);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adamson University";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label WithdrawAmountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BalanceW;
        private System.Windows.Forms.Label WithdrawLabel;
        private System.Windows.Forms.TextBox EnterAmount;
        private System.Windows.Forms.Button Withdraw;
        private System.Windows.Forms.Button Done;
    }
}