using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbaHome;
using Clientes;

namespace AbaLogin {
    public partial class HomeCliente : UserControl {
        public HomeCliente() {
            InitializeComponent();
        }

        private void BtnCliente_Criar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            CriarCliente criar = new CriarCliente();
            this.Controls.Add(criar);
            criar.Dock = DockStyle.Fill;
        }

        private void BtnCliente_Verificar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            VerCliente verificar = new VerCliente();
            this.Controls.Add(verificar);
            verificar.Dock = DockStyle.Fill;
        }

        private void BtnCliente_Editar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            EditarCliente editar = new EditarCliente();
            this.Controls.Add(editar);
            editar.Dock = DockStyle.Fill;
        }

        private void BtnCliente_Deletar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            DeletarCliente deletar = new DeletarCliente();
            this.Controls.Add(deletar);
            deletar.Dock = DockStyle.Fill;
        }

        private void BtnCliente_Menu_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            Home home = new Home();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }

        private void BtnCliente_Logout_Click(object sender, EventArgs e) {
            MessageBox.Show("Deslogando", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            Login login = new Login();
            this.Controls.Add(login);
            login.Dock = DockStyle.Fill;
        }
    }
}
