namespace LA4_Carreon
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Done = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.EnterAmount = new System.Windows.Forms.TextBox();
            this.BalanceD = new System.Windows.Forms.Label();
            this.DepositAmountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DepositLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Done);
            this.groupBox1.Controls.Add(this.Deposit);
            this.groupBox1.Controls.Add(this.EnterAmount);
            this.groupBox1.Controls.Add(this.BalanceD);
            this.groupBox1.Controls.Add(this.DepositAmountLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DepositLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adamson University";
            // 
            // Done
            // 
            this.Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done.Location = new System.Drawing.Point(153, 161);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(75, 23);
            this.Done.TabIndex = 17;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click_1);
            // 
            // Deposit
            // 
            this.Deposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit.Location = new System.Drawing.Point(153, 132);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(75, 23);
            this.Deposit.TabIndex = 16;
            this.Deposit.Text = "Deposit";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click_1);
            // 
            // EnterAmount
            // 
            this.EnterAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterAmount.Location = new System.Drawing.Point(153, 106);
            this.EnterAmount.Multiline = true;
            this.EnterAmount.Name = "EnterAmount";
            this.EnterAmount.Size = new System.Drawing.Size(100, 20);
            this.EnterAmount.TabIndex = 15;
            this.EnterAmount.TextChanged += new System.EventHandler(this.EnterAmount_TextChanged_1);
            // 
            // BalanceD
            // 
            this.BalanceD.AutoSize = true;
            this.BalanceD.BackColor = System.Drawing.SystemColors.Control;
            this.BalanceD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceD.Location = new System.Drawing.Point(153, 80);
            this.BalanceD.Name = "BalanceD";
            this.BalanceD.Size = new System.Drawing.Size(45, 16);
            this.BalanceD.TabIndex = 14;
            this.BalanceD.Text = "label1";
            // 
            // DepositAmountLabel
            // 
            this.DepositAmountLabel.AutoSize = true;
            this.DepositAmountLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DepositAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositAmountLabel.Location = new System.Drawing.Point(60, 110);
            this.DepositAmountLabel.Name = "DepositAmountLabel";
            this.DepositAmountLabel.Size = new System.Drawing.Size(87, 16);
            this.DepositAmountLabel.TabIndex = 13;
            this.DepositAmountLabel.Text = "Enter Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Balance";
            // 
            // DepositLabel
            // 
            this.DepositLabel.AutoSize = true;
            this.DepositLabel.BackColor = System.Drawing.SystemColors.Control;
            this.DepositLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositLabel.Location = new System.Drawing.Point(120, 45);
            this.DepositLabel.Name = "DepositLabel";
            this.DepositLabel.Size = new System.Drawing.Size(73, 24);
            this.DepositLabel.TabIndex = 6;
            this.DepositLabel.Text = "Deposit";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(358, 239);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adamson University";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label DepositLabel;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.TextBox EnterAmount;
        private System.Windows.Forms.Label BalanceD;
        private System.Windows.Forms.Label DepositAmountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Done;
    }
}