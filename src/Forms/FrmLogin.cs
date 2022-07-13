using src.Forms;
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
            string DIR = Directory.GetCurrentDirectory();
            string file = DIR.Replace(@"\bin\Debug", @"\Resourses\Files\Users.txt");

            StreamReader sr = new StreamReader(file);
            bool userExist = false;
            string userDB = sr.ReadLine();
            string passwordDB = sr.ReadLine();
            string user = txtUser.Text;
            string password = txtPassword.Text;
            bool isUserOk = false;
            bool isPasswordOk = false;

            if (string.IsNullOrWhiteSpace(user))
            {
                txtErrosUser.Text = "El carnet es requerido";
            }
            else
            {
                if (user.Length < 8)
                {
                    txtErrosUser.Text = "El carnet debe ser mayor a 8";
                }
                else
                {
                    isUserOk = true;                   
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
                    isPasswordOk = true;
                }
            }

            if(isUserOk && isPasswordOk)
            {
                while (!userExist && userDB != null)
                {
                    if (user.Equals(userDB) && password.Equals(passwordDB))
                    {
                        userExist = true;
                    }
                    else
                    {
                        user = sr.ReadLine();
                        password = sr.ReadLine();
                    }
                }

                sr.Close();

                if (userExist)
                {
                    FrmPrincipal Principal = new FrmPrincipal();
                    Principal.MdiParent = this.MdiParent;
                    Principal.Show();
                    this.Close();
                }
                else
                {
                    txtErrosUser.Text = "Usuario no encontrado";
                }
            }
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister Register = new FrmRegister();
            Register.MdiParent = this.MdiParent;
            Register.Show();
            this.Close();
        }
    }
}
