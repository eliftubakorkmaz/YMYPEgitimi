namespace _02.MarketDesktopApp
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            txtBarcode = new TextBox();
            groupBox2 = new GroupBox();
            dgList = new DataGridView();
            Count = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            gbPayment = new GroupBox();
            btnCash = new Button();
            btnKK = new Button();
            txtPayment = new TextBox();
            groupBox3 = new GroupBox();
            lbTotal = new Label();
            groupBox5 = new GroupBox();
            btnComplete = new Button();
            btnReset = new Button();
            lbRemaing = new Label();
            groupBox6 = new GroupBox();
            dgPayment = new DataGridView();
            Total = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            reporsToolStripMenuItem = new ToolStripMenuItem();
            receiptsToolStripMenuItem = new ToolStripMenuItem();
            productsToolStripMenuItem = new ToolStripMenuItem();
            addProductToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgList).BeginInit();
            gbPayment.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPayment).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(txtBarcode);
            groupBox1.Location = new Point(14, 40);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(751, 107);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // txtBarcode
            // 
            txtBarcode.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            txtBarcode.Location = new Point(15, 10);
            txtBarcode.Margin = new Padding(3, 2, 3, 2);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(716, 93);
            txtBarcode.TabIndex = 0;
            txtBarcode.KeyPress += txtBarcode_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(dgList);
            groupBox2.Location = new Point(14, 161);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(751, 469);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // dgList
            // 
            dgList.AllowUserToAddRows = false;
            dgList.BackgroundColor = Color.LightBlue;
            dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgList.Columns.AddRange(new DataGridViewColumn[] { Count, Name, Quantity, Price, TotalPrice });
            dgList.GridColor = SystemColors.MenuHighlight;
            dgList.Location = new Point(6, 11);
            dgList.Margin = new Padding(3, 2, 3, 2);
            dgList.Name = "dgList";
            dgList.RowHeadersVisible = false;
            dgList.RowTemplate.Height = 25;
            dgList.Size = new Size(739, 442);
            dgList.TabIndex = 0;
            // 
            // Count
            // 
            Count.HeaderText = "#";
            Count.Name = "Count";
            Count.Width = 50;
            // 
            // Name
            // 
            Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Name.HeaderText = "Product Name";
            Name.Name = "Name";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Quantity";
            Quantity.Name = "Quantity";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "Total Price";
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 150;
            // 
            // gbPayment
            // 
            gbPayment.BackColor = SystemColors.Control;
            gbPayment.Controls.Add(btnCash);
            gbPayment.Controls.Add(btnKK);
            gbPayment.Controls.Add(txtPayment);
            gbPayment.Location = new Point(803, 142);
            gbPayment.Margin = new Padding(3, 2, 3, 2);
            gbPayment.Name = "gbPayment";
            gbPayment.Padding = new Padding(3, 2, 3, 2);
            gbPayment.Size = new Size(523, 168);
            gbPayment.TabIndex = 3;
            gbPayment.TabStop = false;
            // 
            // btnCash
            // 
            btnCash.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCash.ForeColor = Color.Teal;
            btnCash.Image = Properties.Resources.Cash_icon;
            btnCash.Location = new Point(289, 79);
            btnCash.Margin = new Padding(3, 2, 3, 2);
            btnCash.Name = "btnCash";
            btnCash.Size = new Size(193, 85);
            btnCash.TabIndex = 6;
            btnCash.UseVisualStyleBackColor = true;
            btnCash.Click += btnCash_Click;
            // 
            // btnKK
            // 
            btnKK.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnKK.ForeColor = Color.Teal;
            btnKK.Image = Properties.Resources.credit_card_icon;
            btnKK.Location = new Point(40, 79);
            btnKK.Margin = new Padding(3, 2, 3, 2);
            btnKK.Name = "btnKK";
            btnKK.Size = new Size(193, 85);
            btnKK.TabIndex = 5;
            btnKK.UseVisualStyleBackColor = true;
            btnKK.Click += btnKK_Click;
            // 
            // txtPayment
            // 
            txtPayment.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPayment.ForeColor = Color.DarkSlateBlue;
            txtPayment.Location = new Point(20, 19);
            txtPayment.Margin = new Padding(3, 2, 3, 2);
            txtPayment.Name = "txtPayment";
            txtPayment.Size = new Size(481, 57);
            txtPayment.TabIndex = 0;
            txtPayment.Text = "0";
            txtPayment.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.Control;
            groupBox3.Controls.Add(lbTotal);
            groupBox3.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.BlueViolet;
            groupBox3.Location = new Point(803, 33);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(523, 91);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // lbTotal
            // 
            lbTotal.Location = new Point(0, 7);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(511, 63);
            lbTotal.TabIndex = 0;
            lbTotal.Text = "0,00 TL";
            lbTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = SystemColors.Control;
            groupBox5.Controls.Add(btnComplete);
            groupBox5.Controls.Add(btnReset);
            groupBox5.Controls.Add(lbRemaing);
            groupBox5.Location = new Point(797, 449);
            groupBox5.Margin = new Padding(3, 2, 3, 2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(3, 2, 3, 2);
            groupBox5.Size = new Size(523, 181);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            // 
            // btnComplete
            // 
            btnComplete.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnComplete.ForeColor = Color.MediumVioletRed;
            btnComplete.Image = Properties.Resources.check_icon;
            btnComplete.Location = new Point(277, 80);
            btnComplete.Margin = new Padding(3, 2, 3, 2);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(193, 85);
            btnComplete.TabIndex = 7;
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.ForeColor = Color.MediumVioletRed;
            btnReset.Image = Properties.Resources.pink_trash_empty_icon;
            btnReset.Location = new Point(55, 80);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(193, 85);
            btnReset.TabIndex = 6;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lbRemaing
            // 
            lbRemaing.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbRemaing.ForeColor = Color.BlueViolet;
            lbRemaing.Location = new Point(6, 14);
            lbRemaing.Name = "lbRemaing";
            lbRemaing.Size = new Size(511, 57);
            lbRemaing.TabIndex = 1;
            lbRemaing.Text = "0,00 TL";
            lbRemaing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(dgPayment);
            groupBox6.Location = new Point(803, 328);
            groupBox6.Margin = new Padding(3, 2, 3, 2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 2, 3, 2);
            groupBox6.Size = new Size(523, 101);
            groupBox6.TabIndex = 5;
            groupBox6.TabStop = false;
            // 
            // dgPayment
            // 
            dgPayment.AllowUserToAddRows = false;
            dgPayment.BackgroundColor = Color.Thistle;
            dgPayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPayment.Columns.AddRange(new DataGridViewColumn[] { Total, dataGridViewTextBoxColumn4 });
            dgPayment.GridColor = SystemColors.MenuHighlight;
            dgPayment.Location = new Point(6, 18);
            dgPayment.Margin = new Padding(3, 2, 3, 2);
            dgPayment.Name = "dgPayment";
            dgPayment.RowHeadersVisible = false;
            dgPayment.RowTemplate.Height = 25;
            dgPayment.Size = new Size(511, 88);
            dgPayment.TabIndex = 1;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Total.HeaderText = "Type";
            Total.Name = "Total";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { reporsToolStripMenuItem, productsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1346, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // reporsToolStripMenuItem
            // 
            reporsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { receiptsToolStripMenuItem });
            reporsToolStripMenuItem.Name = "reporsToolStripMenuItem";
            reporsToolStripMenuItem.Size = new Size(59, 20);
            reporsToolStripMenuItem.Text = "Reports";
            // 
            // receiptsToolStripMenuItem
            // 
            receiptsToolStripMenuItem.Name = "receiptsToolStripMenuItem";
            receiptsToolStripMenuItem.Size = new Size(118, 22);
            receiptsToolStripMenuItem.Text = "Receipts";
            receiptsToolStripMenuItem.Click += receiptsToolStripMenuItem_Click;
            // 
            // productsToolStripMenuItem
            // 
            productsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addProductToolStripMenuItem });
            productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            productsToolStripMenuItem.Size = new Size(66, 20);
            productsToolStripMenuItem.Text = "Products";
            // 
            // addProductToolStripMenuItem
            // 
            addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            addProductToolStripMenuItem.Size = new Size(180, 22);
            addProductToolStripMenuItem.Text = " Products";
            addProductToolStripMenuItem.Click += addProductToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1346, 656);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(gbPayment);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgList).EndInit();
            gbPayment.ResumeLayout(false);
            gbPayment.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPayment).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox gbPayment;
        private GroupBox groupBox3;
        private GroupBox groupBox5;
        private TextBox txtBarcode;
        private DataGridView dgList;
        private Label lbTotal;
        private TextBox txtPayment;
        private Button btnKK;
        private Button btnCash;
        private Button btnComplete;
        private Button btnReset;
        private Label lbRemaing;
        private GroupBox groupBox6;
        private DataGridView dgPayment;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn TotalPrice;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem reporsToolStripMenuItem;
        private ToolStripMenuItem receiptsToolStripMenuItem;
        private ToolStripMenuItem productsToolStripMenuItem;
        private ToolStripMenuItem addProductToolStripMenuItem;
    }
}