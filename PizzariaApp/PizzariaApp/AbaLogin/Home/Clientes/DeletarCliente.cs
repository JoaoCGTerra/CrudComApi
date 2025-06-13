using System;
using System.Windows.Forms;
using AbaLogin;
using AbaHome;
using Dados.Clientes;
using static Dados.Clientes.UsuarioPF;

namespace Clientes {
    public partial class DeletarCliente : UserControl {
        public DeletarCliente() {
            InitializeComponent();

            for (int i = 0; i < ListUsuariosPF.Count; i++) {
                combBoxDeletarPF.Items.Add(ListUsuariosPF[i].Id.ToString());
            }
        }
        private void btnMenuDeletar_Click(object sender, EventArgs e) {
            panelDeletar.Visible = false;
            panelDeletar.Controls.Clear();

            HomeCliente home = new HomeCliente();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }
        private void btnLogoutDeletar_Click(object sender, EventArgs e) {
            panelDeletar.Visible = false;
            panelDeletar.Controls.Clear();

            Login login = new Login();            

            this.Controls.Add(login);
            login.Visible = true;
            login.Dock = DockStyle.Fill;
        }

        private void btnBuscarDeletar_Click(object sender, EventArgs e) {

            if (tbCpfBuscarDeletar.Text == "" && combBoxDeletarPF.SelectedItem == null) {
                MessageBox.Show("Preencha os campos para deletar um usuário", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Exclusão CPF
            if (tbCpfBuscarDeletar.Text != "" && tbCpfBuscarDeletar.Text.Length == 11) {
                for (int i = 0; i < ListUsuariosPF.Count; i++) {
                    if (tbCpfBuscarDeletar.Text == ListUsuariosPF[i].Cpf) {
                        UsuarioPF userDelete = UserFinderPF(tbCpfBuscarDeletar.Text);

                        var confirm = MessageBox.Show($"Tem certeza que deseja deletar o usuário:\n{userDelete.Id}\n{userDelete.Nome}\n{userDelete.Cpf}", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (userDelete != null && confirm == DialogResult.Yes) {
                            UserDeletePF(userDelete);

                            MessageBox.Show($"Usuário {userDelete.Id}\n{userDelete.Nome}\n{userDelete.Cpf}\ndeletado", "Exclusão confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        return;
                    }
                }
            }
            //Exclusão BOX PF
            if (combBoxDeletarPF.Text != null) {
                int.TryParse(combBoxDeletarPF.Text, out int idTratado);
                for (int i = 0; i < ListUsuariosPF.Count; i++) {
                    if (idTratado == ListUsuariosPF[i].Id) {

                        UsuarioPF uPF = UserFinderComboPF(int.Parse(combBoxDeletarPF.Text));

                        var confirm = MessageBox.Show($"Tem certeza que deseja deletar o usuário:\n{uPF.Id}\n{uPF.Nome}\n{uPF.Cpf}", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (uPF != null && confirm == DialogResult.Yes) {
                            UserDeletePF(uPF);

                            MessageBox.Show($"Usuário {uPF.Id}\n{uPF.Nome}\n{uPF.Cpf}\ndeletado", "Exclusão confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ResetDeletar();
                            return;
                        }
                    }
                }
            }
        }
        public void ResetDeletar(){
            tbCpfBuscarDeletar.Clear();
            combBoxDeletarPF.SelectedItem = null;
        }

        private void BtnResetarDeletar_Click(object sender, EventArgs e) {
            ResetDeletar();

            tbCpfBuscarDeletar.Enabled = true;
            combBoxDeletarPF.Enabled = true;
        }

        private void tbCpfBuscarDeletar_TextChanged(object sender, EventArgs e) {
            combBoxDeletarPF.Enabled = false;
        }

        private void combBoxDeletarPF_SelectedIndexChanged(object sender, EventArgs e) {
            tbCpfBuscarDeletar.Enabled = false;
        }

    }
}
