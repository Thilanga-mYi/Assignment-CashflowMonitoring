namespace CashflowMonitoring
{
    partial class WeeklyReportView
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtEndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgWeeklyTransactions = new System.Windows.Forms.DataGridView();
            this.cashflowMonitoringData = new CashflowMonitoringData();
            this.transactionDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgWeeklyTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowMonitoringData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GENERATE REPORT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.generateWeeklyReport);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "START DATE";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(15, 25);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(299, 20);
            this.txtStartDate.TabIndex = 2;
            this.txtStartDate.ValueChanged += new System.EventHandler(this.changedStartDateValue);
            // 
            // txtEndDate
            // 
            this.txtEndDate.Location = new System.Drawing.Point(319, 26);
            this.txtEndDate.Name = "txtEndDate";
            this.txtEndDate.Size = new System.Drawing.Size(299, 20);
            this.txtEndDate.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "END DATE";
            // 
            // dtgWeeklyTransactions
            // 
            this.dtgWeeklyTransactions.AutoGenerateColumns = false;
            this.dtgWeeklyTransactions.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgWeeklyTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgWeeklyTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dtgWeeklyTransactions.DataSource = this.transactionDataBindingSource;
            this.dtgWeeklyTransactions.Location = new System.Drawing.Point(15, 52);
            this.dtgWeeklyTransactions.Name = "dtgWeeklyTransactions";
            this.dtgWeeklyTransactions.Size = new System.Drawing.Size(773, 338);
            this.dtgWeeklyTransactions.TabIndex = 5;
            // 
            // cashflowMonitoringData
            // 
            this.cashflowMonitoringData.DataSetName = "CashflowMonitoringData";
            this.cashflowMonitoringData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionDataBindingSource
            // 
            this.transactionDataBindingSource.DataMember = "TransactionData";
            this.transactionDataBindingSource.DataSource = this.cashflowMonitoringData;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // referenceDataGridViewTextBoxColumn
            // 
            this.referenceDataGridViewTextBoxColumn.DataPropertyName = "Reference";
            this.referenceDataGridViewTextBoxColumn.HeaderText = "Reference";
            this.referenceDataGridViewTextBoxColumn.Name = "referenceDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "<--- BACK TO DASHBOARD";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // WeeklyReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtgWeeklyTransactions);
            this.Controls.Add(this.txtEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "WeeklyReportView";
            this.Text = "Weekly Report View";
            ((System.ComponentModel.ISupportInitialize)(this.dtgWeeklyTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowMonitoringData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtStartDate;
        private System.Windows.Forms.DateTimePicker txtEndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgWeeklyTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transactionDataBindingSource;
        private CashflowMonitoringData cashflowMonitoringData;
        private System.Windows.Forms.Button button2;
    }
}