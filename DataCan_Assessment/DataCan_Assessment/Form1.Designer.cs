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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.UI_DropDown_Currencies = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UI_Lbl_Amount = new System.Windows.Forms.Label();
            this.UI_Lbl_Balance = new System.Windows.Forms.Label();
            this.UI_TxtBox_Balance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Btn_Deposit
            // 
            this.UI_Btn_Deposit.Location = new System.Drawing.Point(75, 119);
            this.UI_Btn_Deposit.Name = "UI_Btn_Deposit";
            this.UI_Btn_Deposit.Size = new System.Drawing.Size(163, 47);
            this.UI_Btn_Deposit.TabIndex = 0;
            this.UI_Btn_Deposit.Text = "Deposit";
            this.UI_Btn_Deposit.UseVisualStyleBackColor = true;
            this.UI_Btn_Deposit.Click += new System.EventHandler(this.UI_Btn_Deposit_Click);
            // 
            // UI_Btn_WIthdraw
            // 
            this.UI_Btn_WIthdraw.Location = new System.Drawing.Point(278, 119);
            this.UI_Btn_WIthdraw.Name = "UI_Btn_WIthdraw";
            this.UI_Btn_WIthdraw.Size = new System.Drawing.Size(162, 47);
            this.UI_Btn_WIthdraw.TabIndex = 1;
            this.UI_Btn_WIthdraw.Text = "Withdraw";
            this.UI_Btn_WIthdraw.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.textBox1.Location = new System.Drawing.Point(185, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 32);
            this.textBox1.TabIndex = 2;
            // 
            // UI_DropDown_Currencies
            // 
            this.UI_DropDown_Currencies.Font = new System.Drawing.Font("Calibri", 12F);
            this.UI_DropDown_Currencies.FormattingEnabled = true;
            this.UI_DropDown_Currencies.Items.AddRange(new object[] {
            "$ CAD",
            "$ USD",
            "$ MXN",
            "€ EURO"});
            this.UI_DropDown_Currencies.Location = new System.Drawing.Point(351, 48);
            this.UI_DropDown_Currencies.Name = "UI_DropDown_Currencies";
            this.UI_DropDown_Currencies.Size = new System.Drawing.Size(89, 32);
            this.UI_DropDown_Currencies.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.UI_Lbl_Amount);
            this.groupBox1.Controls.Add(this.UI_Btn_Deposit);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.UI_DropDown_Currencies);
            this.groupBox1.Controls.Add(this.UI_Btn_WIthdraw);
            this.groupBox1.Location = new System.Drawing.Point(16, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // UI_Lbl_Amount
            // 
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
            this.UI_Lbl_Balance.AutoSize = true;
            this.UI_Lbl_Balance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Lbl_Balance.Location = new System.Drawing.Point(274, 73);
            this.UI_Lbl_Balance.Name = "UI_Lbl_Balance";
            this.UI_Lbl_Balance.Size = new System.Drawing.Size(80, 24);
            this.UI_Lbl_Balance.TabIndex = 5;
            this.UI_Lbl_Balance.Text = "Balance:";
            // 
            // UI_TxtBox_Balance
            // 
            this.UI_TxtBox_Balance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TxtBox_Balance.Location = new System.Drawing.Point(374, 70);
            this.UI_TxtBox_Balance.Name = "UI_TxtBox_Balance";
            this.UI_TxtBox_Balance.ReadOnly = true;
            this.UI_TxtBox_Balance.Size = new System.Drawing.Size(145, 32);
            this.UI_TxtBox_Balance.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Welcome, John Doe!";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "$ CAD",
            "$ USD",
            "$ MXN",
            "€ EURO"});
            this.comboBox1.Location = new System.Drawing.Point(374, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(145, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Account:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Lbl_Balance);
            this.Controls.Add(this.UI_TxtBox_Balance);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "-";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UI_Btn_Deposit;
        private System.Windows.Forms.Button UI_Btn_WIthdraw;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox UI_DropDown_Currencies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label UI_Lbl_Amount;
        private System.Windows.Forms.Label UI_Lbl_Balance;
        private System.Windows.Forms.TextBox UI_TxtBox_Balance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}

