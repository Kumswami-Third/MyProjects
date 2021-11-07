
namespace PersonalBudgetPlanner
{
    partial class BudgetReport
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
            this.lblReport = new System.Windows.Forms.Label();
            this.txbMedium = new System.Windows.Forms.TextBox();
            this.txbHighest = new System.Windows.Forms.TextBox();
            this.txbLowest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblReport.Location = new System.Drawing.Point(285, 9);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(67, 25);
            this.lblReport.TabIndex = 0;
            this.lblReport.Text = "Report";
            this.lblReport.Click += new System.EventHandler(this.lblReport_Click);
            // 
            // txbMedium
            // 
            this.txbMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbMedium.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMedium.ForeColor = System.Drawing.Color.White;
            this.txbMedium.Location = new System.Drawing.Point(285, 71);
            this.txbMedium.Multiline = true;
            this.txbMedium.Name = "txbMedium";
            this.txbMedium.Size = new System.Drawing.Size(234, 135);
            this.txbMedium.TabIndex = 56;
            this.txbMedium.TextChanged += new System.EventHandler(this.txbHighest_TextChanged);
            // 
            // txbHighest
            // 
            this.txbHighest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbHighest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbHighest.ForeColor = System.Drawing.Color.White;
            this.txbHighest.Location = new System.Drawing.Point(36, 71);
            this.txbHighest.Multiline = true;
            this.txbHighest.Name = "txbHighest";
            this.txbHighest.Size = new System.Drawing.Size(234, 135);
            this.txbHighest.TabIndex = 57;
            this.txbHighest.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txbLowest
            // 
            this.txbLowest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.txbLowest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbLowest.ForeColor = System.Drawing.Color.White;
            this.txbLowest.Location = new System.Drawing.Point(36, 219);
            this.txbLowest.Multiline = true;
            this.txbLowest.Name = "txbLowest";
            this.txbLowest.Size = new System.Drawing.Size(234, 138);
            this.txbLowest.TabIndex = 58;
            this.txbLowest.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // BudgetReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(668, 422);
            this.Controls.Add(this.txbLowest);
            this.Controls.Add(this.txbHighest);
            this.Controls.Add(this.txbMedium);
            this.Controls.Add(this.lblReport);
            this.Name = "BudgetReport";
            this.Text = "BudgetReport";
            this.Load += new System.EventHandler(this.BudgetReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.TextBox txbMedium;
        private System.Windows.Forms.TextBox txbHighest;
        private System.Windows.Forms.TextBox txbLowest;
    }
}