using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace src
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string carnet = txtUser.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(carnet))
            {
                txtErrosUser.Text = "El carnet es requerido";
            }
            else
            {
                if (carnet.Length < 8)
                {
                    txtErrosUser.Text = "El carnet debe ser mayor a 8";
                }
                else
                {
                    if (carnet != "22042658")
                    {
                        txtErrosUser.Text = "Usuario no encontrado";
                    }
                }
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                txtErrorsPassword.Text = "La contraseña es requerida";
            }
            else
            {
                if (txtPassword.Text.Length < 6)
                {
                    txtErrorsPassword.Text = "La contraseña debe tener 6 digitos";
                }
                else
                {
                    if (password != "123456")
                    {
                        txtErrorsPassword.Text = "La contraseña es incorrecta";
                    }
                    else
                    {
                      
                        FrmPrincipal Principal = new FrmPrincipal();
                        Principal.MdiParent = this.MdiParent;
                        Principal.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
