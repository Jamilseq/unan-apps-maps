namespace src.Forms
{
    partial class FrmRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.txtUserError = new System.Windows.Forms.Label();
            this.txtPasswordError = new System.Windows.Forms.Label();
            this.txtPasswordConfirmationErrors = new System.Windows.Forms.Label();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label1.Location = new System.Drawing.Point(89, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Registrarse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label2.Location = new System.Drawing.Point(66, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Carnet";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(69, 398);
            this.txtUser.MaxLength = 10;
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(246, 40);
            this.txtUser.TabIndex = 5;
            this.txtUser.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label3.Location = new System.Drawing.Point(66, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(69, 477);
            this.txtPassword.MaxLength = 10;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 40);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label4.Location = new System.Drawing.Point(66, 545);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // txtPasswordConfirmation
            // 
            this.txtPasswordConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirmation.Location = new System.Drawing.Point(69, 565);
            this.txtPasswordConfirmation.MaxLength = 10;
            this.txtPasswordConfirmation.Multiline = true;
            this.txtPasswordConfirmation.Name = "txtPasswordConfirmation";
            this.txtPasswordConfirmation.Size = new System.Drawing.Size(246, 40);
            this.txtPasswordConfirmation.TabIndex = 9;
            this.txtPasswordConfirmation.TabStop = false;
            // 
            // txtUserError
            // 
            this.txtUserError.AutoSize = true;
            this.txtUserError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserError.ForeColor = System.Drawing.Color.Red;
            this.txtUserError.Location = new System.Drawing.Point(173, 441);
            this.txtUserError.Name = "txtUserError";
            this.txtUserError.Size = new System.Drawing.Size(0, 13);
            this.txtUserError.TabIndex = 11;
            // 
            // txtPasswordError
            // 
            this.txtPasswordError.AutoSize = true;
            this.txtPasswordError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordError.ForeColor = System.Drawing.Color.Red;
            this.txtPasswordError.Location = new System.Drawing.Point(173, 520);
            this.txtPasswordError.Name = "txtPasswordError";
            this.txtPasswordError.Size = new System.Drawing.Size(0, 13);
            this.txtPasswordError.TabIndex = 12;
            // 
            // txtPasswordConfirmationErrors
            // 
            this.txtPasswordConfirmationErrors.AutoSize = true;
            this.txtPasswordConfirmationErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordConfirmationErrors.ForeColor = System.Drawing.Color.Red;
            this.txtPasswordConfirmationErrors.Location = new System.Drawing.Point(173, 608);
            this.txtPasswordConfirmationErrors.Name = "txtPasswordConfirmationErrors";
            this.txtPasswordConfirmationErrors.Size = new System.Drawing.Size(0, 13);
            this.txtPasswordConfirmationErrors.TabIndex = 13;
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(123)))), ((int)(((byte)(246)))));
            this.buttonRegister.FlatAppearance.BorderSize = 2;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRegister.Location = new System.Drawing.Point(220, 738);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(148, 53);
            this.buttonRegister.TabIndex = 14;
            this.buttonRegister.Text = "Registrarse";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.label5.Location = new System.Drawing.Point(66, 637);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(244, 34);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ya tienes una cuenta? \r\nIniciar sesion o ingresa como invitado";
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.linkLogin.Location = new System.Drawing.Point(66, 654);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(90, 17);
            this.linkLogin.TabIndex = 16;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Iniciar sesion";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(380, 840);
            this.ControlBox = false;
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.txtPasswordConfirmationErrors);
            this.Controls.Add(this.txtPasswordError);
            this.Controls.Add(this.txtUserError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPasswordConfirmation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPasswordConfirmation;
        private System.Windows.Forms.Label txtUserError;
        private System.Windows.Forms.Label txtPasswordError;
        private System.Windows.Forms.Label txtPasswordConfirmationErrors;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLogin;
    }
}