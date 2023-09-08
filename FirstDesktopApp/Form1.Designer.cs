namespace FirstDesktopApp
{
    partial class Form1
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
            cbProfession = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cbProfession
            // 
            cbProfession.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbProfession.AutoCompleteSource = AutoCompleteSource.ListItems;
            cbProfession.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProfession.FormattingEnabled = true;
            cbProfession.Items.AddRange(new object[] { "Öğretmen", "Öğrenci", "Müdür", "Müdür Yardımcısı" });
            cbProfession.Location = new Point(81, 78);
            cbProfession.Name = "cbProfession";
            cbProfession.Size = new Size(170, 33);
            cbProfession.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(81, 129);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 605);
            Controls.Add(btnSave);
            Controls.Add(cbProfession);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbProfession;
        private Button btnSave;
    }
}