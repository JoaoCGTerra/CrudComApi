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
    public partial class VerProduto : UserControl {
        public VerProduto() {
            InitializeComponent();
        }

        private void btnMenuCriar_Click(object sender, EventArgs e) {
            panelVerificarProduto.Visible = false;
            panelVerificarProduto.Controls.Clear();

            HomeProduto home = new HomeProduto();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }

        private void btnLogoutCriar_Click(object sender, EventArgs e) {
            panelVerificarProduto.Visible = false;
            panelVerificarProduto.Controls.Clear();

            Login login = new Login();
            this.Controls.Add(login);
            login.Visible = true;
            login.Dock = DockStyle.Fill;
        }
    }
}
