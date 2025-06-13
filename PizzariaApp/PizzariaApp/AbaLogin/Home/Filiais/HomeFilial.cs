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
using Filiais;

namespace AbaLogin {
    public partial class HomeFilial : UserControl {
        public HomeFilial() {
            InitializeComponent();
        }

        private void BtnFilial_Criar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            CriarFilial criar = new CriarFilial();
            this.Controls.Add(criar);
            criar.Dock = DockStyle.Fill;
        }

        private void BtnFilial_Verificar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            VerFilial verificar = new VerFilial();
            this.Controls.Add(verificar);
            verificar.Dock = DockStyle.Fill;
        }

        private void BtnFilial_Editar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            EditarFilial editar = new EditarFilial();
            this.Controls.Add(editar);
            editar.Dock = DockStyle.Fill;
        }

        private void BtnFilial_Deletar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            DeletarFilial delete = new DeletarFilial();
            this.Controls.Add(delete);
            delete.Dock = DockStyle.Fill;
        }

        private void BtnFilial_Menu_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            Home home = new Home();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }

        private void BtnFilial_Logout_Click(object sender, EventArgs e) {
            MessageBox.Show("Deslogando", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            Login login = new Login();
            this.Controls.Add(login);
            login.Dock = DockStyle.Fill;
        }
    }
}
