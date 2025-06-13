using System;
using System.Windows.Forms;
using Dados.Clientes;
using AbaLogin;
using AbaHome;


namespace Clientes {
    public partial class CriarCliente : UserControl {
        public CriarCliente() {
            InitializeComponent();

            dtPickerCriar.MaxDate = DateTime.Now;
            dtPickerCriar.Value = DateTime.Now;
        }
        private void btnMenuCriar_Click(object sender, EventArgs e) {
            panelCriar.Visible = false;
            panelCriar.Controls.Clear();

            HomeCliente home = new HomeCliente();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }
        private void btnLogoutCriar_Click(object sender, EventArgs e) {
            panelCriar.Visible = false;
            panelCriar.Controls.Clear();

            Login login = new Login();
            this.Controls.Add(login);
            login.Visible = true;
            login.Dock = DockStyle.Fill;
        }

        private void btnRegistroCriar_Click(object sender, EventArgs e) {

            if (tbCpfCriar.Text != "") {

                var novoUsuarioPF = new UsuarioPF() {

                    Nome = tbNomeCriar.Text,
                    Cpf = tbCpfCriar.Text,
                    Tel = tbTelCriar.Text,
                    DataNasc = dtPickerCriar.Value,

                    Rua = tbRuaCriar.Text,
                    Num = tbNumCriar.Text,
                    Bairro = tbBairroCriar.Text,
                    Cep = tbCepCriar.Text,
                    Cidade = tbCidadeCriar.Text,
                    UF = tbUFCriar.Text
                };
                UsuarioPF.ListUsuariosPF.Add(novoUsuarioPF);

                Login.usuarioPFIndex++;

                tbNomeCriar.Clear();
                tbCpfCriar.Clear();

                ResetCriar();
                MessageBox.Show($"Usuário criado\nCliente {novoUsuarioPF.Id.ToString()}", "Ação concluida", MessageBoxButtons.OK);
                return;
            }

            MessageBox.Show("Preencha os campos para realizar o cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnResetarCriar_Click(object sender, EventArgs e) {

            if (BtnResetarCriar.Focus() == true) {

                tbNomeCriar.Enabled = true;
                tbCpfCriar.Enabled = true;
                dtPickerCriar.Enabled = true;

                tbNomeCriar.Clear();
                tbCpfCriar.Clear();

            }

            tbNomeCriar.Enabled = true;
            tbCpfCriar.Enabled = true;
            dtPickerCriar.Enabled = true;

            ResetCriar();
        }

        public void ResetCriar() {
            tbNomeCriar.Clear();
            tbCpfCriar.Clear();
            tbTelCriar.Clear();
            dtPickerCriar.Value = DateTime.Now.Date;

            tbRuaCriar.Clear();
            tbNumCriar.Clear();
            tbBairroCriar.Clear();
            tbCepCriar.Clear();
            tbCidadeCriar.Clear();
            tbUFCriar.Clear();
        }

    }
}
