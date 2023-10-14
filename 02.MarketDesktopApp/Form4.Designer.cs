namespace _02.MarketDesktopApp
{
    partial class Form4
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
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            btnUpdate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(46, 44);
            label1.Name = "label1";
            label1.Size = new Size(49, 19);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(46, 116);
            label2.Name = "label2";
            label2.Size = new Size(43, 19);
            label2.TabIndex = 1;
            label2.Text = "Price";
            // 
            // txtName
            // 
            txtName.Location = new Point(46, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 23);
            txtName.TabIndex = 2;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(46, 149);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(166, 23);
            txtPrice.TabIndex = 3;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.RosyBrown;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(45, 199);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(167, 28);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(275, 297);
            Controls.Add(btnUpdate);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private TextBox txtPrice;
        private Button btnUpdate;
    }
}