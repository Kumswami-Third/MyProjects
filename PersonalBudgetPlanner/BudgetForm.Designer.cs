
namespace PersonalBudgetPlanner
{
    partial class BudgetForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnProperty = new System.Windows.Forms.Button();
            this.btnVehicle = new System.Windows.Forms.Button();
            this.btnGeneric = new System.Windows.Forms.Button();
            this.btnIncAndMon = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblCurrentMonth = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblTotIncLeftLive = new System.Windows.Forms.Label();
            this.lblTotIncLeft = new System.Windows.Forms.Label();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.pnlSideMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.pnlSideMenu.Controls.Add(this.btnReport);
            this.pnlSideMenu.Controls.Add(this.btnProperty);
            this.pnlSideMenu.Controls.Add(this.btnVehicle);
            this.pnlSideMenu.Controls.Add(this.btnGeneric);
            this.pnlSideMenu.Controls.Add(this.btnIncAndMon);
            this.pnlSideMenu.Controls.Add(this.pnlLogo);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(250, 561);
            this.pnlSideMenu.TabIndex = 0;
            this.pnlSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.ForeColor = System.Drawing.Color.Azure;
            this.btnReport.Location = new System.Drawing.Point(0, 267);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(250, 45);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "View Budget Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnProperty
            // 
            this.btnProperty.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProperty.FlatAppearance.BorderSize = 0;
            this.btnProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(198)))), ((int)(((byte)(132)))));
            this.btnProperty.Location = new System.Drawing.Point(0, 222);
            this.btnProperty.Name = "btnProperty";
            this.btnProperty.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProperty.Size = new System.Drawing.Size(250, 45);
            this.btnProperty.TabIndex = 2;
            this.btnProperty.Text = "Property Expense";
            this.btnProperty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProperty.UseVisualStyleBackColor = true;
            this.btnProperty.Click += new System.EventHandler(this.btnProperty_Click);
            // 
            // btnVehicle
            // 
            this.btnVehicle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVehicle.FlatAppearance.BorderSize = 0;
            this.btnVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(141)))), ((int)(((byte)(214)))));
            this.btnVehicle.Location = new System.Drawing.Point(0, 177);
            this.btnVehicle.Name = "btnVehicle";
            this.btnVehicle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVehicle.Size = new System.Drawing.Size(250, 45);
            this.btnVehicle.TabIndex = 3;
            this.btnVehicle.Text = "Vehicle Expenses";
            this.btnVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicle.UseVisualStyleBackColor = true;
            this.btnVehicle.Click += new System.EventHandler(this.btnVehicle_Click);
            // 
            // btnGeneric
            // 
            this.btnGeneric.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeneric.FlatAppearance.BorderSize = 0;
            this.btnGeneric.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(66)))), ((int)(((byte)(125)))));
            this.btnGeneric.Location = new System.Drawing.Point(0, 132);
            this.btnGeneric.Name = "btnGeneric";
            this.btnGeneric.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGeneric.Size = new System.Drawing.Size(250, 45);
            this.btnGeneric.TabIndex = 1;
            this.btnGeneric.Text = "Generic Expenses";
            this.btnGeneric.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGeneric.UseVisualStyleBackColor = true;
            this.btnGeneric.Click += new System.EventHandler(this.btnGeneric_Click);
            // 
            // btnIncAndMon
            // 
            this.btnIncAndMon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncAndMon.FlatAppearance.BorderSize = 0;
            this.btnIncAndMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncAndMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(98)))), ((int)(((byte)(81)))));
            this.btnIncAndMon.Location = new System.Drawing.Point(0, 87);
            this.btnIncAndMon.Name = "btnIncAndMon";
            this.btnIncAndMon.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIncAndMon.Size = new System.Drawing.Size(250, 45);
            this.btnIncAndMon.TabIndex = 5;
            this.btnIncAndMon.Text = "Income And Month";
            this.btnIncAndMon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncAndMon.UseVisualStyleBackColor = true;
            this.btnIncAndMon.Click += new System.EventHandler(this.btnIncAndMon_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.lblHeading);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(250, 87);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.ForeColor = System.Drawing.Color.Azure;
            this.lblHeading.Location = new System.Drawing.Point(12, 33);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(232, 25);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Personal Budget Planner";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // pnlTotal
            // 
            this.pnlTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnlTotal.Controls.Add(this.lblCurrentMonth);
            this.pnlTotal.Controls.Add(this.lblMonth);
            this.pnlTotal.Controls.Add(this.lblTotIncLeftLive);
            this.pnlTotal.Controls.Add(this.lblTotIncLeft);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(250, 461);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(684, 100);
            this.pnlTotal.TabIndex = 1;
            this.pnlTotal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTotal_Paint);
            // 
            // lblCurrentMonth
            // 
            this.lblCurrentMonth.AutoSize = true;
            this.lblCurrentMonth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentMonth.ForeColor = System.Drawing.Color.Azure;
            this.lblCurrentMonth.Location = new System.Drawing.Point(490, 34);
            this.lblCurrentMonth.Name = "lblCurrentMonth";
            this.lblCurrentMonth.Size = new System.Drawing.Size(166, 32);
            this.lblCurrentMonth.TabIndex = 3;
            this.lblCurrentMonth.Text = "CurrentMonth";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMonth.ForeColor = System.Drawing.Color.Azure;
            this.lblMonth.Location = new System.Drawing.Point(393, 34);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(91, 32);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Month:";
            // 
            // lblTotIncLeftLive
            // 
            this.lblTotIncLeftLive.AutoSize = true;
            this.lblTotIncLeftLive.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotIncLeftLive.ForeColor = System.Drawing.Color.Azure;
            this.lblTotIncLeftLive.Location = new System.Drawing.Point(215, 34);
            this.lblTotIncLeftLive.Name = "lblTotIncLeftLive";
            this.lblTotIncLeftLive.Size = new System.Drawing.Size(133, 32);
            this.lblTotIncLeftLive.TabIndex = 1;
            this.lblTotIncLeftLive.Text = "IncomeLeft";
            // 
            // lblTotIncLeft
            // 
            this.lblTotIncLeft.AutoSize = true;
            this.lblTotIncLeft.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotIncLeft.ForeColor = System.Drawing.Color.Azure;
            this.lblTotIncLeft.Location = new System.Drawing.Point(6, 34);
            this.lblTotIncLeft.Name = "lblTotIncLeft";
            this.lblTotIncLeft.Size = new System.Drawing.Size(203, 32);
            this.lblTotIncLeft.TabIndex = 0;
            this.lblTotIncLeft.Text = "Total Income Left:";
            this.lblTotIncLeft.Click += new System.EventHandler(this.lblTotIncLeft_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.ForeColor = System.Drawing.Color.Azure;
            this.pnlChildForm.Location = new System.Drawing.Point(250, 0);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(684, 461);
            this.pnlChildForm.TabIndex = 2;
            this.pnlChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChildForm_Paint);
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlTotal);
            this.Controls.Add(this.pnlSideMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "BudgetForm";
            this.Text = "Personal Budget Planner";
            this.pnlSideMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlTotal.ResumeLayout(false);
            this.pnlTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnVehicle;
        private System.Windows.Forms.Button btnProperty;
        private System.Windows.Forms.Button btnGeneric;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Label lblTotIncLeftLive;
        private System.Windows.Forms.Label lblTotIncLeft;
        private System.Windows.Forms.Button btnIncAndMon;
        private System.Windows.Forms.Label lblCurrentMonth;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblHeading;
    }
}

