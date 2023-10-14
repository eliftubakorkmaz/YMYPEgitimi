namespace _02.MarketDesktopApp
{
    partial class Form3
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgProducts = new DataGridView();
            Count = new DataGridViewTextBoxColumn();
            PId = new DataGridViewTextBoxColumn();
            PName = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            BtnEdit = new DataGridViewImageColumn();
            BtnRemove = new DataGridViewImageColumn();
            tabPage2 = new TabPage();
            btnSave = new Button();
            txtPrice = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgProducts).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(759, 590);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgProducts);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(751, 562);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Products";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgProducts
            // 
            dgProducts.AllowUserToAddRows = false;
            dgProducts.AllowUserToResizeRows = false;
            dgProducts.BackgroundColor = SystemColors.InactiveCaption;
            dgProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProducts.Columns.AddRange(new DataGridViewColumn[] { Count, PId, PName, Price, BtnEdit, BtnRemove });
            dgProducts.Dock = DockStyle.Fill;
            dgProducts.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgProducts.Location = new Point(3, 3);
            dgProducts.Name = "dgProducts";
            dgProducts.RowHeadersVisible = false;
            dgProducts.RowTemplate.Height = 25;
            dgProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgProducts.Size = new Size(745, 556);
            dgProducts.TabIndex = 1;
            dgProducts.CellClick += dgProducts_CellClick;
            // 
            // Count
            // 
            Count.HeaderText = "#";
            Count.Name = "Count";
            // 
            // PId
            // 
            PId.HeaderText = "Id";
            PId.Name = "PId";
            PId.Visible = false;
            // 
            // PName
            // 
            PName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            PName.HeaderText = "Name";
            PName.Name = "PName";
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Format = "c2";
            Price.DefaultCellStyle = dataGridViewCellStyle2;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // BtnEdit
            // 
            BtnEdit.HeaderText = "Edit";
            BtnEdit.Image = (Image)resources.GetObject("BtnEdit.Image");
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Resizable = DataGridViewTriState.True;
            // 
            // BtnRemove
            // 
            BtnRemove.HeaderText = "Remove";
            BtnRemove.Image = (Image)resources.GetObject("BtnRemove.Image");
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Resizable = DataGridViewTriState.True;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.GradientActiveCaption;
            tabPage2.Controls.Add(btnSave);
            tabPage2.Controls.Add(txtPrice);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtName);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(751, 562);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Product Add";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.RosyBrown;
            btnSave.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(34, 219);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(182, 32);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(35, 161);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(181, 23);
            txtPrice.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(86, 120);
            label2.Name = "label2";
            label2.Size = new Size(55, 24);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // txtName
            // 
            txtName.Location = new Point(34, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(182, 23);
            txtName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(86, 32);
            label1.Name = "label1";
            label1.Size = new Size(60, 24);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 590);
            Controls.Add(tabControl1);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgProducts).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgProducts;
        private Button btnSave;
        private TextBox txtPrice;
        private Label label2;
        private TextBox txtName;
        private Label label1;
        private DataGridViewTextBoxColumn Count;
        private DataGridViewTextBoxColumn PId;
        private DataGridViewTextBoxColumn PName;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewImageColumn BtnEdit;
        private DataGridViewImageColumn BtnRemove;
    }
}