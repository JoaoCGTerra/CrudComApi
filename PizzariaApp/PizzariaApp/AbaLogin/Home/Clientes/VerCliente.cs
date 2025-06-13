using System;
using System.Windows.Forms;
using AbaLogin;
using AbaHome;
using Dados.Clientes;
using static Dados.Clientes.UsuarioPF;

namespace Clientes {
    public partial class VerCliente : UserControl {
        public VerCliente() {
            InitializeComponent();
            dtPickerVerificar.MaxDate = DateTime.Now;
            dtPickerVerificar.Value = DateTime.Now;

            for (int i = 0; i < ListUsuariosPF.Count; i++) {
                combBoxVerificarPF.Items.Add(ListUsuariosPF[i].Id.ToString());
            }
        }
        private void btnMenuVerificar_Click(object sender, EventArgs e) {
            panelVerificar.Visible = false;
            panelVerificar.Controls.Clear();

            HomeCliente home = new HomeCliente();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }
        private void btnLogoutVerificar_Click(object sender, EventArgs e) {
            panelVerificar.Visible = false;
            panelVerificar.Controls.Clear();

            Login login = new Login();

            this.Controls.Add(login);
            login.Visible = true;
            login.Dock = DockStyle.Fill;
        }

        private void btnBuscarVerificar_Click(object sender, EventArgs e) {
            if(tbCpfBuscarVerificar.Text == "" && combBoxVerificarPF.SelectedItem == null) {
                MessageBox.Show("Preencha os campos para continuar a busca");
            }

            //CPF
            if (tbCpfBuscarVerificar.Text != "" && tbCpfBuscarVerificar.Text.Length == 11) {

                UsuarioPF uPF = UsuarioPF.UserFinderPF(tbCpfBuscarVerificar.Text);
                if (uPF != null) {
                    tbNomeVerificar.Text = uPF.Nome;
                    tbCpfVerificar.Text = uPF.Cpf;
                    tbTelVerificar.Text = uPF.Tel;
                    dtPickerVerificar.Value = uPF.DataNasc;
                    tbRuaVerificar.Text = uPF.Rua;
                    tbNumVerificar.Text = uPF.Num;
                    tbCepVerificar.Text = uPF.Cep;
                    tbBairroVerificar.Text = uPF.Bairro;
                    tbCidadeVerificar.Text = uPF.Cidade;
                    tbUFVerificar.Text = uPF.UF;
                    tbNumClienteVerificar.Text = uPF.Id.ToString();
                }
            }
            //ComboBox PF
            if (combBoxVerificarPF.SelectedItem != null) {
                UsuarioPF u = UserFinderComboPF(int.Parse(combBoxVerificarPF.Text));
                if (u != null) {
                    tbNomeVerificar.Text = u.Nome;
                    tbCpfVerificar.Text = u.Cpf;
                    dtPickerVerificar.Value = u.DataNasc;
                    tbTelVerificar.Text = u.Tel;

                    tbRuaVerificar.Text = u.Rua;
                    tbNumVerificar.Text = u.Num;
                    tbCepVerificar.Text = u.Cep;
                    tbBairroVerificar.Text = u.Bairro;
                    tbCidadeVerificar.Text = u.Cidade;
                    tbUFVerificar.Text = u.UF;
                    tbNumClienteVerificar.Text = u.Id.ToString();
                }
            }
        }
        private void BtnReset_Click(object sender, EventArgs e) {
            if (BtnResetarVerificar.Focus() == true) {
                tbCpfBuscarVerificar.Enabled = true;

                ResetVerificar();
            }
            tbCpfBuscarVerificar.Enabled = true;
            combBoxVerificarPF.Enabled = true;

            ResetVerificar();
        }
        private void tbCpfBuscarVerificar_TextChanged(object sender, EventArgs e) {
            combBoxVerificarPF.Enabled = false;
            combBoxVerificarPF.SelectedItem = null;
        }
        private void combBoxVerificarPF_SelectedIndexChanged(object sender, EventArgs e) {
            tbCpfBuscarVerificar.Enabled = false;
        }


        public void ResetVerificar() {
            tbNumClienteVerificar.Clear();
            
            tbCpfBuscarVerificar.Clear();

            tbNomeVerificar.Clear();
            tbCpfVerificar.Clear();
            dtPickerVerificar.Value = DateTime.Now.Date;

            tbTelVerificar.Clear();

            tbRuaVerificar.Clear();
            tbNumVerificar.Clear();
            tbBairroVerificar.Clear();
            tbCepVerificar.Clear();
            tbCidadeVerificar.Clear();
            tbUFVerificar.Clear();
            combBoxVerificarPF.SelectedItem = null;
        }


    }
}
