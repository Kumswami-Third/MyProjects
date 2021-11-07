
namespace PersonalBudgetPlanner
{
    partial class PropertyExpense
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
            this.pnlProperty = new System.Windows.Forms.Panel();
            this.rbBuy = new System.Windows.Forms.RadioButton();
            this.rbRent = new System.Windows.Forms.RadioButton();
            this.pnlMonRent = new System.Windows.Forms.Panel();
            this.txbMonRent = new System.Windows.Forms.TextBox();
            this.pnlRent = new System.Windows.Forms.Panel();
            this.pnlTotDep = new System.Windows.Forms.Panel();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.pnlPurchPrice = new System.Windows.Forms.Panel();
            this.numericUpDownInterestRate = new System.Windows.Forms.NumericUpDown();
            this.txbPurchPrice = new System.Windows.Forms.TextBox();
            this.txbTotDep = new System.Windows.Forms.TextBox();
            this.pnlBuy = new System.Windows.Forms.Panel();
            this.numericUpDownMonRepay = new System.Windows.Forms.NumericUpDown();
            this.lblMonRepay = new System.Windows.Forms.Label();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlProperty.SuspendLayout();
            this.pnlRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterestRate)).BeginInit();
            this.pnlBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonRepay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(236, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Property Expense";
            // 
            // pnlProperty
            // 
            this.pnlProperty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlProperty.Controls.Add(this.rbBuy);
            this.pnlProperty.Controls.Add(this.rbRent);
            this.pnlProperty.Location = new System.Drawing.Point(212, 55);
            this.pnlProperty.Name = "pnlProperty";
            this.pnlProperty.Size = new System.Drawing.Size(229, 50);
            this.pnlProperty.TabIndex = 1;
            // 
            // rbBuy
            // 
            this.rbBuy.AutoSize = true;
            this.rbBuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.rbBuy.Location = new System.Drawing.Point(138, 16);
            this.rbBuy.Name = "rbBuy";
            this.rbBuy.Size = new System.Drawing.Size(54, 25);
            this.rbBuy.TabIndex = 1;
            this.rbBuy.TabStop = true;
            this.rbBuy.Text = "Buy";
            this.rbBuy.UseVisualStyleBackColor = true;
            this.rbBuy.CheckedChanged += new System.EventHandler(this.rbBuy_CheckedChanged);
            // 
            // rbRent
            // 
            this.rbRent.AutoSize = true;
            this.rbRent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.rbRent.Location = new System.Drawing.Point(28, 16);
            this.rbRent.Name = "rbRent";
            this.rbRent.Size = new System.Drawing.Size(60, 25);
            this.rbRent.TabIndex = 0;
            this.rbRent.TabStop = true;
            this.rbRent.Text = "Rent";
            this.rbRent.UseVisualStyleBackColor = true;
            this.rbRent.CheckedChanged += new System.EventHandler(this.rbRent_CheckedChanged);
            // 
            // pnlMonRent
            // 
            this.pnlMonRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.pnlMonRent.Location = new System.Drawing.Point(12, 42);
            this.pnlMonRent.Name = "pnlMonRent";
            this.pnlMonRent.Size = new System.Drawing.Size(255, 1);
            this.pnlMonRent.TabIndex = 41;
            // 
            // txbMonRent
            // 
            this.txbMonRent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbMonRent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMonRent.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbMonRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.txbMonRent.Location = new System.Drawing.Point(12, 20);
            this.txbMonRent.Name = "txbMonRent";
            this.txbMonRent.Size = new System.Drawing.Size(255, 18);
            this.txbMonRent.TabIndex = 40;
            this.txbMonRent.Text = "Monthly Rental Amount";
            this.txbMonRent.TextChanged += new System.EventHandler(this.txbMonRent_TextChanged);
            this.txbMonRent.Enter += new System.EventHandler(this.txbMonRent_Enter);
            this.txbMonRent.Leave += new System.EventHandler(this.txbMonRent_Leave);
            // 
            // pnlRent
            // 
            this.pnlRent.Controls.Add(this.txbMonRent);
            this.pnlRent.Controls.Add(this.pnlMonRent);
            this.pnlRent.Location = new System.Drawing.Point(23, 111);
            this.pnlRent.Name = "pnlRent";
            this.pnlRent.Size = new System.Drawing.Size(277, 57);
            this.pnlRent.TabIndex = 52;
            this.pnlRent.Visible = false;
            // 
            // pnlTotDep
            // 
            this.pnlTotDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.pnlTotDep.Location = new System.Drawing.Point(9, 90);
            this.pnlTotDep.Name = "pnlTotDep";
            this.pnlTotDep.Size = new System.Drawing.Size(255, 1);
            this.pnlTotDep.TabIndex = 45;
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.lblInterestRate.Location = new System.Drawing.Point(9, 113);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(90, 15);
            this.lblInterestRate.TabIndex = 50;
            this.lblInterestRate.Text = "Interest Rate(%)";
            // 
            // pnlPurchPrice
            // 
            this.pnlPurchPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.pnlPurchPrice.Location = new System.Drawing.Point(9, 38);
            this.pnlPurchPrice.Name = "pnlPurchPrice";
            this.pnlPurchPrice.Size = new System.Drawing.Size(255, 1);
            this.pnlPurchPrice.TabIndex = 43;
            // 
            // numericUpDownInterestRate
            // 
            this.numericUpDownInterestRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.numericUpDownInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownInterestRate.DecimalPlaces = 2;
            this.numericUpDownInterestRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.numericUpDownInterestRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownInterestRate.Location = new System.Drawing.Point(122, 113);
            this.numericUpDownInterestRate.Name = "numericUpDownInterestRate";
            this.numericUpDownInterestRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownInterestRate.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownInterestRate.TabIndex = 51;
            this.numericUpDownInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbPurchPrice
            // 
            this.txbPurchPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbPurchPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPurchPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbPurchPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.txbPurchPrice.Location = new System.Drawing.Point(9, 16);
            this.txbPurchPrice.Name = "txbPurchPrice";
            this.txbPurchPrice.Size = new System.Drawing.Size(255, 18);
            this.txbPurchPrice.TabIndex = 42;
            this.txbPurchPrice.Text = "Purchase Price";
            this.txbPurchPrice.TextChanged += new System.EventHandler(this.txbPurchPrice_TextChanged);
            this.txbPurchPrice.Enter += new System.EventHandler(this.txbPurchPrice_Enter);
            this.txbPurchPrice.Leave += new System.EventHandler(this.txbPurchPrice_Leave);
            // 
            // txbTotDep
            // 
            this.txbTotDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbTotDep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTotDep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbTotDep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.txbTotDep.Location = new System.Drawing.Point(9, 66);
            this.txbTotDep.Name = "txbTotDep";
            this.txbTotDep.Size = new System.Drawing.Size(255, 18);
            this.txbTotDep.TabIndex = 44;
            this.txbTotDep.Text = "Total Deposit";
            this.txbTotDep.TextChanged += new System.EventHandler(this.txbTotDep_TextChanged);
            this.txbTotDep.Enter += new System.EventHandler(this.TotDep_Enter);
            this.txbTotDep.Leave += new System.EventHandler(this.TotDep_Leave);
            // 
            // pnlBuy
            // 
            this.pnlBuy.Controls.Add(this.numericUpDownMonRepay);
            this.pnlBuy.Controls.Add(this.txbTotDep);
            this.pnlBuy.Controls.Add(this.lblMonRepay);
            this.pnlBuy.Controls.Add(this.txbPurchPrice);
            this.pnlBuy.Controls.Add(this.numericUpDownInterestRate);
            this.pnlBuy.Controls.Add(this.pnlPurchPrice);
            this.pnlBuy.Controls.Add(this.lblInterestRate);
            this.pnlBuy.Controls.Add(this.pnlTotDep);
            this.pnlBuy.Location = new System.Drawing.Point(23, 174);
            this.pnlBuy.Name = "pnlBuy";
            this.pnlBuy.Size = new System.Drawing.Size(277, 190);
            this.pnlBuy.TabIndex = 53;
            this.pnlBuy.Visible = false;
            // 
            // numericUpDownMonRepay
            // 
            this.numericUpDownMonRepay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.numericUpDownMonRepay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownMonRepay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.numericUpDownMonRepay.Location = new System.Drawing.Point(122, 157);
            this.numericUpDownMonRepay.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownMonRepay.Minimum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.numericUpDownMonRepay.Name = "numericUpDownMonRepay";
            this.numericUpDownMonRepay.Size = new System.Drawing.Size(45, 19);
            this.numericUpDownMonRepay.TabIndex = 55;
            this.numericUpDownMonRepay.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDownMonRepay.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // lblMonRepay
            // 
            this.lblMonRepay.AutoSize = true;
            this.lblMonRepay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.lblMonRepay.Location = new System.Drawing.Point(9, 156);
            this.lblMonRepay.Name = "lblMonRepay";
            this.lblMonRepay.Size = new System.Drawing.Size(97, 15);
            this.lblMonRepay.TabIndex = 54;
            this.lblMonRepay.Text = "Months to repay:";
            // 
            // txbOutput
            // 
            this.txbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.txbOutput.Location = new System.Drawing.Point(350, 111);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(298, 253);
            this.txbOutput.TabIndex = 54;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.btnDelete.Location = new System.Drawing.Point(514, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.btnSave.Location = new System.Drawing.Point(409, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 55;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PropertyExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(668, 422);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.pnlBuy);
            this.Controls.Add(this.pnlRent);
            this.Controls.Add(this.pnlProperty);
            this.Controls.Add(this.label1);
            this.Name = "PropertyExpense";
            this.Text = "PropertyExpense";
            this.pnlProperty.ResumeLayout(false);
            this.pnlProperty.PerformLayout();
            this.pnlRent.ResumeLayout(false);
            this.pnlRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterestRate)).EndInit();
            this.pnlBuy.ResumeLayout(false);
            this.pnlBuy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonRepay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlProperty;
        private System.Windows.Forms.RadioButton rbBuy;
        private System.Windows.Forms.RadioButton rbRent;
        private System.Windows.Forms.Panel pnlMonRent;
        private System.Windows.Forms.TextBox txbMonRent;
        private System.Windows.Forms.Panel pnlRent;
        private System.Windows.Forms.Panel pnlTotDep;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Panel pnlPurchPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownInterestRate;
        private System.Windows.Forms.TextBox txbPurchPrice;
        private System.Windows.Forms.TextBox txbTotDep;
        private System.Windows.Forms.Panel pnlBuy;
        private System.Windows.Forms.NumericUpDown numericUpDownMonRepay;
        private System.Windows.Forms.Label lblMonRepay;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
    }
}