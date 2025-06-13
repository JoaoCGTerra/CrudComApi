namespace AbaLogin {
    partial class Login {
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.BtnCloseApplication = new System.Windows.Forms.Button();
            this.panelTBPW = new System.Windows.Forms.Panel();
            this.textBoxPW = new System.Windows.Forms.TextBox();
            this.panelTBUser = new System.Windows.Forms.Panel();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.panelBtnLogin = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelTBPW.SuspendLayout();
            this.panelTBUser.SuspendLayout();
            this.panelBtnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.Transparent;
            this.panelLogin.Controls.Add(this.BtnCloseApplication);
            this.panelLogin.Controls.Add(this.panelTBPW);
            this.panelLogin.Controls.Add(this.panelTBUser);
            this.panelLogin.Controls.Add(this.panelBtnLogin);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(1107, 755);
            this.panelLogin.TabIndex = 4;
            // 
            // BtnCloseApplication
            // 
            this.BtnCloseApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(56)))));
            this.BtnCloseApplication.FlatAppearance.BorderSize = 0;
            this.BtnCloseApplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            this.BtnCloseApplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(56)))));
            this.BtnCloseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseApplication.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold);
            this.BtnCloseApplication.ForeColor = System.Drawing.Color.White;
            this.BtnCloseApplication.Location = new System.Drawing.Point(912, 3);
            this.BtnCloseApplication.Name = "BtnCloseApplication";
            this.BtnCloseApplication.Size = new System.Drawing.Size(195, 54);
            this.BtnCloseApplication.TabIndex = 3;
            this.BtnCloseApplication.Text = "Sair";
            this.BtnCloseApplication.UseVisualStyleBackColor = false;
            this.BtnCloseApplication.Click += new System.EventHandler(this.BtnCloseApplication_Click);
            // 
            // panelTBPW
            // 
            this.panelTBPW.BackColor = System.Drawing.SystemColors.Menu;
            this.panelTBPW.Controls.Add(this.textBoxPW);
            this.panelTBPW.Location = new System.Drawing.Point(388, 462);
            this.panelTBPW.Name = "panelTBPW";
            this.panelTBPW.Size = new System.Drawing.Size(356, 75);
            this.panelTBPW.TabIndex = 4;
            // 
            // textBoxPW
            // 
            this.textBoxPW.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPW.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPW.ForeColor = System.Drawing.Color.Black;
            this.textBoxPW.Location = new System.Drawing.Point(3, 19);
            this.textBoxPW.Name = "textBoxPW";
            this.textBoxPW.PasswordChar = '*';
            this.textBoxPW.Size = new System.Drawing.Size(350, 32);
            this.textBoxPW.TabIndex = 0;
            this.textBoxPW.Text = "Admin";
            this.textBoxPW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelTBUser
            // 
            this.panelTBUser.BackColor = System.Drawing.SystemColors.Menu;
            this.panelTBUser.Controls.Add(this.textBoxUser);
            this.panelTBUser.Location = new System.Drawing.Point(388, 286);
            this.panelTBUser.Name = "panelTBUser";
            this.panelTBUser.Size = new System.Drawing.Size(356, 75);
            this.panelTBUser.TabIndex = 3;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.ForeColor = System.Drawing.Color.Black;
            this.textBoxUser.Location = new System.Drawing.Point(3, 19);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(350, 32);
            this.textBoxUser.TabIndex = 0;
            this.textBoxUser.Text = "Admin";
            this.textBoxUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelBtnLogin
            // 
            this.panelBtnLogin.Controls.Add(this.buttonLogin);
            this.panelBtnLogin.Location = new System.Drawing.Point(351, 588);
            this.panelBtnLogin.Name = "panelBtnLogin";
            this.panelBtnLogin.Size = new System.Drawing.Size(422, 107);
            this.panelBtnLogin.TabIndex = 2;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLogin.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.Color.Black;
            this.buttonLogin.Location = new System.Drawing.Point(77, 12);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(269, 83);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::PizzariaAPI.Properties.Resources.Pizzaria1;
            this.Controls.Add(this.panelLogin);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1107, 755);
            this.panelLogin.ResumeLayout(false);
            this.panelTBPW.ResumeLayout(false);
            this.panelTBPW.PerformLayout();
            this.panelTBUser.ResumeLayout(false);
            this.panelTBUser.PerformLayout();
            this.panelBtnLogin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button BtnCloseApplication;
        private System.Windows.Forms.Panel panelTBPW;
        private System.Windows.Forms.TextBox textBoxPW;
        private System.Windows.Forms.Panel panelTBUser;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Panel panelBtnLogin;
        private System.Windows.Forms.Button buttonLogin;
    }
}
