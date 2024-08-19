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
            this.UI_Btn_Deposit = new System.Windows.Forms.Button();
            this.UI_Btn_WIthdraw = new System.Windows.Forms.Button();
            this.UI_TxtBox_Amount = new System.Windows.Forms.TextBox();
            this.UI_DropDown_Currencies = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_Lbl_Amount = new System.Windows.Forms.Label();
            this.UI_Lbl_Balance = new System.Windows.Forms.Label();
            this.UI_TxtBox_Balance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UI_DropDown_AccountNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Btn_Deposit
            // 
            this.UI_Btn_Deposit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_Btn_Deposit.Location = new System.Drawing.Point(75, 165);
            this.UI_Btn_Deposit.Name = "UI_Btn_Deposit";
            this.UI_Btn_Deposit.Size = new System.Drawing.Size(163, 47);
            this.UI_Btn_Deposit.TabIndex = 0;
            this.UI_Btn_Deposit.Text = "Deposit";
            this.UI_Btn_Deposit.UseVisualStyleBackColor = true;
            this.UI_Btn_Deposit.Click += new System.EventHandler(this.UI_Btn_Deposit_Click);
            // 
            // UI_Btn_WIthdraw
            // 
            this.UI_Btn_WIthdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Btn_WIthdraw.Location = new System.Drawing.Point(440, 165);
            this.UI_Btn_WIthdraw.Name = "UI_Btn_WIthdraw";
            this.UI_Btn_WIthdraw.Size = new System.Drawing.Size(163, 47);
            this.UI_Btn_WIthdraw.TabIndex = 1;
            this.UI_Btn_WIthdraw.Text = "Withdraw";
            this.UI_Btn_WIthdraw.UseVisualStyleBackColor = true;
            this.UI_Btn_WIthdraw.Click += new System.EventHandler(this.UI_Btn_WIthdraw_Click);
            // 
            // UI_TxtBox_Amount
            // 
            this.UI_TxtBox_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_TxtBox_Amount.Font = new System.Drawing.Font("Calibri", 12F);
            this.UI_TxtBox_Amount.Location = new System.Drawing.Point(167, 48);
            this.UI_TxtBox_Amount.Name = "UI_TxtBox_Amount";
            this.UI_TxtBox_Amount.Size = new System.Drawing.Size(308, 32);
            this.UI_TxtBox_Amount.TabIndex = 2;
            // 
            // UI_DropDown_Currencies
            // 
            this.UI_DropDown_Currencies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_DropDown_Currencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UI_DropDown_Currencies.Font = new System.Drawing.Font("Calibri", 12F);
            this.UI_DropDown_Currencies.FormattingEnabled = true;
            this.UI_DropDown_Currencies.Items.AddRange(new object[] {
            "CAD",
            "USD",
            "MXN",
            "EURO"});
            this.UI_DropDown_Currencies.Location = new System.Drawing.Point(494, 48);
            this.UI_DropDown_Currencies.Name = "UI_DropDown_Currencies";
            this.UI_DropDown_Currencies.Size = new System.Drawing.Size(101, 32);
            this.UI_DropDown_Currencies.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.UI_Lbl_Amount);
            this.groupBox1.Controls.Add(this.UI_Btn_Deposit);
            this.groupBox1.Controls.Add(this.UI_TxtBox_Amount);
            this.groupBox1.Controls.Add(this.UI_DropDown_Currencies);
            this.groupBox1.Controls.Add(this.UI_Btn_WIthdraw);
            this.groupBox1.Location = new System.Drawing.Point(16, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 291);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // UI_Lbl_Amount
            // 
            this.UI_Lbl_Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_Lbl_Amount.AutoSize = true;
            this.UI_Lbl_Amount.Font = new System.Drawing.Font("Calibri", 12F);
            this.UI_Lbl_Amount.Location = new System.Drawing.Point(71, 51);
            this.UI_Lbl_Amount.Name = "UI_Lbl_Amount";
            this.UI_Lbl_Amount.Size = new System.Drawing.Size(88, 24);
            this.UI_Lbl_Amount.TabIndex = 4;
            this.UI_Lbl_Amount.Text = "Amount :";
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
            // UI_TxtBox_Balance
            // 
            this.UI_TxtBox_Balance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_TxtBox_Balance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TxtBox_Balance.Location = new System.Drawing.Point(415, 65);
            this.UI_TxtBox_Balance.Name = "UI_TxtBox_Balance";
            this.UI_TxtBox_Balance.ReadOnly = true;
            this.UI_TxtBox_Balance.Size = new System.Drawing.Size(204, 32);
            this.UI_TxtBox_Balance.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome, John Doe!";
            // 
            // UI_DropDown_AccountNum
            // 
            this.UI_DropDown_AccountNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_DropDown_AccountNum.Font = new System.Drawing.Font("Calibri", 12F);
            this.UI_DropDown_AccountNum.Items.AddRange(new object[] {
            "4536",
            "3421",
            "6577"});
            this.UI_DropDown_AccountNum.Location = new System.Drawing.Point(415, 12);
            this.UI_DropDown_AccountNum.Name = "UI_DropDown_AccountNum";
            this.UI_DropDown_AccountNum.Size = new System.Drawing.Size(170, 32);
            this.UI_DropDown_AccountNum.TabIndex = 8;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UI_DropDown_AccountNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Lbl_Balance);
            this.Controls.Add(this.UI_TxtBox_Balance);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(556, 397);
            this.Name = "Form1";
            this.Text = "Banking App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Btn_Deposit;
        private System.Windows.Forms.Button UI_Btn_WIthdraw;
        private System.Windows.Forms.TextBox UI_TxtBox_Amount;
        private System.Windows.Forms.ComboBox UI_DropDown_Currencies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label UI_Lbl_Amount;
        private System.Windows.Forms.Label UI_Lbl_Balance;
        private System.Windows.Forms.TextBox UI_TxtBox_Balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UI_DropDown_AccountNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

