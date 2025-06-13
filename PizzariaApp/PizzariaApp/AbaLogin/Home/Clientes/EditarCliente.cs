using System;
using System.Windows.Forms;
using AbaLogin;
using AbaHome;
using Dados.Clientes;
using static Dados.Clientes.UsuarioPF;

namespace Clientes {
    public partial class EditarCliente : UserControl {
        public EditarCliente() {
            InitializeComponent();

            dtPickerModificar.MaxDate = DateTime.Now;
            dtPickerModificar.Value = DateTime.Now;

            for (int i = 0; i < ListUsuariosPF.Count; i++) {
                combBoxModificarPF.Items.Add(ListUsuariosPF[i].Id.ToString());
            }
        }

        private void btnMenuModificar_Click(object sender, EventArgs e) {
            panelModificar.Visible = false;
            panelModificar.Controls.Clear();

            HomeCliente home = new HomeCliente();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }
        private void btnLogoutModificar_Click(object sender, EventArgs e) {
            panelModificar.Visible = false;
            panelModificar.Controls.Clear();

            Login login = new Login();

            this.Controls.Add(login);
            login.Visible = true;
            login.Dock = DockStyle.Fill;
        }

        private void btnBuscarModificar_Click(object sender, EventArgs e) {
            if (tbCpfBuscarModificar.Text == "" && combBoxModificarPF.SelectedItem == null) {
                MessageBox.Show("Preencha os campos para continuar a busca");
            }

            //CPF
            if (tbCpfBuscarModificar.Text != "" && tbCpfBuscarModificar.Text.Length == 11) {
                UsuarioPF uPF = UsuarioPF.UserFinderPF(tbCpfBuscarModificar.Text);
                if (uPF != null) {
                    tbNomeModificar.Text = uPF.Nome;
                    tbCpfModificar.Text = uPF.Cpf;
                    tbTelModificar.Text = uPF.Tel;
                    tbRuaModificar.Text = uPF.Rua;
                    tbNumModificar.Text = uPF.Num;
                    tbCepModificar.Text = uPF.Cep;
                    tbBairroModificar.Text = uPF.Bairro;
                    tbCidadeModificar.Text = uPF.Cidade;
                    tbUFModificar.Text = uPF.UF;
                    tbNumClienteModificar.Text = uPF.Id.ToString();

                    tbCpfBuscarModificar.ReadOnly = true;
                }
            }            
            //ComboBox PF
            if (combBoxModificarPF.SelectedItem != null) {
                UsuarioPF u = UserFinderComboPF(int.Parse(combBoxModificarPF.Text));
                if (u != null) {
                    tbNomeModificar.Text = u.Nome;
                    tbCpfModificar.Text = u.Cpf;
                    dtPickerModificar.Value = u.DataNasc;
                    tbTelModificar.Text = u.Tel;

                    tbRuaModificar.Text = u.Rua;
                    tbNumModificar.Text = u.Num;
                    tbCepModificar.Text = u.Cep;
                    tbBairroModificar.Text = u.Bairro;
                    tbCidadeModificar.Text = u.Cidade;
                    tbUFModificar.Text = u.UF;
                    tbNumClienteModificar.Text = u.Id.ToString();

                    tbCpfBuscarModificar.Text = u.Cpf;
                    tbCpfBuscarModificar.ReadOnly = true;
                }
            }
        }
        private void BtnModificarModificar_Click(object sender, EventArgs e) {

            if (tbCpfBuscarModificar.Text != "") {
                UsuarioPF u = UserFinderPF(tbCpfBuscarModificar.Text);
                
                var confirm = MessageBox.Show("Deseja alterar essas informações?", "Confirmação de alteração", MessageBoxButtons.YesNo);

                if (u != null && confirm == DialogResult.Yes) {
                    u.Nome = tbNomeModificar.Text;
                    u.Cpf = tbCpfModificar.Text;
                    u.Tel = tbTelModificar.Text;
                    u.DataNasc = dtPickerModificar.Value.Date;

                    u.Rua = tbRuaModificar.Text;
                    u.Num = tbNumModificar.Text;
                    u.Cep = tbCepModificar.Text;
                    u.Bairro = tbBairroModificar.Text;
                    u.Cidade = tbCidadeModificar.Text;
                    u.UF = tbUFModificar.Text;

                    ResetModificar();
                    MessageBox.Show("Usuário atualizado", "Atualização concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }            
        }

        private void btnResetarModificar_Click(object sender, EventArgs e) {
            if (BtnResetarModificar.Focus() == true) {
                tbCpfBuscarModificar.Enabled = true;

                ResetModificar();
            }

            tbCpfBuscarModificar.Enabled = true;
            combBoxModificarPF.Enabled = true;

            tbCpfBuscarModificar.ReadOnly = false;

            ResetModificar();
        }

        public void ResetModificar() {

            tbNumClienteModificar.Clear();

            tbCpfBuscarModificar.Clear();

            tbNomeModificar.Clear();
            tbCpfModificar.Clear();
            dtPickerModificar.Value = DateTime.Now.Date;

            tbTelModificar.Clear();

            tbRuaModificar.Clear();
            tbNumModificar.Clear();
            tbBairroModificar.Clear();
            tbCepModificar.Clear();
            tbCidadeModificar.Clear();
            tbUFModificar.Clear();
            combBoxModificarPF.SelectedItem = null;

            tbNomeModificar.Enabled = true;
            tbCpfModificar.Enabled = true;
            dtPickerModificar.Enabled = true;

            tbCpfBuscarModificar.Enabled = true;

            combBoxModificarPF.Enabled = true;

            tbCpfBuscarModificar.ReadOnly = false;
        }

        private void combBoxModificarPF_SelectedIndexChanged(object sender, EventArgs e) {
            tbCpfBuscarModificar.Enabled = false;
        }

        private void tbCpfBuscarModificar_TextChanged(object sender, EventArgs e) {
            combBoxModificarPF.Enabled = false;
            combBoxModificarPF.SelectedItem = null;
        }
    }
}
