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
using Funcionarios;

namespace AbaLogin {
    public partial class HomeFuncionario : UserControl {
        public HomeFuncionario() {
            InitializeComponent();
        }

        private void BtnFunc_Criar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            CriarFuncionario criar = new CriarFuncionario();
            this.Controls.Add(criar);
            criar.Dock = DockStyle.Fill;
        }

        private void BtnFunc_Verificar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            VerFuncionario ver = new VerFuncionario();
            this.Controls.Add(ver);
            ver.Dock = DockStyle.Fill;
        }

        private void BtnFunc_Editar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            EditarFuncionario editar = new EditarFuncionario();
            this.Controls.Add(editar);
            editar.Dock = DockStyle.Fill;
        }

        private void BtnFunc_Deletar_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            DeletarFuncionario delete = new DeletarFuncionario();
            this.Controls.Add(delete);
            delete.Dock = DockStyle.Fill;
        }

        private void BtnFunc_Menu_Click(object sender, EventArgs e) {
            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            Home home = new Home();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }

        private void BtnFunc_Logout_Click(object sender, EventArgs e) {
            MessageBox.Show("Deslogando", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Information);

            panelContainer.Visible = false;
            panelContainer.Controls.Clear();

            Login login = new Login();
            this.Controls.Add(login);
            login.Dock = DockStyle.Fill;
        }
    }
}
