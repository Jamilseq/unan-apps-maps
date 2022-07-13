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
    public partial class FrmRoutesScreen : Form
    {
        public FrmRoutesScreen()
        {
            InitializeComponent();
        }

        private void buttonCloseRoute_Click(object sender, EventArgs e)
        {
            FrmPrincipal Principal = new FrmPrincipal();
            Principal.MdiParent = this.MdiParent;
            Principal.Show();
            this.Close();

        }
    }
}
