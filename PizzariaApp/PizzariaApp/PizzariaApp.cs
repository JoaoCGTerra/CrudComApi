using System;
using System.Windows.Forms;
using AbaLogin;

namespace PizzariaAPI {
    public partial class Pizzaria : Form {
        public Pizzaria() {
            InitializeComponent();
        }

        private void CRUD_Load(object sender, EventArgs e) {
            Login login = new Login();
            this.Controls.Add(login);
            login.Visible = true;
            login.Dock = DockStyle.Fill;

            MaximizeBox = false;
        }
    }
}
