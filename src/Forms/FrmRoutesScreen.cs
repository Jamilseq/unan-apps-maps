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
    public partial class FrmRoutesScreen : Form
    {
        public FrmRoutesScreen(int index)
        {
            InitializeComponent();
        }

        private void FrmRoutesScreen_Load(object sender, EventArgs e)
        {

            //this.BackgroundImage = images[index];
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
