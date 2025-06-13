using System;
using System.Windows.Forms;
using AbaLogin;

namespace AbaHome {
    public partial class Home : UserControl {
        public Home() {
            InitializeComponent();
        }

        private void BtnCadProduto_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            HomeProduto home = new HomeProduto();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }
        private void BtnCadFilial_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            HomeFilial home = new HomeFilial();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }
        private void BtnCadFunc_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            HomeFuncionario home = new HomeFuncionario();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }
        private void BtnCadCliente_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            HomeCliente home = new HomeCliente();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }

        private void BtnHome_Logout_Click(object sender, EventArgs e) {
            MessageBox.Show("Deslogando", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            Login login = new Login();
            this.Controls.Add(login);
            login.Dock = DockStyle.Fill;
        }
    }
}
