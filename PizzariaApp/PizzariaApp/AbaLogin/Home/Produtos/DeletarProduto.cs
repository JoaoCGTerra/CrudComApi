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

namespace Produtos {
    public partial class DeletarProduto : UserControl {
        public DeletarProduto() {
            InitializeComponent();
        }

        private void btnMenuDeletar_Click(object sender, EventArgs e) {
            panelDeletarProduto.Visible = false;
            panelDeletarProduto.Controls.Clear();

            HomeProduto home = new HomeProduto();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }

        private void btnLogoutDeletar_Click(object sender, EventArgs e) {
            panelDeletarProduto.Visible = false;
            panelDeletarProduto.Controls.Clear();

            Login login = new Login();
            this.Controls.Add(login);
            login.Visible = true;
            login.Dock = DockStyle.Fill;
        }
    }
}
