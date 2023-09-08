namespace FirstDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Profession = cbProfession.Text;
            MessageBox.Show(Profession, "Uyarý!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }
    }
}