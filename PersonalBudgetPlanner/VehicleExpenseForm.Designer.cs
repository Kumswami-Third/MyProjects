
namespace PersonalBudgetPlanner
{
    partial class VehicleExpenseForm
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlMake = new System.Windows.Forms.Panel();
            this.txbMake = new System.Windows.Forms.TextBox();
            this.pnlModel = new System.Windows.Forms.Panel();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.pnlPurchPrice = new System.Windows.Forms.Panel();
            this.txbPurchPrice = new System.Windows.Forms.TextBox();
            this.pnlTotDeposit = new System.Windows.Forms.Panel();
            this.txbTotDeposit = new System.Windows.Forms.TextBox();
            this.pnlInterestPrem = new System.Windows.Forms.Panel();
            this.txbInsurancePrem = new System.Windows.Forms.TextBox();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.numericUpDownInterestRate = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterestRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.lblHeading.Location = new System.Drawing.Point(241, 22);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(169, 30);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Vehicle Expense";
            // 
            // pnlMake
            // 
            this.pnlMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.pnlMake.Location = new System.Drawing.Point(58, 98);
            this.pnlMake.Name = "pnlMake";
            this.pnlMake.Size = new System.Drawing.Size(255, 1);
            this.pnlMake.TabIndex = 4;
            // 
            // txbMake
            // 
            this.txbMake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbMake.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMake.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbMake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.txbMake.Location = new System.Drawing.Point(58, 76);
            this.txbMake.Name = "txbMake";
            this.txbMake.Size = new System.Drawing.Size(255, 18);
            this.txbMake.TabIndex = 3;
            this.txbMake.Text = "Make";
            this.txbMake.TextChanged += new System.EventHandler(this.txbMake_TextChanged);
            this.txbMake.Enter += new System.EventHandler(this.txbMake_Enter);
            this.txbMake.Leave += new System.EventHandler(this.txbMake_Leave);
            // 
            // pnlModel
            // 
            this.pnlModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.pnlModel.Location = new System.Drawing.Point(58, 141);
            this.pnlModel.Name = "pnlModel";
            this.pnlModel.Size = new System.Drawing.Size(255, 1);
            this.pnlModel.TabIndex = 6;
            // 
            // txbModel
            // 
            this.txbModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbModel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.txbModel.Location = new System.Drawing.Point(58, 119);
            this.txbModel.Name = "txbModel";
            this.txbModel.Size = new System.Drawing.Size(255, 18);
            this.txbModel.TabIndex = 5;
            this.txbModel.Text = "Model";
            this.txbModel.TextChanged += new System.EventHandler(this.txbModel_TextChanged);
            this.txbModel.Enter += new System.EventHandler(this.txbModel_Enter);
            this.txbModel.Leave += new System.EventHandler(this.txbModel_Leave);
            // 
            // pnlPurchPrice
            // 
            this.pnlPurchPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.pnlPurchPrice.Location = new System.Drawing.Point(58, 190);
            this.pnlPurchPrice.Name = "pnlPurchPrice";
            this.pnlPurchPrice.Size = new System.Drawing.Size(255, 1);
            this.pnlPurchPrice.TabIndex = 8;
            // 
            // txbPurchPrice
            // 
            this.txbPurchPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbPurchPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPurchPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbPurchPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.txbPurchPrice.Location = new System.Drawing.Point(58, 168);
            this.txbPurchPrice.Name = "txbPurchPrice";
            this.txbPurchPrice.Size = new System.Drawing.Size(255, 18);
            this.txbPurchPrice.TabIndex = 7;
            this.txbPurchPrice.Text = "Purchase Price";
            this.txbPurchPrice.TextChanged += new System.EventHandler(this.txbPurchPrice_TextChanged);
            this.txbPurchPrice.Enter += new System.EventHandler(this.txbPurchPrice_Enter);
            this.txbPurchPrice.Leave += new System.EventHandler(this.txbPurchPrice_Leave);
            // 
            // pnlTotDeposit
            // 
            this.pnlTotDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.pnlTotDeposit.Location = new System.Drawing.Point(58, 242);
            this.pnlTotDeposit.Name = "pnlTotDeposit";
            this.pnlTotDeposit.Size = new System.Drawing.Size(255, 1);
            this.pnlTotDeposit.TabIndex = 10;
            // 
            // txbTotDeposit
            // 
            this.txbTotDeposit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbTotDeposit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTotDeposit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbTotDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.txbTotDeposit.Location = new System.Drawing.Point(58, 218);
            this.txbTotDeposit.Name = "txbTotDeposit";
            this.txbTotDeposit.Size = new System.Drawing.Size(255, 18);
            this.txbTotDeposit.TabIndex = 9;
            this.txbTotDeposit.Text = "Total Deposit";
            this.txbTotDeposit.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txbTotDeposit.Enter += new System.EventHandler(this.txbTotDeposit_Enter);
            this.txbTotDeposit.Leave += new System.EventHandler(this.txbTotDeposit_Leave);
            // 
            // pnlInterestPrem
            // 
            this.pnlInterestPrem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.pnlInterestPrem.Location = new System.Drawing.Point(58, 333);
            this.pnlInterestPrem.Name = "pnlInterestPrem";
            this.pnlInterestPrem.Size = new System.Drawing.Size(255, 1);
            this.pnlInterestPrem.TabIndex = 12;
            // 
            // txbInsurancePrem
            // 
            this.txbInsurancePrem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbInsurancePrem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbInsurancePrem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbInsurancePrem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.txbInsurancePrem.Location = new System.Drawing.Point(58, 311);
            this.txbInsurancePrem.Name = "txbInsurancePrem";
            this.txbInsurancePrem.Size = new System.Drawing.Size(255, 18);
            this.txbInsurancePrem.TabIndex = 11;
            this.txbInsurancePrem.Text = "Insurance Premium";
            this.txbInsurancePrem.TextChanged += new System.EventHandler(this.txbInterestPrem_TextChanged);
            this.txbInsurancePrem.Enter += new System.EventHandler(this.txbInterestPrem_Enter);
            this.txbInsurancePrem.Leave += new System.EventHandler(this.txbInterestPrem_Leave);
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.lblInterestRate.Location = new System.Drawing.Point(58, 271);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(90, 15);
            this.lblInterestRate.TabIndex = 14;
            this.lblInterestRate.Text = "Interest Rate(%)";
            // 
            // numericUpDownInterestRate
            // 
            this.numericUpDownInterestRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.numericUpDownInterestRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownInterestRate.DecimalPlaces = 2;
            this.numericUpDownInterestRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.numericUpDownInterestRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownInterestRate.Location = new System.Drawing.Point(174, 271);
            this.numericUpDownInterestRate.Name = "numericUpDownInterestRate";
            this.numericUpDownInterestRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDownInterestRate.Size = new System.Drawing.Size(60, 19);
            this.numericUpDownInterestRate.TabIndex = 15;
            this.numericUpDownInterestRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.btnSave.Location = new System.Drawing.Point(434, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txbOutput
            // 
            this.txbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.txbOutput.Location = new System.Drawing.Point(341, 75);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(298, 259);
            this.txbOutput.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.btnDelete.Location = new System.Drawing.Point(539, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // VehicleExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(668, 422);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numericUpDownInterestRate);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.pnlInterestPrem);
            this.Controls.Add(this.txbInsurancePrem);
            this.Controls.Add(this.pnlTotDeposit);
            this.Controls.Add(this.txbTotDeposit);
            this.Controls.Add(this.pnlPurchPrice);
            this.Controls.Add(this.txbPurchPrice);
            this.Controls.Add(this.pnlModel);
            this.Controls.Add(this.txbModel);
            this.Controls.Add(this.pnlMake);
            this.Controls.Add(this.txbMake);
            this.Controls.Add(this.lblHeading);
            this.Name = "VehicleExpenseForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "VehicleExpense";
            this.Load += new System.EventHandler(this.VehicleExpenseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterestRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel pnlMake;
        private System.Windows.Forms.TextBox txbMake;
        private System.Windows.Forms.Panel pnlModel;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.Panel pnlPurchPrice;
        private System.Windows.Forms.TextBox txbPurchPrice;
        private System.Windows.Forms.Panel pnlTotDeposit;
        private System.Windows.Forms.TextBox txbTotDeposit;
        private System.Windows.Forms.Panel pnlInterestPrem;
        private System.Windows.Forms.TextBox txbInterestPrem;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.NumericUpDown numericUpDownInterestRate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txbInsurancePrem;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.Button btnDelete;
    }
}