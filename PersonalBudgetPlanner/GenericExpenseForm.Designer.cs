
namespace PersonalBudgetPlanner
{
    partial class GenericExpenseForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbOutput = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlTravel = new System.Windows.Forms.Panel();
            this.txbTravel = new System.Windows.Forms.TextBox();
            this.pnlWaterLights = new System.Windows.Forms.Panel();
            this.txbWaterLights = new System.Windows.Forms.TextBox();
            this.pnlGroc = new System.Windows.Forms.Panel();
            this.txbGroceries = new System.Windows.Forms.TextBox();
            this.pnlTaxDed = new System.Windows.Forms.Panel();
            this.txbTaxDed = new System.Windows.Forms.TextBox();
            this.pnlCellTell = new System.Windows.Forms.Panel();
            this.txbCellTell = new System.Windows.Forms.TextBox();
            this.pnlOther = new System.Windows.Forms.Panel();
            this.txbOther = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.lblHeading.Location = new System.Drawing.Point(241, 27);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(166, 25);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Generic Expenses";
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.btnDelete.Location = new System.Drawing.Point(545, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbOutput
            // 
            this.txbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.txbOutput.Location = new System.Drawing.Point(347, 75);
            this.txbOutput.Multiline = true;
            this.txbOutput.Name = "txbOutput";
            this.txbOutput.Size = new System.Drawing.Size(298, 259);
            this.txbOutput.TabIndex = 32;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.btnSave.Location = new System.Drawing.Point(440, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlTravel
            // 
            this.pnlTravel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.pnlTravel.Location = new System.Drawing.Point(64, 242);
            this.pnlTravel.Name = "pnlTravel";
            this.pnlTravel.Size = new System.Drawing.Size(255, 1);
            this.pnlTravel.TabIndex = 26;
            // 
            // txbTravel
            // 
            this.txbTravel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbTravel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTravel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbTravel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.txbTravel.Location = new System.Drawing.Point(64, 218);
            this.txbTravel.Name = "txbTravel";
            this.txbTravel.Size = new System.Drawing.Size(255, 18);
            this.txbTravel.TabIndex = 25;
            this.txbTravel.Text = "Travel(inc. Petrol)";
            this.txbTravel.TextChanged += new System.EventHandler(this.txbTravel_TextChanged);
            this.txbTravel.Enter += new System.EventHandler(this.txbTravel_Enter);
            this.txbTravel.Leave += new System.EventHandler(this.txbTravel_Leave);
            // 
            // pnlWaterLights
            // 
            this.pnlWaterLights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.pnlWaterLights.Location = new System.Drawing.Point(64, 190);
            this.pnlWaterLights.Name = "pnlWaterLights";
            this.pnlWaterLights.Size = new System.Drawing.Size(255, 1);
            this.pnlWaterLights.TabIndex = 24;
            // 
            // txbWaterLights
            // 
            this.txbWaterLights.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbWaterLights.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbWaterLights.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbWaterLights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.txbWaterLights.Location = new System.Drawing.Point(64, 168);
            this.txbWaterLights.Name = "txbWaterLights";
            this.txbWaterLights.Size = new System.Drawing.Size(255, 18);
            this.txbWaterLights.TabIndex = 23;
            this.txbWaterLights.Text = "Water & Lights";
            this.txbWaterLights.TextChanged += new System.EventHandler(this.txbWaterLights_TextChanged);
            this.txbWaterLights.Enter += new System.EventHandler(this.txbWaterLights_Enter);
            this.txbWaterLights.Leave += new System.EventHandler(this.txbWaterLights_Leave);
            // 
            // pnlGroc
            // 
            this.pnlGroc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.pnlGroc.Location = new System.Drawing.Point(64, 141);
            this.pnlGroc.Name = "pnlGroc";
            this.pnlGroc.Size = new System.Drawing.Size(255, 1);
            this.pnlGroc.TabIndex = 22;
            // 
            // txbGroceries
            // 
            this.txbGroceries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbGroceries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbGroceries.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbGroceries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.txbGroceries.Location = new System.Drawing.Point(64, 119);
            this.txbGroceries.Name = "txbGroceries";
            this.txbGroceries.Size = new System.Drawing.Size(255, 18);
            this.txbGroceries.TabIndex = 21;
            this.txbGroceries.Text = "Groceries";
            this.txbGroceries.TextChanged += new System.EventHandler(this.txbGroceries_TextChanged);
            this.txbGroceries.Enter += new System.EventHandler(this.txbGroceries_Enter);
            this.txbGroceries.Leave += new System.EventHandler(this.txbGroceries_Leave);
            // 
            // pnlTaxDed
            // 
            this.pnlTaxDed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.pnlTaxDed.Location = new System.Drawing.Point(64, 98);
            this.pnlTaxDed.Name = "pnlTaxDed";
            this.pnlTaxDed.Size = new System.Drawing.Size(255, 1);
            this.pnlTaxDed.TabIndex = 20;
            // 
            // txbTaxDed
            // 
            this.txbTaxDed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbTaxDed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbTaxDed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbTaxDed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.txbTaxDed.Location = new System.Drawing.Point(64, 76);
            this.txbTaxDed.Name = "txbTaxDed";
            this.txbTaxDed.Size = new System.Drawing.Size(255, 18);
            this.txbTaxDed.TabIndex = 19;
            this.txbTaxDed.Text = "Tax Deductions";
            this.txbTaxDed.TextChanged += new System.EventHandler(this.txbTaxDed_TextChanged);
            this.txbTaxDed.Enter += new System.EventHandler(this.txbTaxDed_Enter);
            this.txbTaxDed.Leave += new System.EventHandler(this.txbTaxDed_Leave);
            // 
            // pnlCellTell
            // 
            this.pnlCellTell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.pnlCellTell.Location = new System.Drawing.Point(64, 294);
            this.pnlCellTell.Name = "pnlCellTell";
            this.pnlCellTell.Size = new System.Drawing.Size(255, 1);
            this.pnlCellTell.TabIndex = 35;
            // 
            // txbCellTell
            // 
            this.txbCellTell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbCellTell.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbCellTell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbCellTell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.txbCellTell.Location = new System.Drawing.Point(64, 270);
            this.txbCellTell.Name = "txbCellTell";
            this.txbCellTell.Size = new System.Drawing.Size(255, 18);
            this.txbCellTell.TabIndex = 34;
            this.txbCellTell.Text = "Cellphone & Telephone";
            this.txbCellTell.TextChanged += new System.EventHandler(this.txbCellTell_TextChanged);
            this.txbCellTell.Enter += new System.EventHandler(this.txbCellTell_Enter);
            this.txbCellTell.Leave += new System.EventHandler(this.txbCellTell_Leave);
            // 
            // pnlOther
            // 
            this.pnlOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.pnlOther.Location = new System.Drawing.Point(64, 350);
            this.pnlOther.Name = "pnlOther";
            this.pnlOther.Size = new System.Drawing.Size(255, 1);
            this.pnlOther.TabIndex = 37;
            // 
            // txbOther
            // 
            this.txbOther.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbOther.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbOther.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.txbOther.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.txbOther.Location = new System.Drawing.Point(64, 326);
            this.txbOther.Name = "txbOther";
            this.txbOther.Size = new System.Drawing.Size(255, 18);
            this.txbOther.TabIndex = 36;
            this.txbOther.Text = "Other";
            this.txbOther.TextChanged += new System.EventHandler(this.txbOther_TextChanged);
            this.txbOther.Enter += new System.EventHandler(this.txbOther_Enter);
            this.txbOther.Leave += new System.EventHandler(this.txbOther_Leave);
            // 
            // GenericExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(668, 422);
            this.Controls.Add(this.pnlOther);
            this.Controls.Add(this.txbOther);
            this.Controls.Add(this.pnlCellTell);
            this.Controls.Add(this.txbCellTell);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txbOutput);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlTravel);
            this.Controls.Add(this.txbTravel);
            this.Controls.Add(this.pnlWaterLights);
            this.Controls.Add(this.txbWaterLights);
            this.Controls.Add(this.pnlGroc);
            this.Controls.Add(this.txbGroceries);
            this.Controls.Add(this.pnlTaxDed);
            this.Controls.Add(this.txbTaxDed);
            this.Controls.Add(this.lblHeading);
            this.Name = "GenericExpenseForm";
            this.Text = "GenericExpense";
            this.Load += new System.EventHandler(this.GenericExpenseForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbOutput;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlTravel;
        private System.Windows.Forms.TextBox txbTravel;
        private System.Windows.Forms.Panel pnlWaterLights;
        private System.Windows.Forms.TextBox txbWaterLights;
        private System.Windows.Forms.Panel pnlGroc;
        private System.Windows.Forms.TextBox txbGroceries;
        private System.Windows.Forms.Panel pnlTaxDed;
        private System.Windows.Forms.TextBox txbTaxDed;
        private System.Windows.Forms.Panel pnlCellTell;
        private System.Windows.Forms.TextBox txbCellTell;
        private System.Windows.Forms.Panel pnlOther;
        private System.Windows.Forms.TextBox txbOther;
        private System.Windows.Forms.Panel v;
        private System.Windows.Forms.Panel l;
        private System.Windows.Forms.Panel n;
    }
}