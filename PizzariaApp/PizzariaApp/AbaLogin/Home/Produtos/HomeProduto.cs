using System;
using System.Windows.Forms;
using Produtos;
using AbaHome;

namespace AbaLogin {
    public partial class HomeProduto : UserControl {
        public HomeProduto() {
            InitializeComponent();
        }

        private void BtnProduto_Criar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            CriarProduto criar = new CriarProduto();
            this.Controls.Add(criar);
            criar.Dock = DockStyle.Fill;
        }

        private void BtnProduto_Verificar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            VerProduto ver = new VerProduto();
            this.Controls.Add(ver);
            ver.Dock = DockStyle.Fill;
        }

        private void BtnProduto_Editar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            EditarProduto editar = new EditarProduto();
            this.Controls.Add(editar);
            editar.Dock = DockStyle.Fill;
        }

        private void BtnProduto_Deletar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            DeletarProduto delete = new DeletarProduto();
            this.Controls.Add(delete);
            delete.Dock = DockStyle.Fill;
        }

        private void BtnProduto_Menu_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            Home home = new Home();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }

        private void BtnProduto_Logout_Click(object sender, EventArgs e) {
            MessageBox.Show("Deslogando", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            Login login = new Login();
            this.Controls.Add(login);
            login.Dock = DockStyle.Fill;
        }
    }
}
