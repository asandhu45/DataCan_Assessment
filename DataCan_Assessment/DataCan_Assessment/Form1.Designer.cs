namespace DataCan_Assessment
{
    partial class Form1
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
            this.depositButton = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.currencyDropdown = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountLabel = new System.Windows.Forms.Label();
            this.UI_Lbl_Balance = new System.Windows.Forms.Label();
            this.balanceTexbox = new System.Windows.Forms.TextBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.AccountNum_DropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // depositButton
            // 
            this.depositButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.depositButton.Location = new System.Drawing.Point(75, 165);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(163, 47);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // withdrawButton
            // 
            this.withdrawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.withdrawButton.Location = new System.Drawing.Point(406, 165);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(163, 47);
            this.withdrawButton.TabIndex = 3;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // currencyDropdown
            // 
            this.currencyDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currencyDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyDropdown.Font = new System.Drawing.Font("Calibri", 12F);
            this.currencyDropdown.FormattingEnabled = true;
            this.currencyDropdown.Items.AddRange(new object[] {
            "CAD",
            "USD",
            "MXN",
            "EURO"});
            this.currencyDropdown.Location = new System.Drawing.Point(425, 49);
            this.currencyDropdown.Name = "currencyDropdown";
            this.currencyDropdown.Size = new System.Drawing.Size(101, 32);
            this.currencyDropdown.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.amountNumericUpDown);
            this.groupBox1.Controls.Add(this.amountLabel);
            this.groupBox1.Controls.Add(this.depositButton);
            this.groupBox1.Controls.Add(this.currencyDropdown);
            this.groupBox1.Controls.Add(this.withdrawButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 291);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountNumericUpDown.Font = new System.Drawing.Font("Calibri", 12F);
            this.amountNumericUpDown.Location = new System.Drawing.Point(165, 49);
            this.amountNumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(228, 32);
            this.amountNumericUpDown.TabIndex = 0;
            this.amountNumericUpDown.ThousandsSeparator = true;
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Calibri", 12F);
            this.amountLabel.Location = new System.Drawing.Point(71, 51);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(88, 24);
            this.amountLabel.TabIndex = 4;
            this.amountLabel.Text = "Amount :";
            // 
            // UI_Lbl_Balance
            // 
            this.UI_Lbl_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Lbl_Balance.AutoSize = true;
            this.UI_Lbl_Balance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Lbl_Balance.Location = new System.Drawing.Point(329, 73);
            this.UI_Lbl_Balance.Name = "UI_Lbl_Balance";
            this.UI_Lbl_Balance.Size = new System.Drawing.Size(80, 24);
            this.UI_Lbl_Balance.TabIndex = 5;
            this.UI_Lbl_Balance.Text = "Balance:";
            // 
            // balanceTexbox
            // 
            this.balanceTexbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.balanceTexbox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTexbox.Location = new System.Drawing.Point(415, 65);
            this.balanceTexbox.Name = "balanceTexbox";
            this.balanceTexbox.ReadOnly = true;
            this.balanceTexbox.Size = new System.Drawing.Size(204, 32);
            this.balanceTexbox.TabIndex = 6;
            this.balanceTexbox.TabStop = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 15);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(181, 24);
            this.welcomeLabel.TabIndex = 7;
            this.welcomeLabel.Text = "Welcome, John Doe!";
            // 
            // AccountNum_DropDown
            // 
            this.AccountNum_DropDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountNum_DropDown.Font = new System.Drawing.Font("Calibri", 12F);
            this.AccountNum_DropDown.Items.AddRange(new object[] {
            "4536",
            "3421",
            "6577"});
            this.AccountNum_DropDown.Location = new System.Drawing.Point(415, 12);
            this.AccountNum_DropDown.Name = "AccountNum_DropDown";
            this.AccountNum_DropDown.Size = new System.Drawing.Size(170, 32);
            this.AccountNum_DropDown.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Account:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(625, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "CAD";
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetButton.Location = new System.Drawing.Point(601, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(69, 32);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 430);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccountNum_DropDown);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.UI_Lbl_Balance);
            this.Controls.Add(this.balanceTexbox);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(711, 477);
            this.Name = "Form1";
            this.Text = "Banking App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.ComboBox currencyDropdown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label UI_Lbl_Balance;
        private System.Windows.Forms.TextBox balanceTexbox;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.ComboBox AccountNum_DropDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.Button resetButton;
    }
}

