namespace AbaLogin {
    partial class HomeCliente {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelHome = new System.Windows.Forms.Label();
            this.panelLBHome = new System.Windows.Forms.Panel();
            this.panelBtnsCriar = new System.Windows.Forms.Panel();
            this.BtnCliente_Logout = new System.Windows.Forms.Button();
            this.BtnCliente_Menu = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.BtnCliente_Deletar = new System.Windows.Forms.Button();
            this.BtnCliente_Editar = new System.Windows.Forms.Button();
            this.BtnCliente_Verificar = new System.Windows.Forms.Button();
            this.BtnCliente_Criar = new System.Windows.Forms.Button();
            this.panelLBHome.SuspendLayout();
            this.panelBtnsCriar.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.White;
            this.labelHome.Location = new System.Drawing.Point(298, 34);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(525, 33);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Aba de modificação de Clientes";
            // 
            // panelLBHome
            // 
            this.panelLBHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(56)))));
            this.panelLBHome.Controls.Add(this.panelBtnsCriar);
            this.panelLBHome.Controls.Add(this.labelHome);
            this.panelLBHome.Location = new System.Drawing.Point(0, 0);
            this.panelLBHome.Name = "panelLBHome";
            this.panelLBHome.Size = new System.Drawing.Size(1105, 100);
            this.panelLBHome.TabIndex = 1;
            // 
            // panelBtnsCriar
            // 
            this.panelBtnsCriar.Controls.Add(this.BtnCliente_Logout);
            this.panelBtnsCriar.Controls.Add(this.BtnCliente_Menu);
            this.panelBtnsCriar.Location = new System.Drawing.Point(904, 1);
            this.panelBtnsCriar.Name = "panelBtnsCriar";
            this.panelBtnsCriar.Size = new System.Drawing.Size(201, 99);
            this.panelBtnsCriar.TabIndex = 20;
            // 
            // BtnCliente_Logout
            // 
            this.BtnCliente_Logout.BackColor = System.Drawing.Color.Snow;
            this.BtnCliente_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCliente_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCliente_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente_Logout.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente_Logout.ForeColor = System.Drawing.Color.Black;
            this.BtnCliente_Logout.Location = new System.Drawing.Point(103, 32);
            this.BtnCliente_Logout.Name = "BtnCliente_Logout";
            this.BtnCliente_Logout.Size = new System.Drawing.Size(94, 37);
            this.BtnCliente_Logout.TabIndex = 4;
            this.BtnCliente_Logout.Text = "Logout";
            this.BtnCliente_Logout.UseVisualStyleBackColor = false;
            this.BtnCliente_Logout.Click += new System.EventHandler(this.BtnCliente_Logout_Click);
            // 
            // BtnCliente_Menu
            // 
            this.BtnCliente_Menu.BackColor = System.Drawing.Color.Snow;
            this.BtnCliente_Menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnCliente_Menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCliente_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCliente_Menu.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente_Menu.ForeColor = System.Drawing.Color.Black;
            this.BtnCliente_Menu.Location = new System.Drawing.Point(3, 32);
            this.BtnCliente_Menu.Name = "BtnCliente_Menu";
            this.BtnCliente_Menu.Size = new System.Drawing.Size(83, 37);
            this.BtnCliente_Menu.TabIndex = 3;
            this.BtnCliente_Menu.Text = "Menu";
            this.BtnCliente_Menu.UseVisualStyleBackColor = false;
            this.BtnCliente_Menu.Click += new System.EventHandler(this.BtnCliente_Menu_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Snow;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContainer.Controls.Add(this.BtnCliente_Deletar);
            this.panelContainer.Controls.Add(this.BtnCliente_Editar);
            this.panelContainer.Controls.Add(this.BtnCliente_Verificar);
            this.panelContainer.Controls.Add(this.BtnCliente_Criar);
            this.panelContainer.Controls.Add(this.panelLBHome);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1107, 755);
            this.panelContainer.TabIndex = 120;
            // 
            // BtnCliente_Deletar
            // 
            this.BtnCliente_Deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(56)))));
            this.BtnCliente_Deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCliente_Deletar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BtnCliente_Deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCliente_Deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnCliente_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCliente_Deletar.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente_Deletar.ForeColor = System.Drawing.Color.White;
            this.BtnCliente_Deletar.Location = new System.Drawing.Point(751, 351);
            this.BtnCliente_Deletar.Name = "BtnCliente_Deletar";
            this.BtnCliente_Deletar.Size = new System.Drawing.Size(137, 49);
            this.BtnCliente_Deletar.TabIndex = 18;
            this.BtnCliente_Deletar.Text = "Deletar";
            this.BtnCliente_Deletar.UseVisualStyleBackColor = false;
            this.BtnCliente_Deletar.Click += new System.EventHandler(this.BtnCliente_Deletar_Click);
            // 
            // BtnCliente_Editar
            // 
            this.BtnCliente_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(56)))));
            this.BtnCliente_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCliente_Editar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BtnCliente_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCliente_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnCliente_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCliente_Editar.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente_Editar.ForeColor = System.Drawing.Color.White;
            this.BtnCliente_Editar.Location = new System.Drawing.Point(563, 351);
            this.BtnCliente_Editar.Name = "BtnCliente_Editar";
            this.BtnCliente_Editar.Size = new System.Drawing.Size(170, 49);
            this.BtnCliente_Editar.TabIndex = 17;
            this.BtnCliente_Editar.Text = "Modificar";
            this.BtnCliente_Editar.UseVisualStyleBackColor = false;
            this.BtnCliente_Editar.Click += new System.EventHandler(this.BtnCliente_Editar_Click);
            // 
            // BtnCliente_Verificar
            // 
            this.BtnCliente_Verificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(56)))));
            this.BtnCliente_Verificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCliente_Verificar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BtnCliente_Verificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCliente_Verificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnCliente_Verificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCliente_Verificar.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente_Verificar.ForeColor = System.Drawing.Color.White;
            this.BtnCliente_Verificar.Location = new System.Drawing.Point(374, 351);
            this.BtnCliente_Verificar.Name = "BtnCliente_Verificar";
            this.BtnCliente_Verificar.Size = new System.Drawing.Size(169, 49);
            this.BtnCliente_Verificar.TabIndex = 16;
            this.BtnCliente_Verificar.Text = "Verificar";
            this.BtnCliente_Verificar.UseVisualStyleBackColor = false;
            this.BtnCliente_Verificar.Click += new System.EventHandler(this.BtnCliente_Verificar_Click);
            // 
            // BtnCliente_Criar
            // 
            this.BtnCliente_Criar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(56)))));
            this.BtnCliente_Criar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCliente_Criar.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BtnCliente_Criar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCliente_Criar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnCliente_Criar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCliente_Criar.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCliente_Criar.ForeColor = System.Drawing.Color.White;
            this.BtnCliente_Criar.Location = new System.Drawing.Point(219, 351);
            this.BtnCliente_Criar.Name = "BtnCliente_Criar";
            this.BtnCliente_Criar.Size = new System.Drawing.Size(137, 49);
            this.BtnCliente_Criar.TabIndex = 15;
            this.BtnCliente_Criar.Text = "Criar";
            this.BtnCliente_Criar.UseVisualStyleBackColor = false;
            this.BtnCliente_Criar.Click += new System.EventHandler(this.BtnCliente_Criar_Click);
            // 
            // HomeCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.panelContainer);
            this.Name = "HomeCliente";
            this.Size = new System.Drawing.Size(1107, 755);
            this.panelLBHome.ResumeLayout(false);
            this.panelLBHome.PerformLayout();
            this.panelBtnsCriar.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Panel panelLBHome;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button BtnCliente_Deletar;
        private System.Windows.Forms.Button BtnCliente_Editar;
        private System.Windows.Forms.Button BtnCliente_Verificar;
        private System.Windows.Forms.Button BtnCliente_Criar;
        private System.Windows.Forms.Panel panelBtnsCriar;
        private System.Windows.Forms.Button BtnCliente_Logout;
        private System.Windows.Forms.Button BtnCliente_Menu;
    }
}
