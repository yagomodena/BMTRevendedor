


using BMT_Revendedor.Principal;

namespace BMT_Revendedor
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("C:\\Program Files\\Google\\Chrome\\Application\\chrome.exe", "https://api.whatsapp.com/send?phone=5516988577820&text=Ol%C3%A1%2C%20estou%20com%20uma%20d%C3%BAvida%20sobre%20o%20BMT%20Revendedor.");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal novoform = new frmPrincipal();
            novoform.Show();
        }
    }
}