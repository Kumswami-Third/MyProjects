
namespace PersonalBudgetPlanner
{
    partial class IncomeAndMonth
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
            this.txbIncome = new System.Windows.Forms.TextBox();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlIncome = new System.Windows.Forms.Panel();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbIncome
            // 
            this.txbIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbIncome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(98)))), ((int)(((byte)(81)))));
            this.txbIncome.Location = new System.Drawing.Point(198, 78);
            this.txbIncome.Name = "txbIncome";
            this.txbIncome.Size = new System.Drawing.Size(255, 18);
            this.txbIncome.TabIndex = 0;
            this.txbIncome.Text = "Income";
            this.txbIncome.TextChanged += new System.EventHandler(this.txbIncome_TextChanged);
            this.txbIncome.Enter += new System.EventHandler(this.txbIncome_Enter);
            this.txbIncome.Leave += new System.EventHandler(this.txbIncome_Leave);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(98)))), ((int)(((byte)(81)))));
            this.lblHeading.Location = new System.Drawing.Point(147, 18);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(341, 25);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Please enter your Income and Month";
            // 
            // pnlIncome
            // 
            this.pnlIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(98)))), ((int)(((byte)(81)))));
            this.pnlIncome.Location = new System.Drawing.Point(198, 100);
            this.pnlIncome.Name = "pnlIncome";
            this.pnlIncome.Size = new System.Drawing.Size(255, 1);
            this.pnlIncome.TabIndex = 2;
            // 
            // cmbMonth
            // 
            this.cmbMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMonth.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.cmbMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(98)))), ((int)(((byte)(81)))));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(258, 129);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 25);
            this.cmbMonth.TabIndex = 5;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            this.cmbMonth.Enter += new System.EventHandler(this.cmbMonth_Enter);
            this.cmbMonth.Leave += new System.EventHandler(this.cmbMonth_Leave);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(98)))), ((int)(((byte)(81)))));
            this.btnSave.Location = new System.Drawing.Point(550, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(98)))), ((int)(((byte)(81)))));
            this.lblMonth.Location = new System.Drawing.Point(198, 134);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(43, 15);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Month";
            // 
            // IncomeAndMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(668, 422);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.pnlIncome);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.txbIncome);
            this.Name = "IncomeAndMonth";
            this.Text = "IncomeAndMonth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbIncome;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel pnlIncome;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblMonth;
    }
}