using src.Forms;
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
    public partial class FrmPrincipalMDI : Form
    {
        public FrmPrincipalMDI()
        {
            InitializeComponent();
        }

        private void FrmPrincipalMDI_Load(object sender, EventArgs e)
        {
            FrmLogin Login = new FrmLogin();
            Login.MdiParent = this;
            Login.Show();

            FrmRegister Register = new FrmRegister();
            Register.MdiParent = this;

            FrmPrincipal Principal = new FrmPrincipal();
            Principal.MdiParent = this;

            FrmRoutesScreen Routes = new FrmRoutesScreen(0);
            Routes.MdiParent = this;

            FrmVRScreen VR = new FrmVRScreen(0);
            VR.MdiParent = this;
            
        }
    }
}
