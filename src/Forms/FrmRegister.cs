using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src.Forms
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string DIR = Directory.GetCurrentDirectory();
            string file = DIR.Replace(@"\bin\Debug", @"\Resourses\Files\Users.txt");

            string user = txtUser.Text.ToLower();
            string password = txtPassword.Text.ToLower();
            string passwordConfirmation = txtPasswordConfirmation.Text.ToLower();
            bool isUserOk = false;
            bool isPasswordOk = false;


            if (string.IsNullOrWhiteSpace(user))
            {
                txtUserError.Text = "El carnet es requerido";
            }
            else
            {
                if (user.Length < 8)
                {
                    txtUserError.Text = "El carnet debe ser mayor a 8";
                }
                else
                {
                    txtUserError.Text = "";
                    isUserOk = true;
                }
            }

            if (string.IsNullOrWhiteSpace(passwordConfirmation))
            {
                txtPasswordConfirmationErrors.Text = "La confirmacion de la contraseña es requerida";
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                txtPasswordError.Text = "La contraseña es requerida";
            }
            else
            {
                if (password.Length < 6)
                {
                    txtPasswordError.Text = "La contraseña debe tener 6 digitos";
                }
                else
                {
                    txtPasswordError.Text = "";
                }
              
                if (password != passwordConfirmation)
                {
                    txtPasswordConfirmationErrors.Text = "La confirmacion de la contraseña no coincide";
                }
                else
                {
                    txtPasswordConfirmationErrors.Text = "";
                    isPasswordOk = true;
                }
                
            }

            if (isUserOk && isPasswordOk)
            {
                FileStream fs = new FileStream(file, FileMode.Append);
                StreamWriter insert = new StreamWriter(fs);

                insert.WriteLine(user);
                insert.WriteLine(password);
                insert.Close();

                FrmPrincipal Principal = new FrmPrincipal();
                Principal.MdiParent = this.MdiParent;
                Principal.Show();
                this.Close();
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmLogin Login = new FrmLogin();
            Login.MdiParent = this.MdiParent;
            Login.Show();
            this.Close();
        }
    }
}
