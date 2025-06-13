using System;
using System.Windows.Forms;
using AbaHome;

namespace AbaLogin {
    public partial class Login : UserControl {
        public Login() {
            InitializeComponent();
        }
        public static int usuarioPFIndex = 1;
        public static int usuarioPJIndex = 1;

        string user = "Admin";
        string PW = "Admin";



        private void buttonLogin_Click(object sender, EventArgs e) {
            if (textBoxUser.Text == user && textBoxPW.Text == PW) {
                panelLogin.Visible = false;
                panelLogin.Controls.Clear();

                Home home = new Home();
                this.Controls.Add(home);
                home.Dock = DockStyle.Fill;
            }
            else {
                MessageBox.Show("Usuário ou senha incorreto.", "Usuário/Senha incorreto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCloseApplication_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
