using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbaLogin;

namespace Funcionarios {
    public partial class EditarFuncionario : UserControl {
        public EditarFuncionario() {
            InitializeComponent();
        }

        private void btnMenuModificar_Click(object sender, EventArgs e) {
            panelModificarFuncionario.Visible = false;
            panelModificarFuncionario.Controls.Clear();

            HomeFuncionario home = new HomeFuncionario();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }

        private void btnLogoutModificar_Click(object sender, EventArgs e) {
            panelModificarFuncionario.Visible = false;
            panelModificarFuncionario.Controls.Clear();

            Login login = new Login();
            this.Controls.Add(login);
            login.Visible = true;
            login.Dock = DockStyle.Fill;
        }
    }
}
