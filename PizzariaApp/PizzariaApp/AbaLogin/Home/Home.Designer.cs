namespace AbaHome {
    partial class Home {
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.BtnCadCliente = new System.Windows.Forms.Button();
            this.BtnCadFunc = new System.Windows.Forms.Button();
            this.BtnCadFilial = new System.Windows.Forms.Button();
            this.BtnCadProduto = new System.Windows.Forms.Button();
            this.panelLBHome = new System.Windows.Forms.Panel();
            this.panelBtnsCriar = new System.Windows.Forms.Panel();
            this.BtnHome_Logout = new System.Windows.Forms.Button();
            this.labelHome = new System.Windows.Forms.Label();
            this.panelContainer.SuspendLayout();
            this.panelLBHome.SuspendLayout();
            this.panelBtnsCriar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Snow;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContainer.Controls.Add(this.BtnCadCliente);
            this.panelContainer.Controls.Add(this.BtnCadFunc);
            this.panelContainer.Controls.Add(this.BtnCadFilial);
            this.panelContainer.Controls.Add(this.BtnCadProduto);
            this.panelContainer.Controls.Add(this.panelLBHome);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1123, 794);
            this.panelContainer.TabIndex = 120;
            // 
            // BtnCadCliente
            // 
            this.BtnCadCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(56)))));
            this.BtnCadCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadCliente.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BtnCadCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCadCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnCadCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadCliente.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadCliente.ForeColor = System.Drawing.Color.White;
            this.BtnCadCliente.Location = new System.Drawing.Point(45, 390);
            this.BtnCadCliente.Name = "BtnCadCliente";
            this.BtnCadCliente.Size = new System.Drawing.Size(377, 49);
            this.BtnCadCliente.TabIndex = 22;
            this.BtnCadCliente.Text = "Cadastro de clientes";
            this.BtnCadCliente.UseVisualStyleBackColor = false;
            this.BtnCadCliente.Click += new System.EventHandler(this.BtnCadCliente_Click);
            // 
            // BtnCadFunc
            // 
            this.BtnCadFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(56)))));
            this.BtnCadFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadFunc.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BtnCadFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCadFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnCadFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadFunc.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadFunc.ForeColor = System.Drawing.Color.White;
            this.BtnCadFunc.Location = new System.Drawing.Point(45, 292);
            this.BtnCadFunc.Name = "BtnCadFunc";
            this.BtnCadFunc.Size = new System.Drawing.Size(377, 77);
            this.BtnCadFunc.TabIndex = 21;
            this.BtnCadFunc.Text = "Cadastro de funcionarios";
            this.BtnCadFunc.UseVisualStyleBackColor = false;
            this.BtnCadFunc.Click += new System.EventHandler(this.BtnCadFunc_Click);
            // 
            // BtnCadFilial
            // 
            this.BtnCadFilial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(56)))));
            this.BtnCadFilial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadFilial.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BtnCadFilial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCadFilial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnCadFilial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadFilial.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadFilial.ForeColor = System.Drawing.Color.White;
            this.BtnCadFilial.Location = new System.Drawing.Point(45, 228);
            this.BtnCadFilial.Name = "BtnCadFilial";
            this.BtnCadFilial.Size = new System.Drawing.Size(377, 49);
            this.BtnCadFilial.TabIndex = 20;
            this.BtnCadFilial.Text = "Cadastro de filiais";
            this.BtnCadFilial.UseVisualStyleBackColor = false;
            this.BtnCadFilial.Click += new System.EventHandler(this.BtnCadFilial_Click);
            // 
            // BtnCadProduto
            // 
            this.BtnCadProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(56)))));
            this.BtnCadProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCadProduto.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.BtnCadProduto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnCadProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.BtnCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCadProduto.Font = new System.Drawing.Font("MS Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadProduto.ForeColor = System.Drawing.Color.White;
            this.BtnCadProduto.Location = new System.Drawing.Point(45, 164);
            this.BtnCadProduto.Name = "BtnCadProduto";
            this.BtnCadProduto.Size = new System.Drawing.Size(377, 49);
            this.BtnCadProduto.TabIndex = 19;
            this.BtnCadProduto.Text = "Cadastro de produtos";
            this.BtnCadProduto.UseVisualStyleBackColor = false;
            this.BtnCadProduto.Click += new System.EventHandler(this.BtnCadProduto_Click);
            // 
            // panelLBHome
            // 
            this.panelLBHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(84)))), ((int)(((byte)(56)))));
            this.panelLBHome.Controls.Add(this.panelBtnsCriar);
            this.panelLBHome.Controls.Add(this.labelHome);
            this.panelLBHome.Location = new System.Drawing.Point(0, -2);
            this.panelLBHome.Name = "panelLBHome";
            this.panelLBHome.Size = new System.Drawing.Size(1121, 100);
            this.panelLBHome.TabIndex = 1;
            // 
            // panelBtnsCriar
            // 
            this.panelBtnsCriar.Controls.Add(this.BtnHome_Logout);
            this.panelBtnsCriar.Location = new System.Drawing.Point(917, 0);
            this.panelBtnsCriar.Name = "panelBtnsCriar";
            this.panelBtnsCriar.Size = new System.Drawing.Size(204, 100);
            this.panelBtnsCriar.TabIndex = 20;
            // 
            // BtnHome_Logout
            // 
            this.BtnHome_Logout.BackColor = System.Drawing.Color.Snow;
            this.BtnHome_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnHome_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnHome_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome_Logout.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome_Logout.ForeColor = System.Drawing.Color.Black;
            this.BtnHome_Logout.Location = new System.Drawing.Point(55, 32);
            this.BtnHome_Logout.Name = "BtnHome_Logout";
            this.BtnHome_Logout.Size = new System.Drawing.Size(94, 37);
            this.BtnHome_Logout.TabIndex = 4;
            this.BtnHome_Logout.Text = "Logout";
            this.BtnHome_Logout.UseVisualStyleBackColor = false;
            this.BtnHome_Logout.Click += new System.EventHandler(this.BtnHome_Logout_Click);
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.White;
            this.labelHome.Location = new System.Drawing.Point(520, 34);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(83, 33);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Home";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.Controls.Add(this.panelContainer);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(1123, 794);
            this.panelContainer.ResumeLayout(false);
            this.panelLBHome.ResumeLayout(false);
            this.panelLBHome.PerformLayout();
            this.panelBtnsCriar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button BtnCadCliente;
        private System.Windows.Forms.Button BtnCadFunc;
        private System.Windows.Forms.Button BtnCadFilial;
        private System.Windows.Forms.Button BtnCadProduto;
        private System.Windows.Forms.Panel panelLBHome;
        private System.Windows.Forms.Panel panelBtnsCriar;
        private System.Windows.Forms.Button BtnHome_Logout;
        private System.Windows.Forms.Label labelHome;
    }
}
