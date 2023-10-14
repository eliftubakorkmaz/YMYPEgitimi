namespace _02.MarketDesktopApp
{
    partial class Form2
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
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle22 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle23 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle24 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle25 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle26 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle27 = new DataGridViewCellStyle();
            dgReceipts = new DataGridView();
            Count = new DataGridViewTextBoxColumn();
            RId = new DataGridViewTextBoxColumn();
            ReceiptNumber = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Payment = new DataGridViewTextBoxColumn();
            Remaining = new DataGridViewTextBoxColumn();
            BtnPrint = new DataGridViewButtonColumn();
            dgReceiptDetails = new DataGridView();
            RDCount = new DataGridViewTextBoxColumn();
            RDProductName = new DataGridViewTextBoxColumn();
            RDQuantity = new DataGridViewTextBoxColumn();
            RDPrice = new DataGridViewTextBoxColumn();
            RDTotal = new DataGridViewTextBoxColumn();
            dgReceiptPayments = new DataGridView();
            RPCount = new DataGridViewTextBoxColumn();
            RPType = new DataGridViewTextBoxColumn();
            RPAmount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgReceipts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgReceiptDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgReceiptPayments).BeginInit();
            SuspendLayout();
            // 
            // dgReceipts
            // 
            dgReceipts.AllowUserToAddRows = false;
            dgReceipts.AllowUserToDeleteRows = false;
            dgReceipts.AllowUserToResizeRows = false;
            dgReceipts.BackgroundColor = SystemColors.ActiveCaption;
            dgReceipts.BorderStyle = BorderStyle.None;
            dgReceipts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReceipts.Columns.AddRange(new DataGridViewColumn[] { Count, RId, ReceiptNumber, Date, Total, Payment, Remaining, BtnPrint });
            dgReceipts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgReceipts.GridColor = SystemColors.ButtonHighlight;
            dgReceipts.Location = new Point(12, 12);
            dgReceipts.Name = "dgReceipts";
            dgReceipts.RowHeadersVisible = false;
            dgReceipts.RowTemplate.Height = 25;
            dgReceipts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgReceipts.Size = new Size(1322, 367);
            dgReceipts.TabIndex = 0;
            dgReceipts.CellContentClick += dgReceipts_CellContentClick;
            dgReceipts.Click += dgReceipts_Click;
            // 
            // Count
            // 
            Count.HeaderText = "#";
            Count.Name = "Count";
            Count.Width = 50;
            // 
            // RId
            // 
            RId.HeaderText = "Id";
            RId.Name = "RId";
            RId.Visible = false;
            // 
            // ReceiptNumber
            // 
            ReceiptNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ReceiptNumber.HeaderText = "ReceiptNumber";
            ReceiptNumber.Name = "ReceiptNumber";
            ReceiptNumber.Width = 400;
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle19.Format = "F";
            Date.DefaultCellStyle = dataGridViewCellStyle19;
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.Width = 400;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Format = "c2";
            Total.DefaultCellStyle = dataGridViewCellStyle20;
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // Payment
            // 
            Payment.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle21.Format = "c2";
            Payment.DefaultCellStyle = dataGridViewCellStyle21;
            Payment.HeaderText = "Payment";
            Payment.Name = "Payment";
            // 
            // Remaining
            // 
            Remaining.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle22.Format = "c2";
            Remaining.DefaultCellStyle = dataGridViewCellStyle22;
            Remaining.HeaderText = "Remaining";
            Remaining.Name = "Remaining";
            // 
            // BtnPrint
            // 
            BtnPrint.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle23.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.NullValue = "Print";
            BtnPrint.DefaultCellStyle = dataGridViewCellStyle23;
            BtnPrint.HeaderText = "Operations";
            BtnPrint.Name = "BtnPrint";
            BtnPrint.Resizable = DataGridViewTriState.True;
            BtnPrint.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // dgReceiptDetails
            // 
            dgReceiptDetails.AllowUserToAddRows = false;
            dgReceiptDetails.BackgroundColor = SystemColors.ActiveCaption;
            dgReceiptDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReceiptDetails.Columns.AddRange(new DataGridViewColumn[] { RDCount, RDProductName, RDQuantity, RDPrice, RDTotal });
            dgReceiptDetails.Location = new Point(12, 396);
            dgReceiptDetails.Name = "dgReceiptDetails";
            dgReceiptDetails.RowHeadersVisible = false;
            dgReceiptDetails.RowTemplate.Height = 25;
            dgReceiptDetails.Size = new Size(805, 350);
            dgReceiptDetails.TabIndex = 1;
            // 
            // RDCount
            // 
            RDCount.HeaderText = "#";
            RDCount.Name = "RDCount";
            // 
            // RDProductName
            // 
            RDProductName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RDProductName.HeaderText = "ProductName";
            RDProductName.Name = "RDProductName";
            // 
            // RDQuantity
            // 
            RDQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle24.Format = "c2";
            RDQuantity.DefaultCellStyle = dataGridViewCellStyle24;
            RDQuantity.HeaderText = "Quantity";
            RDQuantity.Name = "RDQuantity";
            // 
            // RDPrice
            // 
            RDPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle25.Format = "c2";
            RDPrice.DefaultCellStyle = dataGridViewCellStyle25;
            RDPrice.HeaderText = "Price";
            RDPrice.Name = "RDPrice";
            // 
            // RDTotal
            // 
            RDTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle26.Format = "c2";
            RDTotal.DefaultCellStyle = dataGridViewCellStyle26;
            RDTotal.HeaderText = "Total";
            RDTotal.Name = "RDTotal";
            // 
            // dgReceiptPayments
            // 
            dgReceiptPayments.AllowUserToAddRows = false;
            dgReceiptPayments.BackgroundColor = SystemColors.ActiveCaption;
            dgReceiptPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgReceiptPayments.Columns.AddRange(new DataGridViewColumn[] { RPCount, RPType, RPAmount });
            dgReceiptPayments.Location = new Point(836, 396);
            dgReceiptPayments.Name = "dgReceiptPayments";
            dgReceiptPayments.RowHeadersVisible = false;
            dgReceiptPayments.RowTemplate.Height = 25;
            dgReceiptPayments.Size = new Size(498, 350);
            dgReceiptPayments.TabIndex = 2;
            // 
            // RPCount
            // 
            RPCount.HeaderText = "#";
            RPCount.Name = "RPCount";
            // 
            // RPType
            // 
            RPType.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RPType.HeaderText = "Type";
            RPType.Name = "RPType";
            // 
            // RPAmount
            // 
            RPAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle27.Format = "c2";
            RPAmount.DefaultCellStyle = dataGridViewCellStyle27;
            RPAmount.HeaderText = "Amount";
            RPAmount.Name = "RPAmount";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1346, 758);
            Controls.Add(dgReceiptPayments);
            Controls.Add(dgReceiptDetails);
            Controls.Add(dgReceipts);
            Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgReceipts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgReceiptDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgReceiptPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgReceipts;
        private DataGridView dgReceiptDetails;
        private DataGridView dgReceiptPayments;
        private DataGridViewTextBoxColumn RDCount;
        private DataGridViewTextBoxColumn RDProductName;
        private DataGridViewTextBoxColumn RDQuantity;
        private DataGridViewTextBoxColumn RDPrice;
        private DataGridViewTextBoxColumn RDTotal;
        private DataGridViewTextBoxColumn RPCount;
        private DataGridViewTextBoxColumn RPType;
        private DataGridViewTextBoxColumn RPAmount;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn RId;
        private DataGridViewTextBoxColumn ReceiptNumber;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Payment;
        private DataGridViewTextBoxColumn Remaining;
        private DataGridViewButtonColumn BtnPrint;
    }
}