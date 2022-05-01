namespace CashflowMonitoringApp
{
    partial class DashboardView
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
            this.btnAddTransactionView = new System.Windows.Forms.Button();
            this.btnViewTransactionView = new System.Windows.Forms.Button();
            this.btnViewFinancialStatusView = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddTransactionView
            // 
            this.btnAddTransactionView.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransactionView.Location = new System.Drawing.Point(35, 81);
            this.btnAddTransactionView.Name = "btnAddTransactionView";
            this.btnAddTransactionView.Size = new System.Drawing.Size(209, 55);
            this.btnAddTransactionView.TabIndex = 0;
            this.btnAddTransactionView.Text = "ADD TRANSACTIONS";
            this.btnAddTransactionView.UseVisualStyleBackColor = true;
            this.btnAddTransactionView.Click += new System.EventHandler(this.btnAddTransactionView_Click);
            // 
            // btnViewTransactionView
            // 
            this.btnViewTransactionView.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTransactionView.Location = new System.Drawing.Point(35, 142);
            this.btnViewTransactionView.Name = "btnViewTransactionView";
            this.btnViewTransactionView.Size = new System.Drawing.Size(209, 55);
            this.btnViewTransactionView.TabIndex = 2;
            this.btnViewTransactionView.Text = "GENERATE WEEKLY REPORT";
            this.btnViewTransactionView.UseVisualStyleBackColor = true;
            this.btnViewTransactionView.Click += new System.EventHandler(this.btnViewWeeklyReport_Click);
            // 
            // btnViewFinancialStatusView
            // 
            this.btnViewFinancialStatusView.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFinancialStatusView.Location = new System.Drawing.Point(35, 203);
            this.btnViewFinancialStatusView.Name = "btnViewFinancialStatusView";
            this.btnViewFinancialStatusView.Size = new System.Drawing.Size(209, 55);
            this.btnViewFinancialStatusView.TabIndex = 3;
            this.btnViewFinancialStatusView.Text = "VIEW FINANCE STATUS";
            this.btnViewFinancialStatusView.UseVisualStyleBackColor = true;
            this.btnViewFinancialStatusView.Click += new System.EventHandler(this.btnViewFinancialStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dashboard";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewFinancialStatusView);
            this.Controls.Add(this.btnViewTransactionView);
            this.Controls.Add(this.btnAddTransactionView);
            this.Name = "DashboardView";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTransactionView;
        private System.Windows.Forms.Button btnViewTransactionView;
        private System.Windows.Forms.Button btnViewFinancialStatusView;
        private System.Windows.Forms.Label label1;
    }
}