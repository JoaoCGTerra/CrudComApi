﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbaLogin;

namespace Filiais {
    public partial class EditarFilial : UserControl {
        public EditarFilial() {
            InitializeComponent();
        }

        private void btnMenuVerificar_Click(object sender, EventArgs e) {
            panelEditarFilial.Visible = false;
            panelEditarFilial.Controls.Clear();

            HomeFilial home = new HomeFilial();
            this.Controls.Add(home);
            home.Dock = DockStyle.Fill;
        }

        private void btnLogoutVerificar_Click(object sender, EventArgs e) {
            panelEditarFilial.Visible = false;
            panelEditarFilial.Controls.Clear();

            Login login = new Login();
            this.Controls.Add(login);
            login.Visible = true;
            login.Dock = DockStyle.Fill;
        }
    }
}
