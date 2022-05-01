using CashflowMonitoring;

namespace CashflowMonitoringApp
{
    partial class AddTransactionView
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTransactionType = new System.Windows.Forms.ComboBox();
            this.txtTransactionReference = new System.Windows.Forms.TextBox();
            this.txtTransactionName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTransactionDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveTransaction = new System.Windows.Forms.Button();
            this.btnCancelTransactionView = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.transactionDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cashflowMonitoringData = new CashflowMonitoringData();
            this.cashflowMonitoringDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtgDataView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.referenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowMonitoringData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowMonitoringDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transaction Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Transaction Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reference";
            // 
            // txtTransactionType
            // 
            this.txtTransactionType.FormattingEnabled = true;
            this.txtTransactionType.Location = new System.Drawing.Point(292, 70);
            this.txtTransactionType.Name = "txtTransactionType";
            this.txtTransactionType.Size = new System.Drawing.Size(121, 21);
            this.txtTransactionType.TabIndex = 5;
            // 
            // txtTransactionReference
            // 
            this.txtTransactionReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransactionReference.Location = new System.Drawing.Point(418, 70);
            this.txtTransactionReference.Name = "txtTransactionReference";
            this.txtTransactionReference.Size = new System.Drawing.Size(289, 20);
            this.txtTransactionReference.TabIndex = 6;
            // 
            // txtTransactionName
            // 
            this.txtTransactionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransactionName.Location = new System.Drawing.Point(38, 109);
            this.txtTransactionName.Name = "txtTransactionName";
            this.txtTransactionName.Size = new System.Drawing.Size(375, 20);
            this.txtTransactionName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Transaction Date";
            // 
            // txtTransactionDate
            // 
            this.txtTransactionDate.Location = new System.Drawing.Point(38, 70);
            this.txtTransactionDate.Name = "txtTransactionDate";
            this.txtTransactionDate.Size = new System.Drawing.Size(248, 20);
            this.txtTransactionDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Add Transactions";
            // 
            // btnSaveTransaction
            // 
            this.btnSaveTransaction.Location = new System.Drawing.Point(560, 146);
            this.btnSaveTransaction.Name = "btnSaveTransaction";
            this.btnSaveTransaction.Size = new System.Drawing.Size(68, 23);
            this.btnSaveTransaction.TabIndex = 11;
            this.btnSaveTransaction.Text = "Save";
            this.btnSaveTransaction.UseVisualStyleBackColor = true;
            this.btnSaveTransaction.Click += new System.EventHandler(this.btnSaveTransactionClick);
            // 
            // btnCancelTransactionView
            // 
            this.btnCancelTransactionView.Location = new System.Drawing.Point(38, 400);
            this.btnCancelTransactionView.Name = "btnCancelTransactionView";
            this.btnCancelTransactionView.Size = new System.Drawing.Size(73, 23);
            this.btnCancelTransactionView.TabIndex = 12;
            this.btnCancelTransactionView.Text = "Go Back";
            this.btnCancelTransactionView.UseVisualStyleBackColor = true;
            this.btnCancelTransactionView.Click += new System.EventHandler(this.goBack);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Transaction Amount";
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransactionAmount.Location = new System.Drawing.Point(418, 109);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(289, 20);
            this.txtTransactionAmount.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // transactionDataBindingSource
            // 
            this.transactionDataBindingSource.DataMember = "TransactionData";
            this.transactionDataBindingSource.DataSource = this.cashflowMonitoringData;
            // 
            // cashflowMonitoringData
            // 
            this.cashflowMonitoringData.DataSetName = "CashflowMonitoringData";
            this.cashflowMonitoringData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cashflowMonitoringDataBindingSource
            // 
            this.cashflowMonitoringDataBindingSource.DataSource = this.cashflowMonitoringData;
            this.cashflowMonitoringDataBindingSource.Position = 0;
            // 
            // dtgDataView
            // 
            this.dtgDataView.AutoGenerateColumns = false;
            this.dtgDataView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgDataView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.referenceDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dtgDataView.DataSource = this.transactionDataBindingSource1;
            this.dtgDataView.Location = new System.Drawing.Point(38, 187);
            this.dtgDataView.Name = "dtgDataView";
            this.dtgDataView.Size = new System.Drawing.Size(669, 198);
            this.dtgDataView.TabIndex = 17;
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
            // transactionDataBindingSource1
            // 
            this.transactionDataBindingSource1.DataMember = "TransactionData";
            this.transactionDataBindingSource1.DataSource = this.cashflowMonitoringData;
            // 
            // AddTransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 435);
            this.Controls.Add(this.dtgDataView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTransactionAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancelTransactionView);
            this.Controls.Add(this.btnSaveTransaction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTransactionDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTransactionName);
            this.Controls.Add(this.txtTransactionReference);
            this.Controls.Add(this.txtTransactionType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "AddTransactionView";
            this.Text = "Add Transactions";
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowMonitoringData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashflowMonitoringDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionDataBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtTransactionType;
        private System.Windows.Forms.TextBox txtTransactionReference;
        private System.Windows.Forms.TextBox txtTransactionName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker txtTransactionDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveTransaction;
        private System.Windows.Forms.Button btnCancelTransactionView;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionReferenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transactionDataBindingSource;
        private CashflowMonitoringData cashflowMonitoringData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTransactionAmount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource cashflowMonitoringDataBindingSource;
        private System.Windows.Forms.DataGridView dtgDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn referenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource transactionDataBindingSource1;
    }
}